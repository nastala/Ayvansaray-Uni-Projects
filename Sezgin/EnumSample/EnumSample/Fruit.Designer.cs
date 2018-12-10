namespace EnumSample
{
    partial class Fruit
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
            this.flpFruits = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpFruits
            // 
            this.flpFruits.Location = new System.Drawing.Point(12, 12);
            this.flpFruits.Name = "flpFruits";
            this.flpFruits.Size = new System.Drawing.Size(465, 342);
            this.flpFruits.TabIndex = 0;
            // 
            // Fruit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 373);
            this.Controls.Add(this.flpFruits);
            this.Name = "Fruit";
            this.Text = "Fruit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpFruits;
    }
}

