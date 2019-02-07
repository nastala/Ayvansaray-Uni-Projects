namespace Quiz_1.Forms
{
    partial class PurchaseTicketForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbBus = new System.Windows.Forms.PictureBox();
            this.pnlSeats = new System.Windows.Forms.Panel();
            this.cbDestinationCities = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDepartureCities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBusses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbBus);
            this.groupBox1.Controls.Add(this.pnlSeats);
            this.groupBox1.Controls.Add(this.cbDestinationCities);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbDepartureCities);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBusses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(775, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase a Ticket";
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(43, 87);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(32, 17);
            this.lblBus.TabIndex = 9;
            this.lblBus.Text = "Bus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bus: ";
            // 
            // pbBus
            // 
            this.pbBus.Location = new System.Drawing.Point(11, 107);
            this.pbBus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbBus.Name = "pbBus";
            this.pbBus.Size = new System.Drawing.Size(157, 219);
            this.pbBus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBus.TabIndex = 7;
            this.pbBus.TabStop = false;
            // 
            // pnlSeats
            // 
            this.pnlSeats.AutoScroll = true;
            this.pnlSeats.Location = new System.Drawing.Point(184, 74);
            this.pnlSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSeats.Name = "pnlSeats";
            this.pnlSeats.Size = new System.Drawing.Size(585, 252);
            this.pnlSeats.TabIndex = 6;
            // 
            // cbDestinationCities
            // 
            this.cbDestinationCities.FormattingEnabled = true;
            this.cbDestinationCities.Location = new System.Drawing.Point(357, 43);
            this.cbDestinationCities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDestinationCities.Name = "cbDestinationCities";
            this.cbDestinationCities.Size = new System.Drawing.Size(149, 24);
            this.cbDestinationCities.TabIndex = 5;
            this.cbDestinationCities.SelectedIndexChanged += new System.EventHandler(this.cbDestinationCities_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destination City";
            // 
            // cbDepartureCities
            // 
            this.cbDepartureCities.FormattingEnabled = true;
            this.cbDepartureCities.Location = new System.Drawing.Point(184, 43);
            this.cbDepartureCities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDepartureCities.Name = "cbDepartureCities";
            this.cbDepartureCities.Size = new System.Drawing.Size(149, 24);
            this.cbDepartureCities.TabIndex = 3;
            this.cbDepartureCities.SelectedIndexChanged += new System.EventHandler(this.cbDepartureCities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departure City";
            // 
            // cbBusses
            // 
            this.cbBusses.FormattingEnabled = true;
            this.cbBusses.Location = new System.Drawing.Point(11, 43);
            this.cbBusses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBusses.Name = "cbBusses";
            this.cbBusses.Size = new System.Drawing.Size(149, 24);
            this.cbBusses.TabIndex = 1;
            this.cbBusses.SelectedIndexChanged += new System.EventHandler(this.cbBusses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus:";
            // 
            // PurchaseTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 359);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PurchaseTicketForm";
            this.Text = "PurchaseTicketForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbBus;
        private System.Windows.Forms.Panel pnlSeats;
        private System.Windows.Forms.ComboBox cbDestinationCities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDepartureCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBusses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Label label4;
    }
}