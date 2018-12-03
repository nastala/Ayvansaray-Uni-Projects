namespace Hafta3Gun1Part4
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
            this.btnChangeBackgroundColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeBackgroundColor
            // 
            this.btnChangeBackgroundColor.Location = new System.Drawing.Point(59, 35);
            this.btnChangeBackgroundColor.Name = "btnChangeBackgroundColor";
            this.btnChangeBackgroundColor.Size = new System.Drawing.Size(103, 58);
            this.btnChangeBackgroundColor.TabIndex = 0;
            this.btnChangeBackgroundColor.Text = "Change Background Color";
            this.btnChangeBackgroundColor.UseVisualStyleBackColor = true;
            this.btnChangeBackgroundColor.Click += new System.EventHandler(this.btnChangeBackgroundColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 133);
            this.Controls.Add(this.btnChangeBackgroundColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeBackgroundColor;
    }
}

