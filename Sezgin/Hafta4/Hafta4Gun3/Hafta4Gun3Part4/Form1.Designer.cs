namespace Hafta4Gun3Part4
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
            this.tbCreateRemoveDirectory = new System.Windows.Forms.TextBox();
            this.lbDrives = new System.Windows.Forms.ListBox();
            this.btnDrives = new System.Windows.Forms.Button();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.btnSubDrives = new System.Windows.Forms.Button();
            this.lbSubDrives = new System.Windows.Forms.ListBox();
            this.btnSubFiles = new System.Windows.Forms.Button();
            this.lbSubFiles = new System.Windows.Forms.ListBox();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.btnRemoveDirectory = new System.Windows.Forms.Button();
            this.btnCurrentPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSourcePath = new System.Windows.Forms.TextBox();
            this.tbTargetPath = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCreateRemoveDirectory
            // 
            this.tbCreateRemoveDirectory.Location = new System.Drawing.Point(12, 12);
            this.tbCreateRemoveDirectory.Name = "tbCreateRemoveDirectory";
            this.tbCreateRemoveDirectory.Size = new System.Drawing.Size(297, 20);
            this.tbCreateRemoveDirectory.TabIndex = 0;
            // 
            // lbDrives
            // 
            this.lbDrives.FormattingEnabled = true;
            this.lbDrives.Location = new System.Drawing.Point(12, 65);
            this.lbDrives.Name = "lbDrives";
            this.lbDrives.Size = new System.Drawing.Size(95, 212);
            this.lbDrives.TabIndex = 1;
            this.lbDrives.SelectedIndexChanged += new System.EventHandler(this.lbDrives_SelectedIndexChanged);
            // 
            // btnDrives
            // 
            this.btnDrives.Location = new System.Drawing.Point(28, 283);
            this.btnDrives.Name = "btnDrives";
            this.btnDrives.Size = new System.Drawing.Size(61, 34);
            this.btnDrives.TabIndex = 2;
            this.btnDrives.Text = "Diskler";
            this.btnDrives.UseVisualStyleBackColor = true;
            this.btnDrives.Click += new System.EventHandler(this.btnDrives_Click);
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.Location = new System.Drawing.Point(25, 330);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(128, 13);
            this.lblCurrentPath.TabIndex = 3;
            this.lblCurrentPath.Text = "Nerede Olduğunu Göster:";
            // 
            // btnSubDrives
            // 
            this.btnSubDrives.Location = new System.Drawing.Point(129, 283);
            this.btnSubDrives.Name = "btnSubDrives";
            this.btnSubDrives.Size = new System.Drawing.Size(61, 34);
            this.btnSubDrives.TabIndex = 5;
            this.btnSubDrives.Text = "C:";
            this.btnSubDrives.UseVisualStyleBackColor = true;
            this.btnSubDrives.Click += new System.EventHandler(this.btnSubDrives_Click);
            // 
            // lbSubDrives
            // 
            this.lbSubDrives.FormattingEnabled = true;
            this.lbSubDrives.Location = new System.Drawing.Point(113, 65);
            this.lbSubDrives.Name = "lbSubDrives";
            this.lbSubDrives.Size = new System.Drawing.Size(95, 212);
            this.lbSubDrives.TabIndex = 4;
            // 
            // btnSubFiles
            // 
            this.btnSubFiles.Location = new System.Drawing.Point(230, 283);
            this.btnSubFiles.Name = "btnSubFiles";
            this.btnSubFiles.Size = new System.Drawing.Size(61, 34);
            this.btnSubFiles.TabIndex = 7;
            this.btnSubFiles.Text = "C: diski";
            this.btnSubFiles.UseVisualStyleBackColor = true;
            this.btnSubFiles.Click += new System.EventHandler(this.btnSubFiles_Click);
            // 
            // lbSubFiles
            // 
            this.lbSubFiles.FormattingEnabled = true;
            this.lbSubFiles.Location = new System.Drawing.Point(214, 65);
            this.lbSubFiles.Name = "lbSubFiles";
            this.lbSubFiles.Size = new System.Drawing.Size(95, 212);
            this.lbSubFiles.TabIndex = 6;
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(117, 34);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(91, 25);
            this.btnCreateDirectory.TabIndex = 8;
            this.btnCreateDirectory.Text = "Dizin Oluştur";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // btnRemoveDirectory
            // 
            this.btnRemoveDirectory.Location = new System.Drawing.Point(216, 34);
            this.btnRemoveDirectory.Name = "btnRemoveDirectory";
            this.btnRemoveDirectory.Size = new System.Drawing.Size(75, 25);
            this.btnRemoveDirectory.TabIndex = 9;
            this.btnRemoveDirectory.Text = "Dizin Sil";
            this.btnRemoveDirectory.UseVisualStyleBackColor = true;
            this.btnRemoveDirectory.Click += new System.EventHandler(this.btnRemoveDirectory_Click);
            // 
            // btnCurrentPath
            // 
            this.btnCurrentPath.Location = new System.Drawing.Point(212, 330);
            this.btnCurrentPath.Name = "btnCurrentPath";
            this.btnCurrentPath.Size = new System.Drawing.Size(79, 26);
            this.btnCurrentPath.TabIndex = 10;
            this.btnCurrentPath.Text = "Neredeyim";
            this.btnCurrentPath.UseVisualStyleBackColor = true;
            this.btnCurrentPath.Click += new System.EventHandler(this.btnCurrentPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Taşınacak Dizin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yeni Dizin:";
            // 
            // tbSourcePath
            // 
            this.tbSourcePath.Location = new System.Drawing.Point(129, 372);
            this.tbSourcePath.Name = "tbSourcePath";
            this.tbSourcePath.Size = new System.Drawing.Size(180, 20);
            this.tbSourcePath.TabIndex = 13;
            // 
            // tbTargetPath
            // 
            this.tbTargetPath.Location = new System.Drawing.Point(129, 398);
            this.tbTargetPath.Name = "tbTargetPath";
            this.tbTargetPath.Size = new System.Drawing.Size(180, 20);
            this.tbTargetPath.TabIndex = 14;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(230, 424);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(61, 34);
            this.btnMove.TabIndex = 15;
            this.btnMove.Text = "Taşı";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 475);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.tbTargetPath);
            this.Controls.Add(this.tbSourcePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCurrentPath);
            this.Controls.Add(this.btnRemoveDirectory);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.btnSubFiles);
            this.Controls.Add(this.lbSubFiles);
            this.Controls.Add(this.btnSubDrives);
            this.Controls.Add(this.lbSubDrives);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.btnDrives);
            this.Controls.Add(this.lbDrives);
            this.Controls.Add(this.tbCreateRemoveDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCreateRemoveDirectory;
        private System.Windows.Forms.ListBox lbDrives;
        private System.Windows.Forms.Button btnDrives;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.Button btnSubDrives;
        private System.Windows.Forms.ListBox lbSubDrives;
        private System.Windows.Forms.Button btnSubFiles;
        private System.Windows.Forms.ListBox lbSubFiles;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.Button btnRemoveDirectory;
        private System.Windows.Forms.Button btnCurrentPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSourcePath;
        private System.Windows.Forms.TextBox tbTargetPath;
        private System.Windows.Forms.Button btnMove;
    }
}

