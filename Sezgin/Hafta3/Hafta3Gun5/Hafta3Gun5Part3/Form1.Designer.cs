namespace Hafta3Gun5Part3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveStart = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(16, 37);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // mtbTime
            // 
            this.mtbTime.Location = new System.Drawing.Point(16, 69);
            this.mtbTime.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTime.Mask = "00:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(132, 22);
            this.mtbTime.TabIndex = 1;
            this.mtbTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnSaveStart
            // 
            this.btnSaveStart.Location = new System.Drawing.Point(157, 69);
            this.btnSaveStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveStart.Name = "btnSaveStart";
            this.btnSaveStart.Size = new System.Drawing.Size(125, 28);
            this.btnSaveStart.TabIndex = 2;
            this.btnSaveStart.Text = "Save and Start";
            this.btnSaveStart.UseVisualStyleBackColor = true;
            this.btnSaveStart.Click += new System.EventHandler(this.btnSaveStart_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Alarm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 154);
            this.Controls.Add(this.btnSaveStart);
            this.Controls.Add(this.mtbTime);
            this.Controls.Add(this.dtpDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.MaskedTextBox mtbTime;
        private System.Windows.Forms.Button btnSaveStart;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

