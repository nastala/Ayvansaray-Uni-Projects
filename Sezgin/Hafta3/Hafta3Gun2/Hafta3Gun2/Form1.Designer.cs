namespace Hafta3Gun2
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
            this.tbBoomNumber = new System.Windows.Forms.TextBox();
            this.lbBoomNumbers = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnForStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbBoomNumber
            // 
            this.tbBoomNumber.Location = new System.Drawing.Point(123, 8);
            this.tbBoomNumber.Name = "tbBoomNumber";
            this.tbBoomNumber.Size = new System.Drawing.Size(156, 20);
            this.tbBoomNumber.TabIndex = 0;
            // 
            // lbBoomNumbers
            // 
            this.lbBoomNumbers.FormattingEnabled = true;
            this.lbBoomNumbers.Location = new System.Drawing.Point(12, 39);
            this.lbBoomNumbers.Name = "lbBoomNumbers";
            this.lbBoomNumbers.Size = new System.Drawing.Size(267, 173);
            this.lbBoomNumbers.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 218);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(59, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "T Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Boom Number: ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnForStart
            // 
            this.btnForStart.Location = new System.Drawing.Point(77, 218);
            this.btnForStart.Name = "btnForStart";
            this.btnForStart.Size = new System.Drawing.Size(59, 25);
            this.btnForStart.TabIndex = 6;
            this.btnForStart.Text = "For Start";
            this.btnForStart.UseVisualStyleBackColor = true;
            this.btnForStart.Click += new System.EventHandler(this.btnForStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 247);
            this.Controls.Add(this.btnForStart);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbBoomNumbers);
            this.Controls.Add(this.tbBoomNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBoomNumber;
        private System.Windows.Forms.ListBox lbBoomNumbers;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnForStart;
    }
}

