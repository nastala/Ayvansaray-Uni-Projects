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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.btnSaveStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(12, 30);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            // 
            // mtbTime
            // 
            this.mtbTime.Location = new System.Drawing.Point(12, 56);
            this.mtbTime.Mask = "00:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(100, 20);
            this.mtbTime.TabIndex = 1;
            this.mtbTime.ValidatingType = typeof(System.DateTime);
            // 
            // btnSaveStart
            // 
            this.btnSaveStart.Location = new System.Drawing.Point(118, 56);
            this.btnSaveStart.Name = "btnSaveStart";
            this.btnSaveStart.Size = new System.Drawing.Size(94, 23);
            this.btnSaveStart.TabIndex = 2;
            this.btnSaveStart.Text = "Save and Start";
            this.btnSaveStart.UseVisualStyleBackColor = true;
            this.btnSaveStart.Click += new System.EventHandler(this.btnSaveStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 125);
            this.Controls.Add(this.btnSaveStart);
            this.Controls.Add(this.mtbTime);
            this.Controls.Add(this.dtpDate);
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
    }
}

