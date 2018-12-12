using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hafta4Gun3Part5
{
    public partial class Form1 : Form
    {
        private const int oneKB = 1024;
        private const int oneMB = oneKB * 1024;
        private List<string> extensions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            extensions = new List<string>();
            updateCbDrives();
            initializeLvFiles();
        }

        private void initializeLvFiles()
        {
            lvFiles.View = View.Details;
            lvFiles.Columns.Add("Dosya Adı", 210, HorizontalAlignment.Left);
            lvFiles.Columns.Add("Boyut", 50, HorizontalAlignment.Left);
            lvFiles.Columns.Add("Oluşturma Tarihi", 240, HorizontalAlignment.Left);
        }

        private void updateTvDirectories(string drive)
        {
            tvDirectories.Nodes.Add(findDirectories(@"D:\Ayvansaray Uni Projects", @"D:\Ayvansaray Uni Projects"));
        }

        private TreeNode findDirectories(string name, string path)
        {
            TreeNode currentNode = new TreeNode(name);
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            try
            {
                if (currentDirectory.GetDirectories().Length > 0)
                {
                    foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
                    {
                        currentNode.Nodes.Add(findDirectories(directory.Name, directory.FullName));
                    }
                }
            }
            catch(Exception exc)
            {

            }

            return currentNode;
        }

        private void updateCbDrives()
        {
            foreach (string drive in Directory.GetLogicalDrives())
                cbDrives.Items.Add(drive);

            if (cbDrives.Items.Count > 0)
                cbDrives.SelectedIndex = 0;
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbDrives.SelectedItem.ToString()))
                updateTvDirectories(cbDrives.SelectedItem.ToString());
        }

        private void addToExtensions(string newExtension)
        {
            if (string.IsNullOrWhiteSpace(newExtension))
                return;

            foreach(string extension in extensions)
            {
                if (extension.Equals(newExtension))
                    return;
            }

            extensions.Add(newExtension);
        }

        private void tvDirectories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lvFiles.Items.Clear();
                extensions.Clear();
                MessageBox.Show(e.Node.Text);
                DirectoryInfo currentDirectory = new DirectoryInfo(e.Node.FullPath);
                float totalSize = 0;
                foreach (FileInfo file in currentDirectory.GetFiles())
                {
                    addToExtensions(file.Extension);
                    lvFiles.Items.Add(new ListViewItem(new string[] { file.Name, file.Length.ToString(),
                        String.Format("{0:dddd, MMMM d, yyyy}", file.CreationTimeUtc) }));
                    totalSize += file.Length;
                }

                string text = "";
                int numFiles = currentDirectory.GetFiles().Length;
                if (numFiles > 1)
                    text = "There are " + numFiles + " files. Size: ";
                if (totalSize >= oneMB)
                    text += string.Format("{0:0.00} MB", totalSize / oneMB);
                else if (totalSize >= oneKB)
                    text += string.Format("{0:0.00} KB", totalSize / oneKB);
                else
                    text += totalSize + " Bytes";

                cbExtensions.Items.AddRange(extensions.ToArray());
                lblStatus.Text = text;
            }
        }
    }
}
