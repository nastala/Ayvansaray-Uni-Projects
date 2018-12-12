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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateCbDrives();
            updateTvDirectories();
        }

        private void updateTvDirectories()
        {
            tvDirectories.Nodes.Add(findDirectories(@"C:\", new TreeNode("")));
        }

        private TreeNode findDirectories(string path, TreeNode parentNode)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if(directoryInfo.GetDirectories().Length > 0)
            {
                TreeNode subNode;
                foreach (DirectoryInfo subDir in directoryInfo.GetDirectories())
                {
                    subNode = new TreeNode(subDir.Name);
                    if (subDir.GetDirectories().Length > 0)
                        return subNode.Nodes.Add(findDirectories(subDir.FullName, subNode));
                    parentNode.Nodes.Add(subNode);
                }
            }
            //else
            //{
            //    parentNode.Nodes.Add(treeNode);
            //    return parentNode;
            //}
            return parentNode;
        }

        private void updateCbDrives()
        {
            foreach (string drive in Directory.GetLogicalDrives())
                cbDrives.Items.Add(drive);

            if (cbDrives.Items.Count > 0)
                cbDrives.SelectedIndex = 0;
        }
    }
}
