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
            values.TabPage.Controls.Add(textBox);
            dicDocuments.Add(values.TabPage.Name, values);
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
                using(StreamReader sr = new StreamReader(openFileDialog.FileName))
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
            
        }

        private bool IsTBChanged(TabPage tabPage)
        {
            return false;
        }

        private void tsbtnFileSave_Click(object sender, EventArgs e)
        {
            int keyIndex = tcFiles.SelectedIndex;
            string key = dicDocuments.Keys.ElementAt(keyIndex);
            TabPageValues tabPageValues = dicDocuments[key];
            foreach(Control control in tabPageValues.TabPage.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Equals(tabPageValues.TextValue))
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
                
            }
            else
                saveDocument(tabPageValues.Path, tabPageValues.TextValue);

            dicDocuments[key] = tabPageValues;
        }

        private void saveDocument(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
                sw.Write(text.ToCharArray());
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
