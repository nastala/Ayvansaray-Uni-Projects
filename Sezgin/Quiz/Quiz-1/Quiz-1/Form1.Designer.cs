namespace Quiz_1
{
    partial class MainForm
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
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSeats
            // 
            this.pnlSeats.AutoScroll = true;
            this.pnlSeats.Location = new System.Drawing.Point(362, 12);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(426, 261);
            this.pnlSeats.TabIndex = 1;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(12, 12);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(75, 23);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 285);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.pnlSeats);
            this.Name = "MainForm";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Button btnAdminPanel;
    }
}

