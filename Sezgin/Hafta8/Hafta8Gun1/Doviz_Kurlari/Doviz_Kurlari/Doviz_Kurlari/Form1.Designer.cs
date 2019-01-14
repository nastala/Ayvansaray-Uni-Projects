namespace Doviz_Kurlari
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
            this.dgvKurlar = new System.Windows.Forms.DataGridView();
            this.btnYukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKurlar
            // 
            this.dgvKurlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurlar.Location = new System.Drawing.Point(12, 12);
            this.dgvKurlar.Name = "dgvKurlar";
            this.dgvKurlar.Size = new System.Drawing.Size(588, 215);
            this.dgvKurlar.TabIndex = 0;
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(13, 234);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 23);
            this.btnYukle.TabIndex = 1;
            this.btnYukle.Text = "Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 285);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.dgvKurlar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKurlar;
        private System.Windows.Forms.Button btnYukle;
    }
}

