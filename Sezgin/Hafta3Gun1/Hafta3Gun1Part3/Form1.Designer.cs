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
            this.cbMouseHover = new System.Windows.Forms.CheckBox();
            this.cbMouseEnter = new System.Windows.Forms.CheckBox();
            this.cbMouseLeave = new System.Windows.Forms.CheckBox();
            this.cbMouseUp = new System.Windows.Forms.CheckBox();
            this.cbMouseDown = new System.Windows.Forms.CheckBox();
            this.cbMouseMove = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            // cbMouseHover
            // 
            this.cbMouseHover.AutoSize = true;
            this.cbMouseHover.Location = new System.Drawing.Point(3, 3);
            this.cbMouseHover.Name = "cbMouseHover";
            this.cbMouseHover.Size = new System.Drawing.Size(90, 17);
            this.cbMouseHover.TabIndex = 4;
            this.cbMouseHover.Text = "Mouse Hover";
            this.cbMouseHover.UseVisualStyleBackColor = true;
            // 
            // cbMouseEnter
            // 
            this.cbMouseEnter.AutoSize = true;
            this.cbMouseEnter.Location = new System.Drawing.Point(3, 26);
            this.cbMouseEnter.Name = "cbMouseEnter";
            this.cbMouseEnter.Size = new System.Drawing.Size(86, 17);
            this.cbMouseEnter.TabIndex = 5;
            this.cbMouseEnter.Text = "Mouse Enter";
            this.cbMouseEnter.UseVisualStyleBackColor = true;
            // 
            // cbMouseLeave
            // 
            this.cbMouseLeave.AutoSize = true;
            this.cbMouseLeave.Location = new System.Drawing.Point(3, 49);
            this.cbMouseLeave.Name = "cbMouseLeave";
            this.cbMouseLeave.Size = new System.Drawing.Size(91, 17);
            this.cbMouseLeave.TabIndex = 6;
            this.cbMouseLeave.Text = "Mouse Leave";
            this.cbMouseLeave.UseVisualStyleBackColor = true;
            // 
            // cbMouseUp
            // 
            this.cbMouseUp.AutoSize = true;
            this.cbMouseUp.Location = new System.Drawing.Point(3, 72);
            this.cbMouseUp.Name = "cbMouseUp";
            this.cbMouseUp.Size = new System.Drawing.Size(75, 17);
            this.cbMouseUp.TabIndex = 7;
            this.cbMouseUp.Text = "Mouse Up";
            this.cbMouseUp.UseVisualStyleBackColor = true;
            // 
            // cbMouseDown
            // 
            this.cbMouseDown.AutoSize = true;
            this.cbMouseDown.Location = new System.Drawing.Point(3, 97);
            this.cbMouseDown.Name = "cbMouseDown";
            this.cbMouseDown.Size = new System.Drawing.Size(89, 17);
            this.cbMouseDown.TabIndex = 8;
            this.cbMouseDown.Text = "Mouse Down";
            this.cbMouseDown.UseVisualStyleBackColor = true;
            // 
            // cbMouseMove
            // 
            this.cbMouseMove.AutoSize = true;
            this.cbMouseMove.Location = new System.Drawing.Point(3, 120);
            this.cbMouseMove.Name = "cbMouseMove";
            this.cbMouseMove.Size = new System.Drawing.Size(88, 17);
            this.cbMouseMove.TabIndex = 9;
            this.cbMouseMove.Text = "Mouse Move";
            this.cbMouseMove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMouseHover);
            this.panel1.Controls.Add(this.cbMouseMove);
            this.panel1.Controls.Add(this.cbMouseEnter);
            this.panel1.Controls.Add(this.cbMouseDown);
            this.panel1.Controls.Add(this.cbMouseLeave);
            this.panel1.Controls.Add(this.cbMouseUp);
            this.panel1.Location = new System.Drawing.Point(358, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 206);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbMouseEvents);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox lbMouseEvents;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox cbMouseHover;
        private System.Windows.Forms.CheckBox cbMouseEnter;
        private System.Windows.Forms.CheckBox cbMouseLeave;
        private System.Windows.Forms.CheckBox cbMouseUp;
        private System.Windows.Forms.CheckBox cbMouseDown;
        private System.Windows.Forms.CheckBox cbMouseMove;
        private System.Windows.Forms.Panel panel1;
    }
}

