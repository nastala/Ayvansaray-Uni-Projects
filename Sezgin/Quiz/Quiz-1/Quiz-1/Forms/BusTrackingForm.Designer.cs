namespace Quiz_1.Forms
{
    partial class BusTrackingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbBusses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassengerCount = new System.Windows.Forms.TextBox();
            this.tbTrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBusLeft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPlates = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDates = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCosts = new System.Windows.Forms.ListBox();
            this.btnSaveBusState = new System.Windows.Forms.Button();
            this.btnDailyArchive = new System.Windows.Forms.Button();
            this.lbDailyRecordArchive = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbDailyRecordArchive);
            this.groupBox1.Controls.Add(this.btnDailyArchive);
            this.groupBox1.Controls.Add(this.btnSaveBusState);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbCosts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDates);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbPlates);
            this.groupBox1.Controls.Add(this.btnBusLeft);
            this.groupBox1.Controls.Add(this.tbTrip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassengerCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbBusses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bus Tracking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bus";
            // 
            // cbBusses
            // 
            this.cbBusses.FormattingEnabled = true;
            this.cbBusses.Location = new System.Drawing.Point(11, 66);
            this.cbBusses.Name = "cbBusses";
            this.cbBusses.Size = new System.Drawing.Size(153, 24);
            this.cbBusses.TabIndex = 1;
            this.cbBusses.SelectedIndexChanged += new System.EventHandler(this.cbBusses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Passenger Count";
            // 
            // tbPassengerCount
            // 
            this.tbPassengerCount.Enabled = false;
            this.tbPassengerCount.Location = new System.Drawing.Point(7, 150);
            this.tbPassengerCount.Name = "tbPassengerCount";
            this.tbPassengerCount.Size = new System.Drawing.Size(157, 22);
            this.tbPassengerCount.TabIndex = 3;
            // 
            // tbTrip
            // 
            this.tbTrip.Enabled = false;
            this.tbTrip.Location = new System.Drawing.Point(219, 65);
            this.tbTrip.Name = "tbTrip";
            this.tbTrip.Size = new System.Drawing.Size(150, 22);
            this.tbTrip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trip";
            // 
            // btnBusLeft
            // 
            this.btnBusLeft.Location = new System.Drawing.Point(256, 130);
            this.btnBusLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusLeft.Name = "btnBusLeft";
            this.btnBusLeft.Size = new System.Drawing.Size(113, 50);
            this.btnBusLeft.TabIndex = 6;
            this.btnBusLeft.Text = "Bus Is Left";
            this.btnBusLeft.UseVisualStyleBackColor = true;
            this.btnBusLeft.Click += new System.EventHandler(this.btnBusLeft_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Plate";
            // 
            // lbPlates
            // 
            this.lbPlates.FormattingEnabled = true;
            this.lbPlates.ItemHeight = 16;
            this.lbPlates.Location = new System.Drawing.Point(389, 48);
            this.lbPlates.Name = "lbPlates";
            this.lbPlates.Size = new System.Drawing.Size(148, 132);
            this.lbPlates.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Date";
            // 
            // lbDates
            // 
            this.lbDates.FormattingEnabled = true;
            this.lbDates.ItemHeight = 16;
            this.lbDates.Location = new System.Drawing.Point(543, 48);
            this.lbDates.Name = "lbDates";
            this.lbDates.Size = new System.Drawing.Size(171, 132);
            this.lbDates.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cost (₺)";
            // 
            // lbCosts
            // 
            this.lbCosts.FormattingEnabled = true;
            this.lbCosts.ItemHeight = 16;
            this.lbCosts.Location = new System.Drawing.Point(720, 48);
            this.lbCosts.Name = "lbCosts";
            this.lbCosts.Size = new System.Drawing.Size(83, 132);
            this.lbCosts.TabIndex = 27;
            // 
            // btnSaveBusState
            // 
            this.btnSaveBusState.Location = new System.Drawing.Point(842, 48);
            this.btnSaveBusState.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBusState.Name = "btnSaveBusState";
            this.btnSaveBusState.Size = new System.Drawing.Size(113, 50);
            this.btnSaveBusState.TabIndex = 29;
            this.btnSaveBusState.Text = "Save Bus State";
            this.btnSaveBusState.UseVisualStyleBackColor = true;
            this.btnSaveBusState.Click += new System.EventHandler(this.btnSaveBusState_Click);
            // 
            // btnDailyArchive
            // 
            this.btnDailyArchive.Location = new System.Drawing.Point(842, 130);
            this.btnDailyArchive.Margin = new System.Windows.Forms.Padding(4);
            this.btnDailyArchive.Name = "btnDailyArchive";
            this.btnDailyArchive.Size = new System.Drawing.Size(113, 50);
            this.btnDailyArchive.TabIndex = 30;
            this.btnDailyArchive.Text = "Daily Archive";
            this.btnDailyArchive.UseVisualStyleBackColor = true;
            this.btnDailyArchive.Click += new System.EventHandler(this.btnDailyArchive_Click);
            // 
            // lbDailyRecordArchive
            // 
            this.lbDailyRecordArchive.FormattingEnabled = true;
            this.lbDailyRecordArchive.ItemHeight = 16;
            this.lbDailyRecordArchive.Location = new System.Drawing.Point(962, 48);
            this.lbDailyRecordArchive.Name = "lbDailyRecordArchive";
            this.lbDailyRecordArchive.Size = new System.Drawing.Size(171, 132);
            this.lbDailyRecordArchive.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(959, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Daily Record Archive";
            // 
            // BusTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "BusTrackingForm";
            this.Text = "BusTrackingForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassengerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBusses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBusLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbCosts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbDates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbPlates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDailyRecordArchive;
        private System.Windows.Forms.Button btnDailyArchive;
        private System.Windows.Forms.Button btnSaveBusState;
    }
}