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
            this.btnPurchaseTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSeats
            // 
            this.pnlSeats.AutoScroll = true;
            this.pnlSeats.Location = new System.Drawing.Point(483, 15);
            this.pnlSeats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(568, 321);
            this.pnlSeats.TabIndex = 1;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(16, 15);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(129, 54);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnPurchaseTicket
            // 
            this.btnPurchaseTicket.Location = new System.Drawing.Point(153, 15);
            this.btnPurchaseTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchaseTicket.Name = "btnPurchaseTicket";
            this.btnPurchaseTicket.Size = new System.Drawing.Size(129, 54);
            this.btnPurchaseTicket.TabIndex = 3;
            this.btnPurchaseTicket.Text = "Purchase Ticket";
            this.btnPurchaseTicket.UseVisualStyleBackColor = true;
            this.btnPurchaseTicket.Click += new System.EventHandler(this.btnPurchaseTicket_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 351);
            this.Controls.Add(this.btnPurchaseTicket);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.pnlSeats);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnPurchaseTicket;
    }
}

