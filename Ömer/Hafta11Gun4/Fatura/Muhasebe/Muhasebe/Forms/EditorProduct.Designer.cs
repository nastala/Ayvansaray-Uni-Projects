namespace Muhasebe.Forms
{
    partial class EditorProduct
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
            this.tBProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBUnits = new Muhasebe.Controls.EntityComboBox();
            this.tBProductCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBProductName
            // 
            this.tBProductName.Location = new System.Drawing.Point(66, 6);
            this.tBProductName.Name = "tBProductName";
            this.tBProductName.Size = new System.Drawing.Size(100, 20);
            this.tBProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Birim Türü";
            // 
            // cBUnits
            // 
            this.cBUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBUnits.FormattingEnabled = true;
            this.cBUnits.Location = new System.Drawing.Point(248, 6);
            this.cBUnits.Name = "cBUnits";
            this.cBUnits.Size = new System.Drawing.Size(121, 21);
            this.cBUnits.TabIndex = 2;
            this.cBUnits.SelectedIndexChanged += new System.EventHandler(this.Units_SelectedIndexChanged);
            // 
            // tBProductCode
            // 
            this.tBProductCode.Location = new System.Drawing.Point(66, 32);
            this.tBProductCode.Name = "tBProductCode";
            this.tBProductCode.Size = new System.Drawing.Size(100, 20);
            this.tBProductCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Kodu";
            // 
            // tBUnitPrice
            // 
            this.tBUnitPrice.Location = new System.Drawing.Point(248, 36);
            this.tBUnitPrice.Name = "tBUnitPrice";
            this.tBUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tBUnitPrice.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birim Fiyat";
            // 
            // EditorProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 390);
            this.Controls.Add(this.cBUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBProductCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBProductName);
            this.Name = "EditorProduct";
            this.Text = "EditorProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.EntityComboBox cBUnits;
        private System.Windows.Forms.TextBox tBProductCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBUnitPrice;
        private System.Windows.Forms.Label label4;
    }
}