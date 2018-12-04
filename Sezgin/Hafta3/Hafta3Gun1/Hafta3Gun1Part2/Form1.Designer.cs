namespace Hafta3Gun1Part2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbLower = new System.Windows.Forms.TextBox();
            this.tbUpper = new System.Windows.Forms.TextBox();
            this.tbDigit = new System.Windows.Forms.TextBox();
            this.tbChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbLower);
            this.panel1.Controls.Add(this.tbUpper);
            this.panel1.Controls.Add(this.tbDigit);
            this.panel1.Controls.Add(this.tbChar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 160);
            this.panel1.TabIndex = 0;
            // 
            // tbLower
            // 
            this.tbLower.Location = new System.Drawing.Point(106, 109);
            this.tbLower.Name = "tbLower";
            this.tbLower.Size = new System.Drawing.Size(170, 20);
            this.tbLower.TabIndex = 3;
            this.tbLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLower_KeyPress);
            // 
            // tbUpper
            // 
            this.tbUpper.Location = new System.Drawing.Point(106, 83);
            this.tbUpper.Name = "tbUpper";
            this.tbUpper.Size = new System.Drawing.Size(170, 20);
            this.tbUpper.TabIndex = 2;
            this.tbUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUpper_KeyPress);
            // 
            // tbDigit
            // 
            this.tbDigit.Location = new System.Drawing.Point(106, 57);
            this.tbDigit.Name = "tbDigit";
            this.tbDigit.Size = new System.Drawing.Size(170, 20);
            this.tbDigit.TabIndex = 1;
            this.tbDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDigit_KeyPress);
            // 
            // tbChar
            // 
            this.tbChar.Location = new System.Drawing.Point(106, 31);
            this.tbChar.Name = "tbChar";
            this.tbChar.Size = new System.Drawing.Size(170, 20);
            this.tbChar.TabIndex = 0;
            this.tbChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Allows Only Chars: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Allows Only Digits: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To Upper: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "To Lower: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 186);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbLower;
        private System.Windows.Forms.TextBox tbUpper;
        private System.Windows.Forms.TextBox tbDigit;
        private System.Windows.Forms.TextBox tbChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

