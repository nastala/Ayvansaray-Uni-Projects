namespace Hafta4Gun5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFileMain = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.msFormatMain = new System.Windows.Forms.ToolStripMenuItem();
            this.msFormatFontType = new System.Windows.Forms.ToolStripMenuItem();
            this.msFormatFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.msLetterMain = new System.Windows.Forms.ToolStripMenuItem();
            this.msLetterUpper = new System.Windows.Forms.ToolStripMenuItem();
            this.msLetterLower = new System.Windows.Forms.ToolStripMenuItem();
            this.msSearchMain = new System.Windows.Forms.ToolStripMenuItem();
            this.msAboutMain = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFileSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tcFiles = new System.Windows.Forms.TabControl();
            this.tpFile1 = new System.Windows.Forms.TabPage();
            this.cmsTcFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csmsClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.cmsTpTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTpTextBoxSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ssTabPage = new System.Windows.Forms.StatusStrip();
            this.ssLblTextCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tcFiles.SuspendLayout();
            this.cmsTcFiles.SuspendLayout();
            this.cmsTpTextBox.SuspendLayout();
            this.ssTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileMain,
            this.msFormatMain,
            this.msLetterMain,
            this.msSearchMain,
            this.msAboutMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1058, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFileMain
            // 
            this.msFileMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileNew,
            this.msFileOpen,
            this.msFileSave});
            this.msFileMain.Name = "msFileMain";
            this.msFileMain.Size = new System.Drawing.Size(62, 24);
            this.msFileMain.Text = "Dosya";
            // 
            // msFileNew
            // 
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.Size = new System.Drawing.Size(130, 26);
            this.msFileNew.Text = "Yeni";
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.Size = new System.Drawing.Size(130, 26);
            this.msFileOpen.Text = "Aç";
            // 
            // msFileSave
            // 
            this.msFileSave.Name = "msFileSave";
            this.msFileSave.Size = new System.Drawing.Size(130, 26);
            this.msFileSave.Text = "Kaydet";
            // 
            // msFormatMain
            // 
            this.msFormatMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFormatFontType,
            this.msFormatFontColor});
            this.msFormatMain.Name = "msFormatMain";
            this.msFormatMain.Size = new System.Drawing.Size(117, 24);
            this.msFormatMain.Text = "Biçimlendirme";
            // 
            // msFormatFontType
            // 
            this.msFormatFontType.Name = "msFormatFontType";
            this.msFormatFontType.Size = new System.Drawing.Size(152, 26);
            this.msFormatFontType.Text = "Yazı Tipi";
            this.msFormatFontType.Click += new System.EventHandler(this.msFormatFontType_Click);
            // 
            // msFormatFontColor
            // 
            this.msFormatFontColor.Name = "msFormatFontColor";
            this.msFormatFontColor.Size = new System.Drawing.Size(152, 26);
            this.msFormatFontColor.Text = "Yazı Rengi";
            // 
            // msLetterMain
            // 
            this.msLetterMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLetterUpper,
            this.msLetterLower});
            this.msLetterMain.Name = "msLetterMain";
            this.msLetterMain.Size = new System.Drawing.Size(110, 24);
            this.msLetterMain.Text = "Harf İşlemleri";
            // 
            // msLetterUpper
            // 
            this.msLetterUpper.Name = "msLetterUpper";
            this.msLetterUpper.Size = new System.Drawing.Size(165, 26);
            this.msLetterUpper.Text = "Hepsi Büyük";
            // 
            // msLetterLower
            // 
            this.msLetterLower.Name = "msLetterLower";
            this.msLetterLower.Size = new System.Drawing.Size(165, 26);
            this.msLetterLower.Text = "Hepsi Küçük";
            // 
            // msSearchMain
            // 
            this.msSearchMain.Name = "msSearchMain";
            this.msSearchMain.Size = new System.Drawing.Size(44, 24);
            this.msSearchMain.Text = "Ara";
            // 
            // msAboutMain
            // 
            this.msAboutMain.Name = "msAboutMain";
            this.msAboutMain.Size = new System.Drawing.Size(83, 24);
            this.msAboutMain.Text = "Hakkında";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnNewFile,
            this.tsbtnFileSave,
            this.tsbtnOpenFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1058, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "tsFiles";
            // 
            // tsbtnNewFile
            // 
            this.tsbtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNewFile.Image")));
            this.tsbtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNewFile.Name = "tsbtnNewFile";
            this.tsbtnNewFile.Size = new System.Drawing.Size(24, 24);
            this.tsbtnNewFile.Text = "New File";
            this.tsbtnNewFile.Click += new System.EventHandler(this.tsbtnNewFile_Click);
            // 
            // tsbtnFileSave
            // 
            this.tsbtnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnFileSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnFileSave.Image")));
            this.tsbtnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFileSave.Name = "tsbtnFileSave";
            this.tsbtnFileSave.Size = new System.Drawing.Size(24, 24);
            this.tsbtnFileSave.Text = "Save";
            this.tsbtnFileSave.Click += new System.EventHandler(this.tsbtnFileSave_Click);
            // 
            // tsbtnOpenFile
            // 
            this.tsbtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnOpenFile.Image")));
            this.tsbtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenFile.Name = "tsbtnOpenFile";
            this.tsbtnOpenFile.Size = new System.Drawing.Size(24, 24);
            this.tsbtnOpenFile.Text = "Open File";
            this.tsbtnOpenFile.Click += new System.EventHandler(this.tsbtnOpenFile_Click);
            // 
            // tcFiles
            // 
            this.tcFiles.Controls.Add(this.tpFile1);
            this.tcFiles.Location = new System.Drawing.Point(16, 64);
            this.tcFiles.Margin = new System.Windows.Forms.Padding(4);
            this.tcFiles.Name = "tcFiles";
            this.tcFiles.SelectedIndex = 0;
            this.tcFiles.Size = new System.Drawing.Size(1035, 463);
            this.tcFiles.TabIndex = 2;
            this.tcFiles.SelectedIndexChanged += new System.EventHandler(this.tcFiles_SelectedIndexChanged);
            // 
            // tpFile1
            // 
            this.tpFile1.Location = new System.Drawing.Point(4, 25);
            this.tpFile1.Margin = new System.Windows.Forms.Padding(4);
            this.tpFile1.Name = "tpFile1";
            this.tpFile1.Padding = new System.Windows.Forms.Padding(4);
            this.tpFile1.Size = new System.Drawing.Size(1027, 434);
            this.tpFile1.TabIndex = 1;
            this.tpFile1.Text = "New 1";
            this.tpFile1.UseVisualStyleBackColor = true;
            // 
            // cmsTcFiles
            // 
            this.cmsTcFiles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTcFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csmsClose});
            this.cmsTcFiles.Name = "contextMenuStrip1";
            this.cmsTcFiles.Size = new System.Drawing.Size(118, 28);
            // 
            // csmsClose
            // 
            this.csmsClose.Name = "csmsClose";
            this.csmsClose.Size = new System.Drawing.Size(117, 24);
            this.csmsClose.Text = "Kapat";
            this.csmsClose.Click += new System.EventHandler(this.csmsClose_Click);
            // 
            // cmsTpTextBox
            // 
            this.cmsTpTextBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTpTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTpTextBoxSelectAll});
            this.cmsTpTextBox.Name = "contextMenuStrip1";
            this.cmsTpTextBox.Size = new System.Drawing.Size(156, 28);
            // 
            // cmsTpTextBoxSelectAll
            // 
            this.cmsTpTextBoxSelectAll.Name = "cmsTpTextBoxSelectAll";
            this.cmsTpTextBoxSelectAll.Size = new System.Drawing.Size(155, 24);
            this.cmsTpTextBoxSelectAll.Text = "Hepsini Seç";
            this.cmsTpTextBoxSelectAll.Click += new System.EventHandler(this.cmsTpTextBoxSelectAll_Click);
            // 
            // ssTabPage
            // 
            this.ssTabPage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssTabPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLblTextCount});
            this.ssTabPage.Location = new System.Drawing.Point(0, 541);
            this.ssTabPage.Name = "ssTabPage";
            this.ssTabPage.Size = new System.Drawing.Size(1058, 22);
            this.ssTabPage.TabIndex = 4;
            // 
            // ssLblTextCount
            // 
            this.ssLblTextCount.Name = "ssLblTextCount";
            this.ssLblTextCount.Size = new System.Drawing.Size(0, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 563);
            this.Controls.Add(this.ssTabPage);
            this.Controls.Add(this.tcFiles);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tcFiles.ResumeLayout(false);
            this.cmsTcFiles.ResumeLayout(false);
            this.cmsTpTextBox.ResumeLayout(false);
            this.ssTabPage.ResumeLayout(false);
            this.ssTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msFileMain;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripMenuItem msFileSave;
        private System.Windows.Forms.ToolStripMenuItem msFormatMain;
        private System.Windows.Forms.ToolStripMenuItem msFormatFontType;
        private System.Windows.Forms.ToolStripMenuItem msFormatFontColor;
        private System.Windows.Forms.ToolStripMenuItem msLetterMain;
        private System.Windows.Forms.ToolStripMenuItem msLetterUpper;
        private System.Windows.Forms.ToolStripMenuItem msLetterLower;
        private System.Windows.Forms.ToolStripMenuItem msSearchMain;
        private System.Windows.Forms.ToolStripMenuItem msAboutMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnNewFile;
        private System.Windows.Forms.ToolStripButton tsbtnFileSave;
        private System.Windows.Forms.ToolStripButton tsbtnOpenFile;
        private System.Windows.Forms.TabControl tcFiles;
        private System.Windows.Forms.TabPage tpFile1;
        private System.Windows.Forms.ContextMenuStrip cmsTcFiles;
        private System.Windows.Forms.ToolStripMenuItem csmsClose;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ContextMenuStrip cmsTpTextBox;
        private System.Windows.Forms.ToolStripMenuItem cmsTpTextBoxSelectAll;
        private System.Windows.Forms.StatusStrip ssTabPage;
        private System.Windows.Forms.ToolStripStatusLabel ssLblTextCount;
    }
}

