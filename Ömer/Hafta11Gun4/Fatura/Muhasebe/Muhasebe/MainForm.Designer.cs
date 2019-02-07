namespace Muhasebe
{
    partial class MainForm
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
            this.mSMain = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMIAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddCity = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIAddDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIInvoiceEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMICreateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mSMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSMain
            // 
            this.mSMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem});
            this.mSMain.Location = new System.Drawing.Point(0, 0);
            this.mSMain.Name = "mSMain";
            this.mSMain.Size = new System.Drawing.Size(800, 24);
            this.mSMain.TabIndex = 0;
            this.mSMain.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMIAddCustomer,
            this.tSMIAddUnit,
            this.tSMIAddProduct,
            this.tSMIAddCity,
            this.tSMIAddDistrict});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // tsMIAddCustomer
            // 
            this.tsMIAddCustomer.Name = "tsMIAddCustomer";
            this.tsMIAddCustomer.Size = new System.Drawing.Size(180, 22);
            this.tsMIAddCustomer.Text = "Müşteri Ekle";
            // 
            // tSMIAddUnit
            // 
            this.tSMIAddUnit.Name = "tSMIAddUnit";
            this.tSMIAddUnit.Size = new System.Drawing.Size(180, 22);
            this.tSMIAddUnit.Text = "Birim Ekle";
            // 
            // tSMIAddProduct
            // 
            this.tSMIAddProduct.Name = "tSMIAddProduct";
            this.tSMIAddProduct.Size = new System.Drawing.Size(180, 22);
            this.tSMIAddProduct.Text = "Ürün Ekle";
            // 
            // tSMIAddCity
            // 
            this.tSMIAddCity.Name = "tSMIAddCity";
            this.tSMIAddCity.Size = new System.Drawing.Size(180, 22);
            this.tSMIAddCity.Text = "İl Ekle";
            this.tSMIAddCity.Click += new System.EventHandler(this.AddCity_Click);
            // 
            // tSMIAddDistrict
            // 
            this.tSMIAddDistrict.Name = "tSMIAddDistrict";
            this.tSMIAddDistrict.Size = new System.Drawing.Size(180, 22);
            this.tSMIAddDistrict.Text = "İlçe Ekle";
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIInvoiceEditor,
            this.tSMICreateInvoice});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // tSMIInvoiceEditor
            // 
            this.tSMIInvoiceEditor.Name = "tSMIInvoiceEditor";
            this.tSMIInvoiceEditor.Size = new System.Drawing.Size(231, 22);
            this.tSMIInvoiceEditor.Text = "Görüntüle / Sorgula / Düzenle";
            // 
            // tSMICreateInvoice
            // 
            this.tSMICreateInvoice.Name = "tSMICreateInvoice";
            this.tSMICreateInvoice.Size = new System.Drawing.Size(231, 22);
            this.tSMICreateInvoice.Text = "Yeni Fatura Oluştur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mSMain);
            this.MainMenuStrip = this.mSMain;
            this.Name = "Form1";
            this.Text = "Form1";
            this.mSMain.ResumeLayout(false);
            this.mSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mSMain;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMIAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddUnit;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddProduct;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddCity;
        private System.Windows.Forms.ToolStripMenuItem tSMIAddDistrict;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMIInvoiceEditor;
        private System.Windows.Forms.ToolStripMenuItem tSMICreateInvoice;
    }
}

