namespace Doviz_Kurlari2
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
            this.lbDoviz = new System.Windows.Forms.ListBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.dgvDoviz = new System.Windows.Forms.DataGridView();
            this.dgvKur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblDovizAlis = new System.Windows.Forms.Label();
            this.lblDovizSatis = new System.Windows.Forms.Label();
            this.Doviz_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoviz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKur)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDoviz
            // 
            this.lbDoviz.FormattingEnabled = true;
            this.lbDoviz.Location = new System.Drawing.Point(13, 13);
            this.lbDoviz.Name = "lbDoviz";
            this.lbDoviz.Size = new System.Drawing.Size(130, 225);
            this.lbDoviz.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(13, 255);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 23);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // dgvDoviz
            // 
            this.dgvDoviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoviz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Doviz_Ad,
            this.Satis});
            this.dgvDoviz.Location = new System.Drawing.Point(276, 194);
            this.dgvDoviz.Name = "dgvDoviz";
            this.dgvDoviz.Size = new System.Drawing.Size(330, 175);
            this.dgvDoviz.TabIndex = 2;
            // 
            // dgvKur
            // 
            this.dgvKur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKur.Location = new System.Drawing.Point(276, 12);
            this.dgvKur.Name = "dgvKur";
            this.dgvKur.Size = new System.Drawing.Size(330, 164);
            this.dgvKur.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Döviz-Alış";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Döviz-Satış";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(225, 13);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(13, 13);
            this.lblBirim.TabIndex = 7;
            this.lblBirim.Text = "0";
            // 
            // lblDovizAlis
            // 
            this.lblDovizAlis.AutoSize = true;
            this.lblDovizAlis.Location = new System.Drawing.Point(225, 39);
            this.lblDovizAlis.Name = "lblDovizAlis";
            this.lblDovizAlis.Size = new System.Drawing.Size(13, 13);
            this.lblDovizAlis.TabIndex = 8;
            this.lblDovizAlis.Text = "0";
            // 
            // lblDovizSatis
            // 
            this.lblDovizSatis.AutoSize = true;
            this.lblDovizSatis.Location = new System.Drawing.Point(225, 64);
            this.lblDovizSatis.Name = "lblDovizSatis";
            this.lblDovizSatis.Size = new System.Drawing.Size(13, 13);
            this.lblDovizSatis.TabIndex = 9;
            this.lblDovizSatis.Text = "0";
            // 
            // Doviz_Ad
            // 
            this.Doviz_Ad.HeaderText = "Döviz Ad";
            this.Doviz_Ad.Name = "Doviz_Ad";
            // 
            // Satis
            // 
            this.Satis.HeaderText = "Satış";
            this.Satis.Name = "Satis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 396);
            this.Controls.Add(this.lblDovizSatis);
            this.Controls.Add(this.lblDovizAlis);
            this.Controls.Add(this.lblBirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKur);
            this.Controls.Add(this.dgvDoviz);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.lbDoviz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoviz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDoviz;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.DataGridView dgvDoviz;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doviz_Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satis;
        private System.Windows.Forms.DataGridView dgvKur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblDovizAlis;
        private System.Windows.Forms.Label lblDovizSatis;
    }
}

