namespace Faturaİslemleri
{
    partial class FormFaturaGoruntule
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
            this.btnListele = new System.Windows.Forms.Button();
            this.tbFaturaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMusteriSehir = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMusteriIlce = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFaturalar = new System.Windows.Forms.DataGridView();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(12, 189);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(80, 34);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // tbFaturaID
            // 
            this.tbFaturaID.Location = new System.Drawing.Point(75, 23);
            this.tbFaturaID.Name = "tbFaturaID";
            this.tbFaturaID.Size = new System.Drawing.Size(121, 20);
            this.tbFaturaID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura ID";
            // 
            // cbMusteriSehir
            // 
            this.cbMusteriSehir.FormattingEnabled = true;
            this.cbMusteriSehir.Location = new System.Drawing.Point(75, 59);
            this.cbMusteriSehir.Name = "cbMusteriSehir";
            this.cbMusteriSehir.Size = new System.Drawing.Size(121, 21);
            this.cbMusteriSehir.TabIndex = 3;
            this.cbMusteriSehir.SelectedIndexChanged += new System.EventHandler(this.cbMusteriSehir_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMusteri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMusteriIlce);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMusteriSehir);
            this.groupBox1.Controls.Add(this.tbFaturaID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme Seçenekleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri İl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Müşteri İlçe";
            // 
            // cbMusteriIlce
            // 
            this.cbMusteriIlce.FormattingEnabled = true;
            this.cbMusteriIlce.Location = new System.Drawing.Point(75, 96);
            this.cbMusteriIlce.Name = "cbMusteriIlce";
            this.cbMusteriIlce.Size = new System.Drawing.Size(121, 21);
            this.cbMusteriIlce.TabIndex = 5;
            this.cbMusteriIlce.SelectedIndexChanged += new System.EventHandler(this.cbMusteriIlce_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Müşteri";
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(75, 130);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cbMusteri.TabIndex = 7;
            this.cbMusteri.SelectedIndexChanged += new System.EventHandler(this.cbMusteri_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFaturalar);
            this.groupBox2.Location = new System.Drawing.Point(221, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 210);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // dgvFaturalar
            // 
            this.dgvFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturalar.Location = new System.Drawing.Point(7, 20);
            this.dgvFaturalar.Name = "dgvFaturalar";
            this.dgvFaturalar.Size = new System.Drawing.Size(554, 184);
            this.dgvFaturalar.TabIndex = 0;
            this.dgvFaturalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFaturalar_CellClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(134, 189);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 34);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // FormFaturaGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 237);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListele);
            this.Name = "FormFaturaGoruntule";
            this.Text = "FormFaturaGoruntule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox tbFaturaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMusteriSehir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMusteriIlce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvFaturalar;
        private System.Windows.Forms.Button btnTemizle;
    }
}