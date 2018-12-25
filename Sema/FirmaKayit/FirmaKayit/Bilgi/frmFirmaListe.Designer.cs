namespace FirmaKayit.Bilgi
{
    partial class frmFirmaListe
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnListe = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtFadi = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Fno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ftipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFadi);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnListe);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(190, 54);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 23);
            this.btnListe.TabIndex = 0;
            this.btnListe.Text = "kapat";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(164, 339);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 23);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtFadi
            // 
            this.txtFadi.Location = new System.Drawing.Point(164, 193);
            this.txtFadi.Name = "txtFadi";
            this.txtFadi.Size = new System.Drawing.Size(100, 20);
            this.txtFadi.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fno,
            this.Fadi,
            this.Ftipi,
            this.tel1,
            this.tel2});
            this.Liste.Location = new System.Drawing.Point(23, 28);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(478, 334);
            this.Liste.TabIndex = 0;
            this.Liste.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellDoubleClick);
            // 
            // Fno
            // 
            this.Fno.HeaderText = "Firma no";
            this.Fno.Name = "Fno";
            // 
            // Fadi
            // 
            this.Fadi.HeaderText = "Firma Adi";
            this.Fadi.Name = "Fadi";
            // 
            // Ftipi
            // 
            this.Ftipi.HeaderText = "Firma Tipi";
            this.Ftipi.Name = "Ftipi";
            // 
            // tel1
            // 
            this.tel1.HeaderText = "telefon1";
            this.tel1.Name = "tel1";
            // 
            // tel2
            // 
            this.tel2.HeaderText = "telefon2";
            this.tel2.Name = "tel2";
            // 
            // frmFirmaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmFirmaListe";
            this.Text = "frmFirmaListe";
            this.Load += new System.EventHandler(this.frmFirmaListe_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ftipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel2;
        private System.Windows.Forms.TextBox txtFadi;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnListe;
    }
}