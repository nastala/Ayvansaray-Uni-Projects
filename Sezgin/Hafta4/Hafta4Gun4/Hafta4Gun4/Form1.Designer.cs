namespace Hafta4Gun4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ilDiceNumbers = new System.Windows.Forms.ImageList(this.components);
            this.pbDiceLeft = new System.Windows.Forms.PictureBox();
            this.pbDiceRight = new System.Windows.Forms.PictureBox();
            this.btnVibrate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceRight)).BeginInit();
            this.SuspendLayout();
            // 
            // ilDiceNumbers
            // 
            this.ilDiceNumbers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDiceNumbers.ImageStream")));
            this.ilDiceNumbers.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDiceNumbers.Images.SetKeyName(0, "dice1.jpg");
            this.ilDiceNumbers.Images.SetKeyName(1, "dice2.jpg");
            this.ilDiceNumbers.Images.SetKeyName(2, "dice3.jpg");
            this.ilDiceNumbers.Images.SetKeyName(3, "dice4.jpg");
            this.ilDiceNumbers.Images.SetKeyName(4, "dice5.jpg");
            this.ilDiceNumbers.Images.SetKeyName(5, "dice6.jpg");
            // 
            // pbDiceLeft
            // 
            this.pbDiceLeft.Location = new System.Drawing.Point(13, 13);
            this.pbDiceLeft.Name = "pbDiceLeft";
            this.pbDiceLeft.Size = new System.Drawing.Size(100, 100);
            this.pbDiceLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiceLeft.TabIndex = 0;
            this.pbDiceLeft.TabStop = false;
            // 
            // pbDiceRight
            // 
            this.pbDiceRight.Location = new System.Drawing.Point(156, 13);
            this.pbDiceRight.Name = "pbDiceRight";
            this.pbDiceRight.Size = new System.Drawing.Size(100, 100);
            this.pbDiceRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiceRight.TabIndex = 1;
            this.pbDiceRight.TabStop = false;
            // 
            // btnVibrate
            // 
            this.btnVibrate.Location = new System.Drawing.Point(83, 120);
            this.btnVibrate.Name = "btnVibrate";
            this.btnVibrate.Size = new System.Drawing.Size(102, 35);
            this.btnVibrate.TabIndex = 2;
            this.btnVibrate.Text = "SALLA";
            this.btnVibrate.UseVisualStyleBackColor = true;
            this.btnVibrate.Click += new System.EventHandler(this.btnVibrate_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 167);
            this.Controls.Add(this.btnVibrate);
            this.Controls.Add(this.pbDiceRight);
            this.Controls.Add(this.pbDiceLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilDiceNumbers;
        private System.Windows.Forms.PictureBox pbDiceLeft;
        private System.Windows.Forms.PictureBox pbDiceRight;
        private System.Windows.Forms.Button btnVibrate;
        private System.Windows.Forms.Timer timer1;
    }
}

