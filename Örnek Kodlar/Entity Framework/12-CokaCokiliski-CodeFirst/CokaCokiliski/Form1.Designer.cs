namespace CokaCokiliski
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrenciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciEgitmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(655, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrenciToolStripMenuItem
            // 
            this.ogrenciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrenciToolStripMenuItem1,
            this.egitmenToolStripMenuItem,
            this.ogrenciEgitmenToolStripMenuItem});
            this.ogrenciToolStripMenuItem.Name = "ogrenciToolStripMenuItem";
            this.ogrenciToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ogrenciToolStripMenuItem.Text = "Tanimlar";
            // 
            // egitmenToolStripMenuItem
            // 
            this.egitmenToolStripMenuItem.Name = "egitmenToolStripMenuItem";
            this.egitmenToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.egitmenToolStripMenuItem.Text = "Egitmen";
            this.egitmenToolStripMenuItem.Click += new System.EventHandler(this.egitmenToolStripMenuItem_Click);
            // 
            // ogrenciEgitmenToolStripMenuItem
            // 
            this.ogrenciEgitmenToolStripMenuItem.Name = "ogrenciEgitmenToolStripMenuItem";
            this.ogrenciEgitmenToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ogrenciEgitmenToolStripMenuItem.Text = "OgrenciEgitmen";
            this.ogrenciEgitmenToolStripMenuItem.Click += new System.EventHandler(this.ogrenciEgitmenToolStripMenuItem_Click);
            // 
            // ogrenciToolStripMenuItem1
            // 
            this.ogrenciToolStripMenuItem1.Name = "ogrenciToolStripMenuItem1";
            this.ogrenciToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.ogrenciToolStripMenuItem1.Text = "Ogrenci";
            this.ogrenciToolStripMenuItem1.Click += new System.EventHandler(this.ogrenciToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 321);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciEgitmenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciToolStripMenuItem1;
    }
}

