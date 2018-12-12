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
using System.Collections;

namespace Hafta4Gun3Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            foreach (string drive in drives)
            {
                string[] subDirs = Directory.GetDirectories(drive);
                TreeNode subNode;
                List<TreeNode> treeNodes = new List<TreeNode>();
                foreach (string subDir in subDirs)
                {
                    subNode = new TreeNode(subDir);
                    treeNodes.Add(subNode);
                }

                tvDirectories.Nodes.Add(new TreeNode(drive, treeNodes.ToArray()));
            }
        }
    }
}
