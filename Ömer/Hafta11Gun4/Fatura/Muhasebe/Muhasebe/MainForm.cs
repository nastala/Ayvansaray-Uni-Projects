using Muhasebe.Entities;
using Muhasebe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe
{
    public partial class MainForm : Form
    {
        private ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private ToolStripMenuItem tSMIEditorCustomer;
        private ToolStripMenuItem tSMIEditorUnit;
        private ToolStripMenuItem tSMIEditorProduct;
        private ToolStripMenuItem tSMIEditorCity;
        private ToolStripMenuItem tSMIEditorDistrict;
        private ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem tSMIEditInvoice;
        private ToolStripMenuItem tSMICreateInvoice;
        private MenuStrip mSMain;

        public MainForm()
        {
            InitializeComponent();
        }

        private static void AddDummyData(AccountingModel model)
        {
            var cities = new City[]
            {
                new City{Name="City1"},
                new City{Name="City2"},
                new City{Name="City3"},
                new City{Name="City4"}
            };
            model.Cities.AddRange(cities);

            var districts = new District[]
            {
                new District{Name = "District1", City = cities[0]},
                new District{Name = "District2", City = cities[0]},
                new District{Name = "District3", City = cities[1]},
                new District{Name = "District4", City = cities[1]},
                new District{Name = "District5", City = cities[1]},
                new District{Name = "District6", City = cities[2]},
            };

            model.Districts.AddRange(districts);

            model.SaveChanges();
        }
        private void InitializeComponent()
        {
            this.mSMain = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditorCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditorUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditorProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditorCity = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditorDistrict = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIEditInvoice = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mSMain.Size = new System.Drawing.Size(642, 24);
            this.mSMain.TabIndex = 0;
            this.mSMain.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIEditorCustomer,
            this.tSMIEditorUnit,
            this.tSMIEditorProduct,
            this.tSMIEditorCity,
            this.tSMIEditorDistrict});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // tSMIEditorCustomer
            // 
            this.tSMIEditorCustomer.Name = "tSMIEditorCustomer";
            this.tSMIEditorCustomer.Size = new System.Drawing.Size(138, 22);
            this.tSMIEditorCustomer.Text = "Müşteri Ekle";
            this.tSMIEditorCustomer.Click += new System.EventHandler(this.EditorCustomer_Click);
            // 
            // tSMIEditorUnit
            // 
            this.tSMIEditorUnit.Name = "tSMIEditorUnit";
            this.tSMIEditorUnit.Size = new System.Drawing.Size(138, 22);
            this.tSMIEditorUnit.Text = "Birim Ekle";
            this.tSMIEditorUnit.Click += new System.EventHandler(this.EditorUnit_Click);
            // 
            // tSMIEditorProduct
            // 
            this.tSMIEditorProduct.Name = "tSMIEditorProduct";
            this.tSMIEditorProduct.Size = new System.Drawing.Size(138, 22);
            this.tSMIEditorProduct.Text = "Ürün Ekle";
            this.tSMIEditorProduct.Click += new System.EventHandler(this.EditorProduct_Click);
            // 
            // tSMIEditorCity
            // 
            this.tSMIEditorCity.Name = "tSMIEditorCity";
            this.tSMIEditorCity.Size = new System.Drawing.Size(138, 22);
            this.tSMIEditorCity.Text = "İl Ekle";
            this.tSMIEditorCity.Click += new System.EventHandler(this.EditorCity_Click);
            // 
            // tSMIEditorDistrict
            // 
            this.tSMIEditorDistrict.Name = "tSMIEditorDistrict";
            this.tSMIEditorDistrict.Size = new System.Drawing.Size(138, 22);
            this.tSMIEditorDistrict.Text = "İlçe Ekle";
            this.tSMIEditorDistrict.Click += new System.EventHandler(this.EditorDistrict_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIEditInvoice,
            this.tSMICreateInvoice});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // tSMIEditInvoice
            // 
            this.tSMIEditInvoice.Name = "tSMIEditInvoice";
            this.tSMIEditInvoice.Size = new System.Drawing.Size(231, 22);
            this.tSMIEditInvoice.Text = "Görüntüle / Sorgula / Düzenle";
            this.tSMIEditInvoice.Click += new System.EventHandler(this.EditInvoice_Click);
            // 
            // tSMICreateInvoice
            // 
            this.tSMICreateInvoice.Name = "tSMICreateInvoice";
            this.tSMICreateInvoice.Size = new System.Drawing.Size(231, 22);
            this.tSMICreateInvoice.Text = "Yeni Fatura Oluştur";
            this.tSMICreateInvoice.Click += new System.EventHandler(this.CreateInvoice_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(642, 367);
            this.Controls.Add(this.mSMain);
            this.MainMenuStrip = this.mSMain;
            this.Name = "MainForm";
            this.Text = "Ana Sayfa";
            this.mSMain.ResumeLayout(false);
            this.mSMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShowFormDialog<T>() where T : Form, new()
        {
            using (var frm = new T())
            {
                frm.ShowDialog();
            }
        }
        private void EditorCity_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorCity>();
        }

        private void EditorDistrict_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorDistrict>();
        }

        private void EditorUnit_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorUnit>();
        }

        private void EditorProduct_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorProduct>();
        }

        private void EditorCustomer_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorCustomer>();
        }

        private void CreateInvoice_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorInvoiceDetails>();
        }

        private void EditInvoice_Click(object sender, EventArgs e)
        {
            ShowFormDialog<EditorInvoice>();
        }
    }
}
