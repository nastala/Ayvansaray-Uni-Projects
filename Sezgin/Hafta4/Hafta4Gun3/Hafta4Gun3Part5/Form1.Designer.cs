namespace Hafta4Gun3Part5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbExtensions = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.ilFolders = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvDirectories
            // 
            this.tvDirectories.Location = new System.Drawing.Point(12, 40);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.Size = new System.Drawing.Size(129, 320);
            this.tvDirectories.TabIndex = 0;
            this.tvDirectories.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDirectories_BeforeCollapse);
            this.tvDirectories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvDirectories_BeforeExpand);
            this.tvDirectories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDirectories_NodeMouseClick);
            // 
            // cbDrives
            // 
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(13, 13);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(129, 21);
            this.cbDrives.TabIndex = 2;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(147, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // cbExtensions
            // 
            this.cbExtensions.FormattingEnabled = true;
            this.cbExtensions.Location = new System.Drawing.Point(149, 322);
            this.cbExtensions.Name = "cbExtensions";
            this.cbExtensions.Size = new System.Drawing.Size(97, 21);
            this.cbExtensions.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(252, 322);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(64, 21);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lvFiles
            // 
            this.lvFiles.Location = new System.Drawing.Point(149, 13);
            this.lvFiles.Margin = new System.Windows.Forms.Padding(2);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(376, 304);
            this.lvFiles.TabIndex = 6;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // ilFolders
            // 
            this.ilFolders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilFolders.ImageStream")));
            this.ilFolders.TransparentColor = System.Drawing.Color.Transparent;
            this.ilFolders.Images.SetKeyName(0, "BlueFolder.png");
            this.ilFolders.Images.SetKeyName(1, "GreenFolder.png");
            this.ilFolders.Images.SetKeyName(2, "BlueFolder2.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 372);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbExtensions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbDrives);
            this.Controls.Add(this.tvDirectories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDirectories;
        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbExtensions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ImageList ilFolders;
    }
}

