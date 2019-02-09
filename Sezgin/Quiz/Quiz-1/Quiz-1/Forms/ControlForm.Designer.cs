namespace Quiz_1.Forms
{
    partial class ControlForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.lbCosts = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDepartureDestination = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSeatNumbers = new System.Windows.Forms.ListBox();
            this.lbPlates = new System.Windows.Forms.ListBox();
            this.cbBusses = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotalIncome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbTotalIncome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbBusses);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbCosts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbNames);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbDepartureDestination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbSeatNumbers);
            this.groupBox1.Controls.Add(this.lbPlates);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Cost(₺)";
            // 
            // lbCosts
            // 
            this.lbCosts.FormattingEnabled = true;
            this.lbCosts.ItemHeight = 16;
            this.lbCosts.Location = new System.Drawing.Point(587, 38);
            this.lbCosts.Name = "lbCosts";
            this.lbCosts.Size = new System.Drawing.Size(72, 196);
            this.lbCosts.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name";
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 16;
            this.lbNames.Location = new System.Drawing.Point(433, 38);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(148, 196);
            this.lbNames.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Departure -> Destination";
            // 
            // lbDepartureDestination
            // 
            this.lbDepartureDestination.FormattingEnabled = true;
            this.lbDepartureDestination.ItemHeight = 16;
            this.lbDepartureDestination.Location = new System.Drawing.Point(260, 38);
            this.lbDepartureDestination.Name = "lbDepartureDestination";
            this.lbDepartureDestination.Size = new System.Drawing.Size(167, 196);
            this.lbDepartureDestination.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Seat Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Plate";
            // 
            // lbSeatNumbers
            // 
            this.lbSeatNumbers.FormattingEnabled = true;
            this.lbSeatNumbers.ItemHeight = 16;
            this.lbSeatNumbers.Location = new System.Drawing.Point(160, 38);
            this.lbSeatNumbers.Name = "lbSeatNumbers";
            this.lbSeatNumbers.Size = new System.Drawing.Size(94, 196);
            this.lbSeatNumbers.TabIndex = 21;
            // 
            // lbPlates
            // 
            this.lbPlates.FormattingEnabled = true;
            this.lbPlates.ItemHeight = 16;
            this.lbPlates.Location = new System.Drawing.Point(6, 38);
            this.lbPlates.Name = "lbPlates";
            this.lbPlates.Size = new System.Drawing.Size(148, 196);
            this.lbPlates.TabIndex = 20;
            // 
            // cbBusses
            // 
            this.cbBusses.FormattingEnabled = true;
            this.cbBusses.Location = new System.Drawing.Point(48, 250);
            this.cbBusses.Name = "cbBusses";
            this.cbBusses.Size = new System.Drawing.Size(121, 24);
            this.cbBusses.TabIndex = 30;
            this.cbBusses.SelectedIndexChanged += new System.EventHandler(this.cbBusses_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Bus:";
            // 
            // tbTotalIncome
            // 
            this.tbTotalIncome.Enabled = false;
            this.tbTotalIncome.Location = new System.Drawing.Point(289, 250);
            this.tbTotalIncome.Name = "tbTotalIncome";
            this.tbTotalIncome.Size = new System.Drawing.Size(100, 22);
            this.tbTotalIncome.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Total Income:";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 315);
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlForm";
            this.Text = "ControlForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbCosts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbDepartureDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSeatNumbers;
        private System.Windows.Forms.ListBox lbPlates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotalIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBusses;
    }
}