namespace Faturaİslemleri
{
    partial class FaturaDetayForm
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
            this.dgvFaturaDetaylari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFaturaDetaylari
            // 
            this.dgvFaturaDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFaturaDetaylari.Location = new System.Drawing.Point(12, 12);
            this.dgvFaturaDetaylari.Name = "dgvFaturaDetaylari";
            this.dgvFaturaDetaylari.Size = new System.Drawing.Size(511, 237);
            this.dgvFaturaDetaylari.TabIndex = 0;
            // 
            // FaturaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 256);
            this.Controls.Add(this.dgvFaturaDetaylari);
            this.Name = "FaturaDetayForm";
            this.Text = "FaturaDetayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFaturaDetaylari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFaturaDetaylari;
    }
}