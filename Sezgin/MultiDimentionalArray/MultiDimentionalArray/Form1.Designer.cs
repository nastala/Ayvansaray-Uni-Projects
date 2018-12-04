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
            this.pbPickedImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbImagePixels = new System.Windows.Forms.ListBox();
            this.pbCenterLinedPicture = new System.Windows.Forms.PictureBox();
            this.pbCrossedImage = new System.Windows.Forms.PictureBox();
            this.pbRighAlignedCrossedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPickedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenterLinedPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRighAlignedCrossedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(19, 436);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(48, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path";
            // 
            // btnImageOpen
            // 
            this.btnImageOpen.Location = new System.Drawing.Point(21, 453);
            this.btnImageOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImageOpen.Name = "btnImageOpen";
            this.btnImageOpen.Size = new System.Drawing.Size(60, 24);
            this.btnImageOpen.TabIndex = 1;
            this.btnImageOpen.Text = "Open";
            this.btnImageOpen.UseVisualStyleBackColor = true;
            this.btnImageOpen.Click += new System.EventHandler(this.btnImageOpen_Click);
            // 
            // pbPickedImage
            // 
            this.pbPickedImage.Location = new System.Drawing.Point(669, 414);
            this.pbPickedImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPickedImage.Name = "pbPickedImage";
            this.pbPickedImage.Size = new System.Drawing.Size(50, 50);
            this.pbPickedImage.TabIndex = 2;
            this.pbPickedImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.png)|*.png|(*.txt)|*.txt";
            // 
            // lbImagePixels
            // 
            this.lbImagePixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbImagePixels.FormattingEnabled = true;
            this.lbImagePixels.ItemHeight = 18;
            this.lbImagePixels.Location = new System.Drawing.Point(21, 10);
            this.lbImagePixels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbImagePixels.Name = "lbImagePixels";
            this.lbImagePixels.Size = new System.Drawing.Size(860, 400);
            this.lbImagePixels.TabIndex = 3;
            // 
            // pbCenterLinedPicture
            // 
            this.pbCenterLinedPicture.Location = new System.Drawing.Point(723, 414);
            this.pbCenterLinedPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pbCenterLinedPicture.Name = "pbCenterLinedPicture";
            this.pbCenterLinedPicture.Size = new System.Drawing.Size(50, 50);
            this.pbCenterLinedPicture.TabIndex = 4;
            this.pbCenterLinedPicture.TabStop = false;
            // 
            // pbCrossedImage
            // 
            this.pbCrossedImage.Location = new System.Drawing.Point(777, 414);
            this.pbCrossedImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbCrossedImage.Name = "pbCrossedImage";
            this.pbCrossedImage.Size = new System.Drawing.Size(50, 50);
            this.pbCrossedImage.TabIndex = 5;
            this.pbCrossedImage.TabStop = false;
            // 
            // pbRighAlignedCrossedImage
            // 
            this.pbRighAlignedCrossedImage.Location = new System.Drawing.Point(831, 414);
            this.pbRighAlignedCrossedImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbRighAlignedCrossedImage.Name = "pbRighAlignedCrossedImage";
            this.pbRighAlignedCrossedImage.Size = new System.Drawing.Size(50, 50);
            this.pbRighAlignedCrossedImage.TabIndex = 6;
            this.pbRighAlignedCrossedImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 479);
            this.Controls.Add(this.pbRighAlignedCrossedImage);
            this.Controls.Add(this.pbCrossedImage);
            this.Controls.Add(this.pbCenterLinedPicture);
            this.Controls.Add(this.lbImagePixels);
            this.Controls.Add(this.pbPickedImage);
            this.Controls.Add(this.btnImageOpen);
            this.Controls.Add(this.lblFilePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPickedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCenterLinedPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrossedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRighAlignedCrossedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnImageOpen;
        private System.Windows.Forms.PictureBox pbPickedImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbImagePixels;
        private System.Windows.Forms.PictureBox pbCenterLinedPicture;
        private System.Windows.Forms.PictureBox pbCrossedImage;
        private System.Windows.Forms.PictureBox pbRighAlignedCrossedImage;
    }
}

