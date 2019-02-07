namespace Muhasebe.Forms
{
    partial class EditorInvoice
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
            this.tBInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCustomers = new Muhasebe.Controls.EntityComboBox();
            this.cBDistricts = new Muhasebe.Controls.EntityComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBCities = new Muhasebe.Controls.EntityComboBox();
            this.bShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBInvoiceNo
            // 
            this.tBInvoiceNo.Location = new System.Drawing.Point(100, 34);
            this.tBInvoiceNo.Name = "tBInvoiceNo";
            this.tBInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.tBInvoiceNo.TabIndex = 0;
            this.tBInvoiceNo.TextChanged += new System.EventHandler(this.InvoiceNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fatura No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Müşteri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "İlçe";
            // 
            // cBCustomers
            // 
            this.cBCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCustomers.FormattingEnabled = true;
            this.cBCustomers.Location = new System.Drawing.Point(528, 74);
            this.cBCustomers.Name = "cBCustomers";
            this.cBCustomers.Size = new System.Drawing.Size(121, 21);
            this.cBCustomers.TabIndex = 2;
            this.cBCustomers.SelectedIndexChanged += new System.EventHandler(this.Customers_SelectedIndexChanged);
            // 
            // cBDistricts
            // 
            this.cBDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDistricts.FormattingEnabled = true;
            this.cBDistricts.Location = new System.Drawing.Point(528, 47);
            this.cBDistricts.Name = "cBDistricts";
            this.cBDistricts.Size = new System.Drawing.Size(121, 21);
            this.cBDistricts.TabIndex = 3;
            this.cBDistricts.SelectedIndexChanged += new System.EventHandler(this.Districts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şehir";
            // 
            // cBCities
            // 
            this.cBCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCities.FormattingEnabled = true;
            this.cBCities.Location = new System.Drawing.Point(528, 19);
            this.cBCities.Name = "cBCities";
            this.cBCities.Size = new System.Drawing.Size(121, 21);
            this.cBCities.TabIndex = 4;
            this.cBCities.SelectedIndexChanged += new System.EventHandler(this.Cities_SelectedIndexChanged);
            // 
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(673, 30);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(91, 38);
            this.bShowAll.TabIndex = 8;
            this.bShowAll.Text = "Hepsini Göster";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.ShowAll_Click);
            // 
            // EditorInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBCustomers);
            this.Controls.Add(this.cBDistricts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBCities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBInvoiceNo);
            this.Name = "EditorInvoice";
            this.Text = "EditorInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBInvoiceNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Controls.EntityComboBox cBCustomers;
        private Controls.EntityComboBox cBDistricts;
        private System.Windows.Forms.Label label4;
        private Controls.EntityComboBox cBCities;
        private System.Windows.Forms.Button bShowAll;
    }
}