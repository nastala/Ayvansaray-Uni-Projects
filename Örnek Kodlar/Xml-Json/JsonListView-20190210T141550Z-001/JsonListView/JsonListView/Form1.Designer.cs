namespace JsonListView
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
            this.jsonDosyasıOlusturmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jsonDosyasıGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jsonDosyasıOlusturmaToolStripMenuItem,
            this.jsonDosyasıGörüntülemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jsonDosyasıOlusturmaToolStripMenuItem
            // 
            this.jsonDosyasıOlusturmaToolStripMenuItem.Name = "jsonDosyasıOlusturmaToolStripMenuItem";
            this.jsonDosyasıOlusturmaToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.jsonDosyasıOlusturmaToolStripMenuItem.Text = "Json Dosyası Olusturma";
            this.jsonDosyasıOlusturmaToolStripMenuItem.Click += new System.EventHandler(this.jsonDosyasıOlusturmaToolStripMenuItem_Click);
            // 
            // jsonDosyasıGörüntülemeToolStripMenuItem
            // 
            this.jsonDosyasıGörüntülemeToolStripMenuItem.Name = "jsonDosyasıGörüntülemeToolStripMenuItem";
            this.jsonDosyasıGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.jsonDosyasıGörüntülemeToolStripMenuItem.Text = "JsonDosyası Görüntüleme";
            this.jsonDosyasıGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.jsonDosyasıGörüntülemeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 357);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jsonDosyasıOlusturmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jsonDosyasıGörüntülemeToolStripMenuItem;
    }
}

