namespace WindowsFormsApp2
{
    partial class TargetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.lTax = new System.Windows.Forms.Label();
            this.lFinalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(119, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(13, 13);
            this.lName.TabIndex = 4;
            this.lName.Text = "0";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(119, 94);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(13, 13);
            this.lPrice.TabIndex = 5;
            this.lPrice.Text = "0";
            // 
            // lTax
            // 
            this.lTax.AutoSize = true;
            this.lTax.Location = new System.Drawing.Point(119, 127);
            this.lTax.Name = "lTax";
            this.lTax.Size = new System.Drawing.Size(13, 13);
            this.lTax.TabIndex = 6;
            this.lTax.Text = "0";
            // 
            // lFinalPrice
            // 
            this.lFinalPrice.AutoSize = true;
            this.lFinalPrice.Location = new System.Drawing.Point(119, 161);
            this.lFinalPrice.Name = "lFinalPrice";
            this.lFinalPrice.Size = new System.Drawing.Size(13, 13);
            this.lFinalPrice.TabIndex = 7;
            this.lFinalPrice.Text = "0";
            // 
            // TargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 240);
            this.Controls.Add(this.lFinalPrice);
            this.Controls.Add(this.lTax);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TargetForm";
            this.Text = "TargetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lTax;
        private System.Windows.Forms.Label lFinalPrice;
    }
}