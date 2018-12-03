namespace Hafta3Gun1Part3
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
            this.tbText = new System.Windows.Forms.TextBox();
            this.lbMouseEvents = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tbText.Location = new System.Drawing.Point(22, 12);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(329, 95);
            this.tbText.TabIndex = 0;
            this.tbText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseDown);
            this.tbText.MouseEnter += new System.EventHandler(this.tbText_MouseEnter);
            this.tbText.MouseLeave += new System.EventHandler(this.tbText_MouseLeave);
            this.tbText.MouseHover += new System.EventHandler(this.tbText_MouseHover);
            this.tbText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseMove);
            this.tbText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbText_MouseUp);
            // 
            // lbMouseEvents
            // 
            this.lbMouseEvents.FormattingEnabled = true;
            this.lbMouseEvents.Location = new System.Drawing.Point(22, 124);
            this.lbMouseEvents.Name = "lbMouseEvents";
            this.lbMouseEvents.Size = new System.Drawing.Size(329, 95);
            this.lbMouseEvents.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(22, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 275);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbMouseEvents);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox lbMouseEvents;
        private System.Windows.Forms.Button btnClear;
    }
}

