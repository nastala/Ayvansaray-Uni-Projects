using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TabController
    {
        private readonly TabControl _tabControl;

        private int HighestOrder
        {
            get
            {
                int highest = 0;
                for (int i = 0; i < _tabControl.TabCount; ++i)
                {
                    var tabOrder = ((TabWithRTB)_tabControl.TabPages[i]).TabOrder;
                    if (tabOrder > highest)
                    {
                        highest = tabOrder;
                    }
                }

                return highest;
            }
        }

        public void Save(bool saveOnDifferentLocation = false)
        {
            var tab = (TabWithRTB)_tabControl.SelectedTab;
            if (saveOnDifferentLocation || string.IsNullOrWhiteSpace(tab.SaveLocation))
            {
                SaveText(true);
            }
            else
            {
                SaveText();
            }
        }
        private void SaveText(bool saveDifferent = false)
        {
            if (saveDifferent)
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Text File|*.txt";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var tab = (TabWithRTB)_tabControl.SelectedTab;

                        using (var sW = new StreamWriter(dialog.FileName))
                        {
                            sW.Write(tab.WrittenText);
                        }

                        var name = Path.GetFileName(dialog.FileName);
                        tab.TabTitle = name;
                        tab.SaveLocation = dialog.FileName;
                    }
                }
            }
            else
            {
                var tab = (TabWithRTB)_tabControl.SelectedTab;

                using (var sW = new StreamWriter(tab.SaveLocation))
                {
                    sW.Write(tab.WrittenText);
                }

                var name = Path.GetFileName(tab.SaveLocation);
                tab.TabTitle = name;
            }
        }

        private int CheckPagesIndexOf(string pageName)
        {
            for (int i = 0; i < _tabControl.TabCount; i++)
            {
                if (pageName.Equals(((TabWithRTB)_tabControl.TabPages[i]).SaveLocation))
                {
                    return i;
                }
            }

            return -1;
        }
        public void OpenText()
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Text File|*.txt";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = (dialog.FileName);
                    var index = CheckPagesIndexOf(fileName);
                    if (index != -1)
                    {
                        _tabControl.SelectedIndex = index;
                        return;
                    }
                    var tab = AddTabPage();
                    string info;

                    using (var sW = new StreamReader(dialog.FileName))
                    {
                        info = sW.ReadToEnd();
                    }

                    tab.WrittenText = info;
                    var name = Path.GetFileName(dialog.FileName);
                    tab.TabTitle = name;
                    tab.SaveLocation = dialog.FileName;
                    _tabControl.SelectedIndex = tab.TabOrder - 1;
                }
            }
        }
        public TabController(TabControl tabControl)
        {
            _tabControl = tabControl;
            _tabControl.MouseClick += TabControl_MouseClick;
        }

        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < _tabControl.TabCount; ++i)
                {
                    Rectangle r = _tabControl.GetTabRect(i);
                    if (r.Contains(e.Location) /* && it is the header that was clicked*/)
                    {
                        // Change slected index, get the page, create contextual menu
                        ContextMenu cm = new ContextMenu();
                        // Add several items to menu
                        cm.MenuItems.Add("Close", (s, ev) =>
                        {
                            RemovePage(i);
                        });
                        cm.Show(_tabControl, e.Location);
                        break;
                    }
                }
            }
        }

        internal TabWithRTB AddTabPage()
        {
            var tabWithRtb = new TabWithRTB(HighestOrder + 1);
            _tabControl.TabPages.Add(tabWithRtb);
            return tabWithRtb;
        }
        internal void RemovePage(MouseEventArgs e)
        {
            for (int i = 0; i < this._tabControl.TabPages.Count; i++)
            {
                Rectangle r = _tabControl.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 5, 14, 9);
                if (closeButton.Contains(e.Location))
                {
                    _tabControl.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        internal void RemovePage(int index)
        {
            _tabControl.TabPages.RemoveAt(index);
        }


    }
}
