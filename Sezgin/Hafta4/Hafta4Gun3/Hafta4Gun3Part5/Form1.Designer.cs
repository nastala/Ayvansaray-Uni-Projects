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
            this.tvDirectories = new System.Windows.Forms.TreeView();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbExtensions = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // tvDirectories
            // 
            this.tvDirectories.Location = new System.Drawing.Point(16, 49);
            this.tvDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.tvDirectories.Name = "tvDirectories";
            this.tvDirectories.Size = new System.Drawing.Size(171, 393);
            this.tvDirectories.TabIndex = 0;
            this.tvDirectories.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDirectories_NodeMouseClick);
            // 
            // cbDrives
            // 
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(17, 16);
            this.cbDrives.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(171, 24);
            this.cbDrives.TabIndex = 2;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(196, 426);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // cbExtensions
            // 
            this.cbExtensions.FormattingEnabled = true;
            this.cbExtensions.Location = new System.Drawing.Point(199, 396);
            this.cbExtensions.Margin = new System.Windows.Forms.Padding(4);
            this.cbExtensions.Name = "cbExtensions";
            this.cbExtensions.Size = new System.Drawing.Size(128, 24);
            this.cbExtensions.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(336, 396);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 26);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lvFiles
            // 
            this.lvFiles.Location = new System.Drawing.Point(199, 16);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(500, 373);
            this.lvFiles.TabIndex = 6;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 458);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cbExtensions);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbDrives);
            this.Controls.Add(this.tvDirectories);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}

