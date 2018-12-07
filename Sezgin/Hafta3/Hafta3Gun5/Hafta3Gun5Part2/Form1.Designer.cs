namespace Hafta3Gun5Part2
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
            this.pbSonic = new System.Windows.Forms.PictureBox();
            this.pbHorse = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSonic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSonic
            // 
            this.pbSonic.Image = ((System.Drawing.Image)(resources.GetObject("pbSonic.Image")));
            this.pbSonic.Location = new System.Drawing.Point(13, 69);
            this.pbSonic.Name = "pbSonic";
            this.pbSonic.Size = new System.Drawing.Size(50, 50);
            this.pbSonic.TabIndex = 1;
            this.pbSonic.TabStop = false;
            // 
            // pbHorse
            // 
            this.pbHorse.Image = ((System.Drawing.Image)(resources.GetObject("pbHorse.Image")));
            this.pbHorse.ImageLocation = "";
            this.pbHorse.InitialImage = null;
            this.pbHorse.Location = new System.Drawing.Point(13, 13);
            this.pbHorse.Name = "pbHorse";
            this.pbHorse.Size = new System.Drawing.Size(50, 50);
            this.pbHorse.TabIndex = 2;
            this.pbHorse.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(707, 377);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 3;
            this.btnAgain.Text = "Again";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Visible = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 412);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.pbHorse);
            this.Controls.Add(this.pbSonic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSonic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHorse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSonic;
        private System.Windows.Forms.PictureBox pbHorse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAgain;
    }
}

