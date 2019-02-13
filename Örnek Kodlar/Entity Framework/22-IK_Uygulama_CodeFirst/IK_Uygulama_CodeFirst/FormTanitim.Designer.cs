namespace IK_Uygulama_CodeFirst
{
    partial class FormTanitim
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
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açıklama";
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(157, 32);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(100, 20);
            this.txtaciklama.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(90, 305);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.Location = new System.Drawing.Point(191, 305);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(75, 23);
            this.btnguncel.TabIndex = 4;
            this.btnguncel.Text = "Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(293, 305);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            // 
            // FormTanitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 369);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.label1);
            this.Name = "FormTanitim";
            this.Text = "FormTanitim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtaciklama;
        public System.Windows.Forms.Button btnekle;
        public System.Windows.Forms.Button btnguncel;
        public System.Windows.Forms.Button btnsil;
    }
}