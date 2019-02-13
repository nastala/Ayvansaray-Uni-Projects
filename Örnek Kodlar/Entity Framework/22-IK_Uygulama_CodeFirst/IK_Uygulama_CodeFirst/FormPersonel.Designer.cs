namespace IK_Uygulama_CodeFirst
{
    partial class FormPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbunvan = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.cmbegitim = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbyonetici = new System.Windows.Forms.ComboBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.chcyoneticimi = new System.Windows.Forms.CheckBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtadres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(959, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(121, 12);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(121, 38);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(121, 90);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(100, 20);
            this.txtmaas.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(44, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dogum Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(44, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Maas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(328, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ünvan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(328, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "İl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(328, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "İlçe";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(121, 116);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(44, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "E-Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(328, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Egitim";
            // 
            // cmbunvan
            // 
            this.cmbunvan.FormattingEnabled = true;
            this.cmbunvan.Location = new System.Drawing.Point(405, 9);
            this.cmbunvan.Name = "cmbunvan";
            this.cmbunvan.Size = new System.Drawing.Size(121, 21);
            this.cmbunvan.TabIndex = 18;
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(405, 36);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 19;
            this.cmbil.SelectedIndexChanged += new System.EventHandler(this.cmbil_SelectedIndexChanged);
            // 
            // cmbegitim
            // 
            this.cmbegitim.FormattingEnabled = true;
            this.cmbegitim.Location = new System.Drawing.Point(405, 89);
            this.cmbegitim.Name = "cmbegitim";
            this.cmbegitim.Size = new System.Drawing.Size(121, 21);
            this.cmbegitim.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(328, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Yönetici";
            // 
            // cmbyonetici
            // 
            this.cmbyonetici.FormattingEnabled = true;
            this.cmbyonetici.Location = new System.Drawing.Point(405, 116);
            this.cmbyonetici.Name = "cmbyonetici";
            this.cmbyonetici.Size = new System.Drawing.Size(121, 21);
            this.cmbyonetici.TabIndex = 23;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.Black;
            this.btnekle.Image = global::IK_Uygulama_CodeFirst.Properties.Resources.btnnnnnn;
            this.btnekle.Location = new System.Drawing.Point(617, 18);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 25);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncel.ForeColor = System.Drawing.Color.Black;
            this.btnguncel.Image = global::IK_Uygulama_CodeFirst.Properties.Resources.btnnnnnn;
            this.btnguncel.Location = new System.Drawing.Point(617, 58);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(97, 26);
            this.btnguncel.TabIndex = 25;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btnguncel_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.Black;
            this.btnsil.Image = global::IK_Uygulama_CodeFirst.Properties.Resources.btnnnnnn;
            this.btnsil.Location = new System.Drawing.Point(617, 97);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(97, 24);
            this.btnsil.TabIndex = 26;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // chcyoneticimi
            // 
            this.chcyoneticimi.AutoSize = true;
            this.chcyoneticimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chcyoneticimi.Location = new System.Drawing.Point(448, 154);
            this.chcyoneticimi.Name = "chcyoneticimi";
            this.chcyoneticimi.Size = new System.Drawing.Size(78, 17);
            this.chcyoneticimi.TabIndex = 28;
            this.chcyoneticimi.Text = "Yönetici Mi";
            this.chcyoneticimi.UseVisualStyleBackColor = false;
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(405, 63);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(121, 21);
            this.cmbilce.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(44, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Adres";
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(121, 147);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(100, 20);
            this.txtadres.TabIndex = 31;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IK_Uygulama_CodeFirst.Properties.Resources.indir;
            this.ClientSize = new System.Drawing.Size(983, 521);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbilce);
            this.Controls.Add(this.chcyoneticimi);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.cmbyonetici);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbegitim);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.cmbunvan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbunvan;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ComboBox cmbegitim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbyonetici;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncel;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.CheckBox chcyoneticimi;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtadres;
    }
}