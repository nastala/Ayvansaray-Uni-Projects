namespace WordGame
{
    partial class FormFirstInput
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
            this.tBFirstLetter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBFirstLetter
            // 
            this.tBFirstLetter.Location = new System.Drawing.Point(74, 12);
            this.tBFirstLetter.MaxLength = 1;
            this.tBFirstLetter.Name = "tBFirstLetter";
            this.tBFirstLetter.Size = new System.Drawing.Size(100, 20);
            this.tBFirstLetter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Letter";
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(198, 10);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 3;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // FormFirstInput
            // 
            this.AcceptButton = this.bApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 45);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBFirstLetter);
            this.Name = "FormFirstInput";
            this.Text = "FormFirstInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBFirstLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bApply;
    }
}