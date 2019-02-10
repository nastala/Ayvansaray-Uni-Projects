namespace json
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
            this.btnserial = new System.Windows.Forms.Button();
            this.btnklazörolustur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_yas = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLabTemizle = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btnDosya = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnserializellist = new System.Windows.Forms.Button();
            this.btn_deserialize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.webBrowser1JSON = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnserial
            // 
            this.btnserial.Location = new System.Drawing.Point(12, 9);
            this.btnserial.Name = "btnserial";
            this.btnserial.Size = new System.Drawing.Size(87, 23);
            this.btnserial.TabIndex = 0;
            this.btnserial.Text = "SERİALİZE";
            this.btnserial.UseVisualStyleBackColor = true;
            this.btnserial.Click += new System.EventHandler(this.btnserial_Click);
            // 
            // btnklazörolustur
            // 
            this.btnklazörolustur.Location = new System.Drawing.Point(12, 43);
            this.btnklazörolustur.Name = "btnklazörolustur";
            this.btnklazörolustur.Size = new System.Drawing.Size(87, 23);
            this.btnklazörolustur.TabIndex = 2;
            this.btnklazörolustur.Text = "DESERİAL";
            this.btnklazörolustur.UseVisualStyleBackColor = true;
            this.btnklazörolustur.Click += new System.EventHandler(this.btndeserial_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnklazörolustur);
            this.panel1.Controls.Add(this.btnserial);
            this.panel1.Location = new System.Drawing.Point(32, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 102);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yaş:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(51, 5);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(116, 23);
            this.txt_ad.TabIndex = 8;
            // 
            // txt_yas
            // 
            this.txt_yas.Location = new System.Drawing.Point(52, 57);
            this.txt_yas.Name = "txt_yas";
            this.txt_yas.Size = new System.Drawing.Size(116, 23);
            this.txt_yas.TabIndex = 9;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(51, 31);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(116, 23);
            this.txt_soyad.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_temizle);
            this.panel2.Controls.Add(this.btn_sil);
            this.panel2.Controls.Add(this.txt_yas);
            this.panel2.Controls.Add(this.btn_ekle);
            this.panel2.Controls.Add(this.txt_soyad);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_ad);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(183, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 286);
            this.panel2.TabIndex = 11;
            // 
            // btnLabTemizle
            // 
            this.btnLabTemizle.Location = new System.Drawing.Point(486, 297);
            this.btnLabTemizle.Name = "btnLabTemizle";
            this.btnLabTemizle.Size = new System.Drawing.Size(168, 23);
            this.btnLabTemizle.TabIndex = 18;
            this.btnLabTemizle.Text = "Listeyi Temizle";
            this.btnLabTemizle.UseVisualStyleBackColor = true;
            this.btnLabTemizle.Click += new System.EventHandler(this.btnLabTemizle_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(176, 9);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(68, 42);
            this.btn_temizle.TabIndex = 17;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDosya
            // 
            this.btnDosya.Location = new System.Drawing.Point(22, 275);
            this.btnDosya.Name = "btnDosya";
            this.btnDosya.Size = new System.Drawing.Size(130, 23);
            this.btnDosya.TabIndex = 16;
            this.btnDosya.Text = "DOSYALARI SİL";
            this.btnDosya.UseVisualStyleBackColor = true;
            this.btnDosya.Click += new System.EventHandler(this.btnDosya_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(189, 169);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(55, 23);
            this.btn_sil.TabIndex = 14;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(176, 54);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(68, 23);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(0, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 191);
            this.listBox1.TabIndex = 12;
            // 
            // btnserializellist
            // 
            this.btnserializellist.Location = new System.Drawing.Point(3, 3);
            this.btnserializellist.Name = "btnserializellist";
            this.btnserializellist.Size = new System.Drawing.Size(130, 25);
            this.btnserializellist.TabIndex = 12;
            this.btnserializellist.Text = "SERİALİZE LİST";
            this.btnserializellist.UseVisualStyleBackColor = true;
            this.btnserializellist.Click += new System.EventHandler(this.btnserializellist_Click);
            // 
            // btn_deserialize
            // 
            this.btn_deserialize.Location = new System.Drawing.Point(3, 34);
            this.btn_deserialize.Name = "btn_deserialize";
            this.btn_deserialize.Size = new System.Drawing.Size(130, 25);
            this.btn_deserialize.TabIndex = 13;
            this.btn_deserialize.Text = "DESERİALİZE LİST";
            this.btn_deserialize.UseVisualStyleBackColor = true;
            this.btn_deserialize.Click += new System.EventHandler(this.btn_deserialize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnserializellist);
            this.panel3.Controls.Add(this.btn_deserialize);
            this.panel3.Location = new System.Drawing.Point(32, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 90);
            this.panel3.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ad,
            this.soyad,
            this.yas});
            this.listView1.Location = new System.Drawing.Point(433, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(252, 286);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Ad
            // 
            this.Ad.Text = "AD";
            this.Ad.Width = 69;
            // 
            // soyad
            // 
            this.soyad.Text = "SOYAD";
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soyad.Width = 89;
            // 
            // yas
            // 
            this.yas.Text = "YAŞ";
            this.yas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.yas.Width = 81;
            // 
            // webBrowser1JSON
            // 
            this.webBrowser1JSON.Location = new System.Drawing.Point(10, 326);
            this.webBrowser1JSON.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1JSON.Name = "webBrowser1JSON";
            this.webBrowser1JSON.Size = new System.Drawing.Size(673, 154);
            this.webBrowser1JSON.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tek kayit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Listedeki kayitlar";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_ekle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(688, 492);
            this.Controls.Add(this.btnLabTemizle);
            this.Controls.Add(this.btnDosya);
            this.Controls.Add(this.webBrowser1JSON);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnserial;
        private System.Windows.Forms.Button btnklazörolustur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_yas;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btnDosya;
        private System.Windows.Forms.Button btnserializellist;
        private System.Windows.Forms.Button btn_deserialize;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader yas;
        private System.Windows.Forms.Button btnLabTemizle;
        private System.Windows.Forms.WebBrowser webBrowser1JSON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

