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
        private List<FileInfo> mainFiles;
        private Dictionary<string, string> mainExtensions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainExtensions = new Dictionary<string, string>();
            mainFiles = new List<FileInfo>();
            updateCbDrives();
            initializeLvFiles();
        }

        private void initializeLvFiles()
        {
            tvDirectories.ImageList = ilFolders;
            lvFiles.View = View.Details;
            lvFiles.Columns.Add("Dosya Adı", 210, HorizontalAlignment.Left);
            lvFiles.Columns.Add("Boyut", 50, HorizontalAlignment.Left);
            lvFiles.Columns.Add("Oluşturma Tarihi", 240, HorizontalAlignment.Left);
        }

        private void updateTvDirectories(string drive)
        {
            tvDirectories.Nodes.Add(findDirectories(@"F:\", @"F:\"));
        }

        private TreeNode findDirectories(string name, string path)
        {
            TreeNode currentNode = new TreeNode(name);
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            try
            {
                if (currentDirectory.GetDirectories().Length > 0)
                {
                    currentNode.ImageIndex = 0;
                    foreach (DirectoryInfo directory in currentDirectory.GetDirectories())
                    {
                        currentNode.Nodes.Add(findDirectories(directory.Name, directory.FullName));
                    }
                }
                else
                    currentNode.ImageIndex = 1;
            }
            catch (Exception exc)
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

        private void addToExtensions(List<string> extensions)
        {
            mainExtensions.Clear();

            if (extensions.Count == 0)
            {
                cbExtensions.Items.Clear();
                cbExtensions.Items.Add("None");
                cbExtensions.SelectedIndex = 0;
                return;
            }

            if (mainExtensions.Count == 0)
                mainExtensions.Add("None", "None");

            int extensionCount;
            foreach (string extension in extensions)
            {
                if (mainExtensions.Keys.Contains(extension))
                    continue;

                extensionCount = 0;
                for(int i = 0; i < extensions.Count; i++)
                {
                    if (extensions[i].Equals(extension))
                        extensionCount++;
                }

                mainExtensions.Add(extension, extension + " " + extensionCount + " files");
            }

            updateCbExtensions();
        }

        private void updateLvFiles(List<FileInfo> files)
        {
            lvFiles.Items.Clear();
            float totalSize = 0;
            List<string> extensions = new List<string>();
            foreach (FileInfo file in files)
            {
                extensions.Add(file.Extension);
                lvFiles.Items.Add(new ListViewItem(new string[] { file.Name, file.Length.ToString(),
                        String.Format("{0:dddd, MMMM d, yyyy}", file.CreationTimeUtc) }));
                totalSize += file.Length;
            }
            addToExtensions(extensions);

            string text = "";
            int numFiles = files.Count;
            if (numFiles > 1)
                text = "There are " + numFiles + " files. Size: ";
            else
                text = "There is " + numFiles + " file. Size: ";

            if (totalSize >= oneMB)
                text += string.Format("{0:0.00} MB", totalSize / oneMB);
            else if (totalSize >= oneKB)
                text += string.Format("{0:0.00} KB", totalSize / oneKB);
            else
                text += totalSize + " Bytes";
            
            lblStatus.Text = text;
        }

        private void updateCbExtensions()
        {
            cbExtensions.Items.Clear();
            cbExtensions.Items.AddRange(mainExtensions.Values.ToArray());
            if (cbExtensions.Items.Count > 2)
                cbExtensions.SelectedIndex = 0;
        }

        private void tvDirectories_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                mainFiles.Clear();
                DirectoryInfo currentDirectory = new DirectoryInfo(e.Node.FullPath);
                foreach (FileInfo file in currentDirectory.GetFiles())
                    mainFiles.Add(file);

                updateLvFiles(mainFiles);
            }
        }

        private void filterFiles(string extension)
        {
            if (string.IsNullOrEmpty(extension) || extension.Equals("None"))
                updateLvFiles(mainFiles);
            else
            {
                List<FileInfo> filteredFiles = new List<FileInfo>();
                foreach(FileInfo file in mainFiles)
                {
                    if (file.Extension.Equals(extension))
                        filteredFiles.Add(file);
                }

                updateLvFiles(filteredFiles);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(cbExtensions.SelectedIndex != -1 && mainFiles.Count > 0)
                filterFiles(mainExtensions.Keys.ElementAt(cbExtensions.SelectedIndex));
        }

        private void tvDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 2;
        }

        private void tvDirectories_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
    }
}
