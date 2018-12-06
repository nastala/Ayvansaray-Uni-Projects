namespace WindowsFormsApp2
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
            this.tBPrice = new System.Windows.Forms.TextBox();
            this.tBTax = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBPrice
            // 
            this.tBPrice.Location = new System.Drawing.Point(103, 100);
            this.tBPrice.Name = "tBPrice";
            this.tBPrice.Size = new System.Drawing.Size(100, 20);
            this.tBPrice.TabIndex = 0;
            this.tBPrice.Text = "100";
            // 
            // tBTax
            // 
            this.tBTax.Location = new System.Drawing.Point(103, 126);
            this.tBTax.Name = "tBTax";
            this.tBTax.Size = new System.Drawing.Size(100, 20);
            this.tBTax.TabIndex = 1;
            this.tBTax.Text = "18";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(115, 152);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tax";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(103, 74);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 5;
            this.tBName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tBTax);
            this.Controls.Add(this.tBPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBPrice;
        private System.Windows.Forms.TextBox tBTax;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label3;
    }
}

