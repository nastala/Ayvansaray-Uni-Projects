namespace XML_Veri_Islemleri
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
            this.dgvVeriler = new System.Windows.Forms.DataGridView();
            this.btnVeriOku = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnSqlToXml = new System.Windows.Forms.Button();
            this.btnVeriBul = new System.Windows.Forms.Button();
            this.btnSchemaOlustur = new System.Windows.Forms.Button();
            this.btnXPathIleVerileriBul = new System.Windows.Forms.Button();
            this.btnXmlToSql = new System.Windows.Forms.Button();
            this.btnXPathIleTagBul = new System.Windows.Forms.Button();
            this.btnXmlSchemaDogrula = new System.Windows.Forms.Button();
            this.btnXmlVeriSil = new System.Windows.Forms.Button();
            this.btnSqlToSchema = new System.Windows.Forms.Button();
            this.btnVeriDegistir = new System.Windows.Forms.Button();
            this.wbVeriler = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVeriler
            // 
            this.dgvVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeriler.Location = new System.Drawing.Point(13, 13);
            this.dgvVeriler.Name = "dgvVeriler";
            this.dgvVeriler.Size = new System.Drawing.Size(454, 150);
            this.dgvVeriler.TabIndex = 0;
            // 
            // btnVeriOku
            // 
            this.btnVeriOku.Location = new System.Drawing.Point(45, 174);
            this.btnVeriOku.Name = "btnVeriOku";
            this.btnVeriOku.Size = new System.Drawing.Size(176, 40);
            this.btnVeriOku.TabIndex = 1;
            this.btnVeriOku.Text = "Veri Oku";
            this.btnVeriOku.UseVisualStyleBackColor = true;
            this.btnVeriOku.Click += new System.EventHandler(this.btnVeriOku_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(253, 174);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(176, 40);
            this.btnAddChild.TabIndex = 2;
            this.btnAddChild.Text = "Child Ekle";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnSqlToXml
            // 
            this.btnSqlToXml.Location = new System.Drawing.Point(253, 220);
            this.btnSqlToXml.Name = "btnSqlToXml";
            this.btnSqlToXml.Size = new System.Drawing.Size(176, 40);
            this.btnSqlToXml.TabIndex = 4;
            this.btnSqlToXml.Text = "SQL to XML";
            this.btnSqlToXml.UseVisualStyleBackColor = true;
            this.btnSqlToXml.Click += new System.EventHandler(this.btnSqlToXml_Click);
            // 
            // btnVeriBul
            // 
            this.btnVeriBul.Location = new System.Drawing.Point(45, 220);
            this.btnVeriBul.Name = "btnVeriBul";
            this.btnVeriBul.Size = new System.Drawing.Size(176, 40);
            this.btnVeriBul.TabIndex = 3;
            this.btnVeriBul.Text = "Veri Bul";
            this.btnVeriBul.UseVisualStyleBackColor = true;
            this.btnVeriBul.Click += new System.EventHandler(this.btnVeriBul_Click);
            // 
            // btnSchemaOlustur
            // 
            this.btnSchemaOlustur.Location = new System.Drawing.Point(253, 312);
            this.btnSchemaOlustur.Name = "btnSchemaOlustur";
            this.btnSchemaOlustur.Size = new System.Drawing.Size(176, 40);
            this.btnSchemaOlustur.TabIndex = 8;
            this.btnSchemaOlustur.Text = "Schema Oluştur";
            this.btnSchemaOlustur.UseVisualStyleBackColor = true;
            // 
            // btnXPathIleVerileriBul
            // 
            this.btnXPathIleVerileriBul.Location = new System.Drawing.Point(45, 312);
            this.btnXPathIleVerileriBul.Name = "btnXPathIleVerileriBul";
            this.btnXPathIleVerileriBul.Size = new System.Drawing.Size(176, 40);
            this.btnXPathIleVerileriBul.TabIndex = 7;
            this.btnXPathIleVerileriBul.Text = "X Path İle Verileri Bul";
            this.btnXPathIleVerileriBul.UseVisualStyleBackColor = true;
            this.btnXPathIleVerileriBul.Click += new System.EventHandler(this.btnXPathIleVerileriBul_Click);
            // 
            // btnXmlToSql
            // 
            this.btnXmlToSql.Location = new System.Drawing.Point(253, 266);
            this.btnXmlToSql.Name = "btnXmlToSql";
            this.btnXmlToSql.Size = new System.Drawing.Size(176, 40);
            this.btnXmlToSql.TabIndex = 6;
            this.btnXmlToSql.Text = "XML to SQL";
            this.btnXmlToSql.UseVisualStyleBackColor = true;
            this.btnXmlToSql.Click += new System.EventHandler(this.btnXmlToSql_Click);
            // 
            // btnXPathIleTagBul
            // 
            this.btnXPathIleTagBul.Location = new System.Drawing.Point(45, 266);
            this.btnXPathIleTagBul.Name = "btnXPathIleTagBul";
            this.btnXPathIleTagBul.Size = new System.Drawing.Size(176, 40);
            this.btnXPathIleTagBul.TabIndex = 5;
            this.btnXPathIleTagBul.Text = "X Path İle Tag Bul";
            this.btnXPathIleTagBul.UseVisualStyleBackColor = true;
            this.btnXPathIleTagBul.Click += new System.EventHandler(this.btnXPathIleTagBul_Click);
            // 
            // btnXmlSchemaDogrula
            // 
            this.btnXmlSchemaDogrula.Location = new System.Drawing.Point(253, 404);
            this.btnXmlSchemaDogrula.Name = "btnXmlSchemaDogrula";
            this.btnXmlSchemaDogrula.Size = new System.Drawing.Size(176, 40);
            this.btnXmlSchemaDogrula.TabIndex = 12;
            this.btnXmlSchemaDogrula.Text = "XML Schema Doğrula";
            this.btnXmlSchemaDogrula.UseVisualStyleBackColor = true;
            // 
            // btnXmlVeriSil
            // 
            this.btnXmlVeriSil.Location = new System.Drawing.Point(45, 404);
            this.btnXmlVeriSil.Name = "btnXmlVeriSil";
            this.btnXmlVeriSil.Size = new System.Drawing.Size(176, 40);
            this.btnXmlVeriSil.TabIndex = 11;
            this.btnXmlVeriSil.Text = "XML Veri Sil";
            this.btnXmlVeriSil.UseVisualStyleBackColor = true;
            this.btnXmlVeriSil.Click += new System.EventHandler(this.btnXmlVeriSil_Click);
            // 
            // btnSqlToSchema
            // 
            this.btnSqlToSchema.Location = new System.Drawing.Point(253, 358);
            this.btnSqlToSchema.Name = "btnSqlToSchema";
            this.btnSqlToSchema.Size = new System.Drawing.Size(176, 40);
            this.btnSqlToSchema.TabIndex = 10;
            this.btnSqlToSchema.Text = "SQL to Schema";
            this.btnSqlToSchema.UseVisualStyleBackColor = true;
            // 
            // btnVeriDegistir
            // 
            this.btnVeriDegistir.Location = new System.Drawing.Point(45, 358);
            this.btnVeriDegistir.Name = "btnVeriDegistir";
            this.btnVeriDegistir.Size = new System.Drawing.Size(176, 40);
            this.btnVeriDegistir.TabIndex = 9;
            this.btnVeriDegistir.Text = "Veri Değiştir";
            this.btnVeriDegistir.UseVisualStyleBackColor = true;
            this.btnVeriDegistir.Click += new System.EventHandler(this.btnVeriDegistir_Click);
            // 
            // wbVeriler
            // 
            this.wbVeriler.Location = new System.Drawing.Point(484, 10);
            this.wbVeriler.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbVeriler.Name = "wbVeriler";
            this.wbVeriler.Size = new System.Drawing.Size(304, 428);
            this.wbVeriler.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbVeriler);
            this.Controls.Add(this.btnXmlSchemaDogrula);
            this.Controls.Add(this.btnXmlVeriSil);
            this.Controls.Add(this.btnSqlToSchema);
            this.Controls.Add(this.btnVeriDegistir);
            this.Controls.Add(this.btnSchemaOlustur);
            this.Controls.Add(this.btnXPathIleVerileriBul);
            this.Controls.Add(this.btnXmlToSql);
            this.Controls.Add(this.btnXPathIleTagBul);
            this.Controls.Add(this.btnSqlToXml);
            this.Controls.Add(this.btnVeriBul);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnVeriOku);
            this.Controls.Add(this.dgvVeriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeriler;
        private System.Windows.Forms.Button btnVeriOku;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnSqlToXml;
        private System.Windows.Forms.Button btnVeriBul;
        private System.Windows.Forms.Button btnSchemaOlustur;
        private System.Windows.Forms.Button btnXPathIleVerileriBul;
        private System.Windows.Forms.Button btnXmlToSql;
        private System.Windows.Forms.Button btnXPathIleTagBul;
        private System.Windows.Forms.Button btnXmlSchemaDogrula;
        private System.Windows.Forms.Button btnXmlVeriSil;
        private System.Windows.Forms.Button btnSqlToSchema;
        private System.Windows.Forms.Button btnVeriDegistir;
        private System.Windows.Forms.WebBrowser wbVeriler;
    }
}

