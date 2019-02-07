namespace Muhasebe.Forms
{
    partial class EditorInvoiceDetails
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
            this.tBWaybill = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dTPPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBProductPrice = new System.Windows.Forms.TextBox();
            this.tBProductUnit = new System.Windows.Forms.TextBox();
            this.tBProductTax = new System.Windows.Forms.TextBox();
            this.nUDProductCount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lPriceSum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bSaveInvoice = new System.Windows.Forms.Button();
            this.cBProducts = new Muhasebe.Controls.EntityComboBox();
            this.cBCustomers = new Muhasebe.Controls.EntityComboBox();
            this.cBDistricts = new Muhasebe.Controls.EntityComboBox();
            this.cBCities = new Muhasebe.Controls.EntityComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlçe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Müşteri";
            // 
            // tBWaybill
            // 
            this.tBWaybill.Location = new System.Drawing.Point(87, 103);
            this.tBWaybill.Name = "tBWaybill";
            this.tBWaybill.Size = new System.Drawing.Size(121, 20);
            this.tBWaybill.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ödeme Tarihi";
            // 
            // dTPPaymentDate
            // 
            this.dTPPaymentDate.Location = new System.Drawing.Point(87, 129);
            this.dTPPaymentDate.Name = "dTPPaymentDate";
            this.dTPPaymentDate.Size = new System.Drawing.Size(121, 20);
            this.dTPPaymentDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "İrsaliye No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Adı";
            // 
            // tBProductPrice
            // 
            this.tBProductPrice.Enabled = false;
            this.tBProductPrice.Location = new System.Drawing.Point(498, 48);
            this.tBProductPrice.Name = "tBProductPrice";
            this.tBProductPrice.Size = new System.Drawing.Size(121, 20);
            this.tBProductPrice.TabIndex = 2;
            // 
            // tBProductUnit
            // 
            this.tBProductUnit.Enabled = false;
            this.tBProductUnit.Location = new System.Drawing.Point(498, 74);
            this.tBProductUnit.Name = "tBProductUnit";
            this.tBProductUnit.Size = new System.Drawing.Size(121, 20);
            this.tBProductUnit.TabIndex = 2;
            // 
            // tBProductTax
            // 
            this.tBProductTax.Enabled = false;
            this.tBProductTax.Location = new System.Drawing.Point(498, 99);
            this.tBProductTax.Name = "tBProductTax";
            this.tBProductTax.Size = new System.Drawing.Size(121, 20);
            this.tBProductTax.TabIndex = 2;
            // 
            // nUDProductCount
            // 
            this.nUDProductCount.Location = new System.Drawing.Point(498, 125);
            this.nUDProductCount.Name = "nUDProductCount";
            this.nUDProductCount.Size = new System.Drawing.Size(120, 20);
            this.nUDProductCount.TabIndex = 4;
            this.nUDProductCount.ValueChanged += new System.EventHandler(this.ProductCount_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(435, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ürün Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ürün Birimi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ürün KDV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ürün Adeti";
            // 
            // lPriceSum
            // 
            this.lPriceSum.AutoSize = true;
            this.lPriceSum.Location = new System.Drawing.Point(317, 21);
            this.lPriceSum.Name = "lPriceSum";
            this.lPriceSum.Size = new System.Drawing.Size(19, 13);
            this.lPriceSum.TabIndex = 5;
            this.lPriceSum.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Toplam Fiyat";
            // 
            // bSaveInvoice
            // 
            this.bSaveInvoice.Location = new System.Drawing.Point(688, 12);
            this.bSaveInvoice.Name = "bSaveInvoice";
            this.bSaveInvoice.Size = new System.Drawing.Size(100, 36);
            this.bSaveInvoice.TabIndex = 6;
            this.bSaveInvoice.Text = "Faturayı Kaydet";
            this.bSaveInvoice.UseVisualStyleBackColor = true;
            this.bSaveInvoice.Click += new System.EventHandler(this.SaveInvoice_Click);
            // 
            // cBProducts
            // 
            this.cBProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBProducts.FormattingEnabled = true;
            this.cBProducts.Location = new System.Drawing.Point(498, 21);
            this.cBProducts.Name = "cBProducts";
            this.cBProducts.Size = new System.Drawing.Size(121, 21);
            this.cBProducts.TabIndex = 0;
            this.cBProducts.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // cBCustomers
            // 
            this.cBCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCustomers.FormattingEnabled = true;
            this.cBCustomers.Location = new System.Drawing.Point(87, 76);
            this.cBCustomers.Name = "cBCustomers";
            this.cBCustomers.Size = new System.Drawing.Size(121, 21);
            this.cBCustomers.TabIndex = 0;
            // 
            // cBDistricts
            // 
            this.cBDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDistricts.FormattingEnabled = true;
            this.cBDistricts.Location = new System.Drawing.Point(87, 49);
            this.cBDistricts.Name = "cBDistricts";
            this.cBDistricts.Size = new System.Drawing.Size(121, 21);
            this.cBDistricts.TabIndex = 0;
            this.cBDistricts.SelectedIndexChanged += new System.EventHandler(this.Districts_SelectedIndexChanged);
            // 
            // cBCities
            // 
            this.cBCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCities.FormattingEnabled = true;
            this.cBCities.Location = new System.Drawing.Point(87, 21);
            this.cBCities.Name = "cBCities";
            this.cBCities.Size = new System.Drawing.Size(121, 21);
            this.cBCities.TabIndex = 0;
            this.cBCities.SelectedIndexChanged += new System.EventHandler(this.Cities_SelectedIndexChanged);
            // 
            // EditorInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSaveInvoice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lPriceSum);
            this.Controls.Add(this.nUDProductCount);
            this.Controls.Add(this.dTPPaymentDate);
            this.Controls.Add(this.tBProductTax);
            this.Controls.Add(this.tBProductUnit);
            this.Controls.Add(this.tBProductPrice);
            this.Controls.Add(this.tBWaybill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBProducts);
            this.Controls.Add(this.cBCustomers);
            this.Controls.Add(this.cBDistricts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBCities);
            this.Name = "EditorInvoice";
            this.Text = "EditorInvoice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorInvoice_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nUDProductCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.EntityComboBox cBCities;
        private System.Windows.Forms.Label label1;
        private Controls.EntityComboBox cBDistricts;
        private System.Windows.Forms.Label label2;
        private Controls.EntityComboBox cBCustomers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBWaybill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPPaymentDate;
        private System.Windows.Forms.Label label5;
        private Controls.EntityComboBox cBProducts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBProductPrice;
        private System.Windows.Forms.TextBox tBProductUnit;
        private System.Windows.Forms.TextBox tBProductTax;
        private System.Windows.Forms.NumericUpDown nUDProductCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lPriceSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bSaveInvoice;
    }
}