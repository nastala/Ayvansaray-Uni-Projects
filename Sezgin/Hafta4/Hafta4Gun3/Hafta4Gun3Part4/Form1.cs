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

namespace Hafta4Gun3Part4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrives_Click(object sender, EventArgs e)
        {
            updateLbDrives();
        }

        private void updateLbDrives()
        {
            lbDrives.Items.Clear();
            foreach (string drive in Directory.GetLogicalDrives())
                lbDrives.Items.Add(drive);
        }

        private void lbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbDrives.SelectedIndex != -1)
                updateLbSubDirectories(lbDrives.SelectedItem.ToString()); 
        }

        private void btnSubDrives_Click(object sender, EventArgs e)
        {
            updateLbSubDirectories(@"C:\");
        }

        private void btnSubFiles_Click(object sender, EventArgs e)
        {
            updateLbSubFiles();
        }

        private void updateLbSubDirectories(string path)
        {
            lbSubDrives.Items.Clear();
            try
            {
                foreach (string subDir in Directory.GetDirectories(path))
                    lbSubDrives.Items.Add(subDir);
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error occured! Error message: " + exc.Message);
            }
        }

        private void updateLbSubFiles()
        {
            lbSubFiles.Items.Clear();
            foreach (string subFile in Directory.GetFiles(@"C:\"))
                lbSubFiles.Items.Add(subFile);
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string path = tbCreateRemoveDirectory.Text;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    updateLbSubDirectories(@"C:\");
                }
                else
                {
                    MessageBox.Show("A directory is already created on the path, please remove it first!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured! Error Message: " + exc.Message);
            }
        }

        private void btnRemoveDirectory_Click(object sender, EventArgs e)
        {
            string path = tbCreateRemoveDirectory.Text;
            try
            {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path);
                    updateLbSubDirectories(@"C:\");
                }
                else
                {
                    MessageBox.Show("The directory you entered couldn't be found!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured! Error Message: " + exc.Message);
            }
        }

        private void btnCurrentPath_Click(object sender, EventArgs e)
        {
            lblCurrentPath.Text = Directory.GetCurrentDirectory();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string source = tbSourcePath.Text;
            string target = tbTargetPath.Text;
            try
            {
                if (Directory.Exists(source))
                {
                    if (Directory.Exists(target))
                    {
                        Directory.Delete(target);
                    }

                    Directory.Move(source, target);
                    updateLbSubDirectories(@"C:\");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error occured! Error Message: " + exc.Message);
            }
        }
    }
}
