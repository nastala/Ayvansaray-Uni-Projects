namespace IK_Uygulama_CodeFirst
{
    partial class index
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egitimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişDüzeltmeSorgulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem,
            this.personelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egitimToolStripMenuItem,
            this.unvanToolStripMenuItem,
            this.ilToolStripMenuItem,
            this.ilceToolStripMenuItem});
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // egitimToolStripMenuItem
            // 
            this.egitimToolStripMenuItem.Name = "egitimToolStripMenuItem";
            this.egitimToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.egitimToolStripMenuItem.Text = "Egitim";
            this.egitimToolStripMenuItem.Click += new System.EventHandler(this.egitimToolStripMenuItem_Click);
            // 
            // unvanToolStripMenuItem
            // 
            this.unvanToolStripMenuItem.Name = "unvanToolStripMenuItem";
            this.unvanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unvanToolStripMenuItem.Text = "Unvan";
            this.unvanToolStripMenuItem.Click += new System.EventHandler(this.unvanToolStripMenuItem_Click);
            // 
            // ilToolStripMenuItem
            // 
            this.ilToolStripMenuItem.Name = "ilToolStripMenuItem";
            this.ilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ilToolStripMenuItem.Text = "İl";
            this.ilToolStripMenuItem.Click += new System.EventHandler(this.ilToolStripMenuItem_Click);
            // 
            // ilceToolStripMenuItem
            // 
            this.ilceToolStripMenuItem.Name = "ilceToolStripMenuItem";
            this.ilceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ilceToolStripMenuItem.Text = "İlce";
            this.ilceToolStripMenuItem.Click += new System.EventHandler(this.ilceToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişDüzeltmeSorgulamaToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // girişDüzeltmeSorgulamaToolStripMenuItem
            // 
            this.girişDüzeltmeSorgulamaToolStripMenuItem.Name = "girişDüzeltmeSorgulamaToolStripMenuItem";
            this.girişDüzeltmeSorgulamaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.girişDüzeltmeSorgulamaToolStripMenuItem.Text = "Giriş/Düzeltme/Sorgulama";
            this.girişDüzeltmeSorgulamaToolStripMenuItem.Click += new System.EventHandler(this.girişDüzeltmeSorgulamaToolStripMenuItem_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 433);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "index";
            this.Text = "Ana Sayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egitimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişDüzeltmeSorgulamaToolStripMenuItem;
    }
}

