namespace NorthWind.UI
{
    partial class FormProducts
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
            this.dGVMain = new System.Windows.Forms.DataGridView();
            this.tProductName = new System.Windows.Forms.TextBox();
            this.nUDProductPrice = new System.Windows.Forms.NumericUpDown();
            this.nUDProductStock = new System.Windows.Forms.NumericUpDown();
            this.cProductCategory = new System.Windows.Forms.ComboBox();
            this.cProductSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMain
            // 
            this.dGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVMain.Location = new System.Drawing.Point(0, 69);
            this.dGVMain.Name = "dGVMain";
            this.dGVMain.Size = new System.Drawing.Size(800, 381);
            this.dGVMain.TabIndex = 0;
            // 
            // tProductName
            // 
            this.tProductName.Location = new System.Drawing.Point(12, 27);
            this.tProductName.Name = "tProductName";
            this.tProductName.Size = new System.Drawing.Size(100, 20);
            this.tProductName.TabIndex = 1;
            // 
            // nUDProductPrice
            // 
            this.nUDProductPrice.Location = new System.Drawing.Point(139, 27);
            this.nUDProductPrice.Name = "nUDProductPrice";
            this.nUDProductPrice.Size = new System.Drawing.Size(120, 20);
            this.nUDProductPrice.TabIndex = 2;
            // 
            // nUDProductStock
            // 
            this.nUDProductStock.Location = new System.Drawing.Point(286, 27);
            this.nUDProductStock.Name = "nUDProductStock";
            this.nUDProductStock.Size = new System.Drawing.Size(120, 20);
            this.nUDProductStock.TabIndex = 2;
            // 
            // cProductCategory
            // 
            this.cProductCategory.FormattingEnabled = true;
            this.cProductCategory.Location = new System.Drawing.Point(433, 27);
            this.cProductCategory.Name = "cProductCategory";
            this.cProductCategory.Size = new System.Drawing.Size(121, 21);
            this.cProductCategory.TabIndex = 3;
            // 
            // cProductSupplier
            // 
            this.cProductSupplier.FormattingEnabled = true;
            this.cProductSupplier.Location = new System.Drawing.Point(581, 27);
            this.cProductSupplier.Name = "cProductSupplier";
            this.cProductSupplier.Size = new System.Drawing.Size(121, 21);
            this.cProductSupplier.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(578, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(713, 24);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 5;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cProductSupplier);
            this.Controls.Add(this.cProductCategory);
            this.Controls.Add(this.nUDProductStock);
            this.Controls.Add(this.nUDProductPrice);
            this.Controls.Add(this.tProductName);
            this.Controls.Add(this.dGVMain);
            this.Name = "FormProducts";
            this.Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMain;
        private System.Windows.Forms.TextBox tProductName;
        private System.Windows.Forms.NumericUpDown nUDProductPrice;
        private System.Windows.Forms.NumericUpDown nUDProductStock;
        private System.Windows.Forms.ComboBox cProductCategory;
        private System.Windows.Forms.ComboBox cProductSupplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAdd;
    }
}