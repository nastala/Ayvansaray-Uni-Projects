using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4Gun5
{
    public partial class Form1 : Form
    {
        private int lastIndex;
        private Dictionary<string, TabPageValues> dicDocuments;
        private List<TabPageValues> documents;
        private const string filter = "*.txt|*.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtnNewFile_Click(object sender, EventArgs e)
        {
            lastIndex++;
            TabPage tabPage = new TabPage();
            tabPage.Name = "tabPage" + lastIndex;
            tabPage.Text = "New " + lastIndex;
            TabPageValues tabPageValues = new TabPageValues();
            tabPageValues.TabPage = tabPage;
            addTextBox(tabPageValues);
            tcFiles.Controls.Add(tabPage);
            tcFiles.SelectedTab = tabPage;
        }

        private void addTextBox(TabPageValues values)
        {
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Size = new Size(768, 350);
            textBox.Text = values.TextValue;
            textBox.Name = "textBox";
            textBox.ContextMenuStrip = cmsTpTextBox;
            textBox.TextChanged += new EventHandler(TabPageTextBoxChanged);
            values.TabPage.Controls.Add(textBox);
            dicDocuments.Add(values.TabPage.Name, values);
            documents.Add(values);
        }

        private void TabPageTextBoxChanged(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            TextBox textBox = (TextBox)sender;
            if ((!(textBox.Text.Equals(tabPageValues.TextValue))) && (!tabPageValues.TabPage.Text.Contains(" *")))
            {
                tabPageValues.TabPage.Text = tabPageValues.TabPage.Text + " *";
            }
            ssLblTextCount.Text = textBox.Text.Length.ToString();
            dicDocuments[key] = tabPageValues;
        }

        private void tsbtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = Path.GetFileName(openFileDialog.FileName);
                TabPage tabPage = new TabPage();
                tabPage.Text = fileName;
                tabPage.Name = fileName;
                TabPageValues tabPageValues = new TabPageValues();
                tabPageValues.TabPage = tabPage;
                tabPageValues.Path = openFileDialog.FileName;
                tabPageValues.IsNameDefault = false;
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    tabPageValues.TextValue = sr.ReadToEnd();
                }
                addTextBox(tabPageValues);

                tcFiles.Controls.Add(tabPageValues.TabPage);
                tcFiles.SelectedTab = tabPage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lastIndex = 1;
            documents = new List<TabPageValues>();
            dicDocuments = new Dictionary<string, TabPageValues>();
            tcFiles.ContextMenuStrip = cmsTcFiles;
            for (int i = 0; i < tcFiles.TabCount; i++)
            {
                TabPageValues tabPageValues = new TabPageValues();
                tabPageValues.TabPage = tcFiles.TabPages[i];
                addTextBox(tabPageValues);
            }
        }

        private void csmsClose_Click(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            foreach (Control control in tabPageValues.TabPage.Controls)
            {
                if (control is TextBox)
                {
                    string text = control.Text;
                    if (!text.Equals(tabPageValues.TextValue))
                    {
                        if ((MessageBox.Show("You have unsaved changes. Do you want to save them?", "Warning", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                        {
                            if (tabPageValues.IsNameDefault)
                            {
                                SaveFileDialog saveFileDialog = new SaveFileDialog();
                                saveFileDialog.Filter = filter;
                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                    saveDocument(saveFileDialog.FileName, text);
                                else
                                    return;
                            }
                            else
                                saveDocument(tabPageValues.Path, text);
                        }
                    }

                    break;
                }
            }
            if (tabPageValues.IsNameDefault)
                lastIndex--;
            tcFiles.TabPages.RemoveAt(keyIndex);
            dicDocuments.Remove(key);
        }

        private void tsbtnFileSave_Click(object sender, EventArgs e)
        {
            if (tcFiles.TabPages.Count < 1)
                return;

            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            TextBox textBox = new TextBox();
            foreach (Control control in tabPageValues.TabPage.Controls)
            {
                textBox = control as TextBox;
                if (textBox != null)
                {
                    if (textBox.Text.Equals(tabPageValues.TextValue))
                        return;
                    tabPageValues.TextValue = control.Text;
                    break;
                }
            }

            if (tabPageValues.IsNameDefault)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = filter;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileName(saveFileDialog.FileName);
                    tabPageValues.TabPage.Name = fileName;
                    tabPageValues.TabPage.Text = fileName;
                    tabPageValues.Path = saveFileDialog.FileName;
                    tabPageValues.IsNameDefault = false;
                    saveDocument(tabPageValues.Path, tabPageValues.TextValue);
                }
                else
                    return;
            }
            else
                saveDocument(tabPageValues.Path, tabPageValues.TextValue);

            tabPageValues.TabPage.Text = tabPageValues.TabPage.Text.Substring(0, tabPageValues.TabPage.Text.Length - 2);
            if(textBox != null)
                textBox.TextChanged += new EventHandler(TabPageTextBoxChanged);
            dicDocuments[key] = tabPageValues;
        }

        private void saveDocument(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
                sw.Write(text.ToCharArray());
        }

        private void msFormatFontType_Click(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Control control in tabPageValues.TabPage.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Font = fontDialog1.Font;
                    }
                }
            }
        }

        private void cmsTpTextBoxSelectAll_Click(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            foreach (Control control in tabPageValues.TabPage.Controls)
            {
                TextBox textBox = control as TextBox;
                if (textBox != null)
                    textBox.SelectAll();
            }
        }

        private void tcFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            foreach (Control control in tabPageValues.TabPage.Controls)
            {
                TextBox textBox = control as TextBox;
                if(textBox != null)
                    ssLblTextCount.Text = textBox.Text.Length.ToString();
            }
        }
    }

    class TabPageValues
    {
        public string TextValue { get; set; }
        public string Path { get; set; }
        public TabPage TabPage { get; set; }
        public bool IsNameDefault { get; set; }
        public TabPageValues()
        {
            IsNameDefault = true;
            TextValue = "";
            Path = "";
        }
    }
}
