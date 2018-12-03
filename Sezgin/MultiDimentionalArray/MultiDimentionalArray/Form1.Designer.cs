namespace MultiDimentionalArray
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
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnImageOpen = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbImagePixels = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(25, 537);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(63, 17);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path";
            // 
            // btnImageOpen
            // 
            this.btnImageOpen.Location = new System.Drawing.Point(28, 557);
            this.btnImageOpen.Name = "btnImageOpen";
            this.btnImageOpen.Size = new System.Drawing.Size(80, 30);
            this.btnImageOpen.TabIndex = 1;
            this.btnImageOpen.Text = "Open";
            this.btnImageOpen.UseVisualStyleBackColor = true;
            this.btnImageOpen.Click += new System.EventHandler(this.btnImageOpen_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(126, 557);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(30, 30);
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbImagePixels
            // 
            this.lbImagePixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbImagePixels.FormattingEnabled = true;
            this.lbImagePixels.ItemHeight = 22;
            this.lbImagePixels.Location = new System.Drawing.Point(28, 12);
            this.lbImagePixels.Name = "lbImagePixels";
            this.lbImagePixels.Size = new System.Drawing.Size(1060, 510);
            this.lbImagePixels.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 601);
            this.Controls.Add(this.lbImagePixels);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnImageOpen);
            this.Controls.Add(this.lblFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnImageOpen;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbImagePixels;
    }
}

