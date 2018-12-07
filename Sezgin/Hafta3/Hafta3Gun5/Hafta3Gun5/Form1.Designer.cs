namespace Hafta3Gun5
{
    partial class FormCatchMe
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
            this.btnCatchMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCatchMe
            // 
            this.btnCatchMe.Location = new System.Drawing.Point(210, 235);
            this.btnCatchMe.Name = "btnCatchMe";
            this.btnCatchMe.Size = new System.Drawing.Size(80, 30);
            this.btnCatchMe.TabIndex = 0;
            this.btnCatchMe.Text = "Catch Me";
            this.btnCatchMe.UseVisualStyleBackColor = true;
            this.btnCatchMe.Click += new System.EventHandler(this.btnCatchMe_Click);
            this.btnCatchMe.MouseEnter += new System.EventHandler(this.btnCatchMe_MouseEnter);
            // 
            // FormCatchMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.btnCatchMe);
            this.Name = "FormCatchMe";
            this.Text = "Catch Me Game";
            this.Load += new System.EventHandler(this.FormCatchMe_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormCatchMe_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCatchMe;
    }
}

