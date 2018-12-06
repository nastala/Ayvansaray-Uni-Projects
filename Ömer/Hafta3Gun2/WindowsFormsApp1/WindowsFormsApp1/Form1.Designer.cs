namespace WindowsFormsApp1
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
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBLastName = new System.Windows.Forms.TextBox();
            this.tBDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bFontSettings = new System.Windows.Forms.Button();
            this.bColorSettings = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(86, 62);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 0;
            this.tBName.Text = "Name";
            // 
            // tBLastName
            // 
            this.tBLastName.Location = new System.Drawing.Point(86, 88);
            this.tBLastName.Name = "tBLastName";
            this.tBLastName.Size = new System.Drawing.Size(100, 20);
            this.tBLastName.TabIndex = 1;
            this.tBLastName.Text = "LastName";
            // 
            // tBDescription
            // 
            this.tBDescription.Location = new System.Drawing.Point(86, 114);
            this.tBDescription.Multiline = true;
            this.tBDescription.Name = "tBDescription";
            this.tBDescription.Size = new System.Drawing.Size(100, 45);
            this.tBDescription.TabIndex = 2;
            this.tBDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // bFontSettings
            // 
            this.bFontSettings.Location = new System.Drawing.Point(58, 190);
            this.bFontSettings.Name = "bFontSettings";
            this.bFontSettings.Size = new System.Drawing.Size(85, 23);
            this.bFontSettings.TabIndex = 6;
            this.bFontSettings.Text = "Font Settings";
            this.bFontSettings.UseVisualStyleBackColor = true;
            this.bFontSettings.Click += new System.EventHandler(this.FontSettings_Click);
            // 
            // bColorSettings
            // 
            this.bColorSettings.Location = new System.Drawing.Point(149, 190);
            this.bColorSettings.Name = "bColorSettings";
            this.bColorSettings.Size = new System.Drawing.Size(83, 23);
            this.bColorSettings.TabIndex = 7;
            this.bColorSettings.Text = "Color Settings";
            this.bColorSettings.UseVisualStyleBackColor = true;
            this.bColorSettings.Click += new System.EventHandler(this.ColorSettings_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(33, 245);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(74, 42);
            this.bClean.TabIndex = 8;
            this.bClean.Text = "Clean";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(113, 245);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(74, 42);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 333);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bColorSettings);
            this.Controls.Add(this.bFontSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBDescription);
            this.Controls.Add(this.tBLastName);
            this.Controls.Add(this.tBName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBLastName;
        private System.Windows.Forms.TextBox tBDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bFontSettings;
        private System.Windows.Forms.Button bColorSettings;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Button bSend;
    }
}

