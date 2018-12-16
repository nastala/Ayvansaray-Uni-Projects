namespace Homework3
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
            this.ilCharacter = new System.Windows.Forms.ImageList(this.components);
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.timerCharacter = new System.Windows.Forms.Timer(this.components);
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.SuspendLayout();
            // 
            // ilCharacter
            // 
            this.ilCharacter.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCharacter.ImageStream")));
            this.ilCharacter.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCharacter.Images.SetKeyName(0, "down1.png");
            this.ilCharacter.Images.SetKeyName(1, "down2.png");
            this.ilCharacter.Images.SetKeyName(2, "left1.png");
            this.ilCharacter.Images.SetKeyName(3, "left2.png");
            this.ilCharacter.Images.SetKeyName(4, "right1.png");
            this.ilCharacter.Images.SetKeyName(5, "right2.png");
            this.ilCharacter.Images.SetKeyName(6, "up1.png");
            this.ilCharacter.Images.SetKeyName(7, "up2.png");
            this.ilCharacter.Images.SetKeyName(8, "idle.png");
            // 
            // pbCharacter
            // 
            this.pbCharacter.Location = new System.Drawing.Point(118, 54);
            this.pbCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(48, 48);
            this.pbCharacter.TabIndex = 0;
            this.pbCharacter.TabStop = false;
            // 
            // timerCharacter
            // 
            this.timerCharacter.Interval = 50;
            this.timerCharacter.Tick += new System.EventHandler(this.timerCharacter_Tick);
            // 
            // pbSource
            // 
            this.pbSource.Image = ((System.Drawing.Image)(resources.GetObject("pbSource.Image")));
            this.pbSource.Location = new System.Drawing.Point(9, 28);
            this.pbSource.Margin = new System.Windows.Forms.Padding(2);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(105, 105);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSource.TabIndex = 1;
            this.pbSource.TabStop = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Image = ((System.Drawing.Image)(resources.GetObject("pbTarget.Image")));
            this.pbTarget.Location = new System.Drawing.Point(490, 245);
            this.pbTarget.Margin = new System.Windows.Forms.Padding(2);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(105, 105);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbTarget.TabIndex = 2;
            this.pbTarget.TabStop = false;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(528, 352);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(29, 13);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "label";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(43, 135);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(29, 13);
            this.lblSource.TabIndex = 4;
            this.lblSource.Text = "label";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 384);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.pbTarget);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.pbCharacter);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ilCharacter;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.Timer timerCharacter;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblSource;
    }
}

