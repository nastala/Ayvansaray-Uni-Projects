namespace Hafta3Gun4Part3
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
            this.lbFor = new System.Windows.Forms.ListBox();
            this.lbWhile = new System.Windows.Forms.ListBox();
            this.lbDoWhile = new System.Windows.Forms.ListBox();
            this.lbForeach = new System.Windows.Forms.ListBox();
            this.lbEnumerator = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.btnEnumerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFor
            // 
            this.lbFor.FormattingEnabled = true;
            this.lbFor.Location = new System.Drawing.Point(29, 27);
            this.lbFor.Name = "lbFor";
            this.lbFor.Size = new System.Drawing.Size(124, 225);
            this.lbFor.TabIndex = 0;
            // 
            // lbWhile
            // 
            this.lbWhile.FormattingEnabled = true;
            this.lbWhile.Location = new System.Drawing.Point(170, 27);
            this.lbWhile.Name = "lbWhile";
            this.lbWhile.Size = new System.Drawing.Size(124, 225);
            this.lbWhile.TabIndex = 1;
            // 
            // lbDoWhile
            // 
            this.lbDoWhile.FormattingEnabled = true;
            this.lbDoWhile.Location = new System.Drawing.Point(312, 27);
            this.lbDoWhile.Name = "lbDoWhile";
            this.lbDoWhile.Size = new System.Drawing.Size(124, 225);
            this.lbDoWhile.TabIndex = 2;
            // 
            // lbForeach
            // 
            this.lbForeach.FormattingEnabled = true;
            this.lbForeach.Location = new System.Drawing.Point(451, 27);
            this.lbForeach.Name = "lbForeach";
            this.lbForeach.Size = new System.Drawing.Size(124, 225);
            this.lbForeach.TabIndex = 3;
            // 
            // lbEnumerator
            // 
            this.lbEnumerator.FormattingEnabled = true;
            this.lbEnumerator.Location = new System.Drawing.Point(592, 27);
            this.lbEnumerator.Name = "lbEnumerator";
            this.lbEnumerator.Size = new System.Drawing.Size(124, 225);
            this.lbEnumerator.TabIndex = 4;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(50, 258);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 23);
            this.btnFor.TabIndex = 5;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(192, 258);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 23);
            this.btnWhile.TabIndex = 6;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(333, 258);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.btnDoWhile.TabIndex = 7;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.Location = new System.Drawing.Point(476, 258);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(75, 23);
            this.btnForeach.TabIndex = 8;
            this.btnForeach.Text = "Foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // btnEnumerator
            // 
            this.btnEnumerator.Location = new System.Drawing.Point(617, 258);
            this.btnEnumerator.Name = "btnEnumerator";
            this.btnEnumerator.Size = new System.Drawing.Size(75, 23);
            this.btnEnumerator.TabIndex = 9;
            this.btnEnumerator.Text = "Enumerator";
            this.btnEnumerator.UseVisualStyleBackColor = true;
            this.btnEnumerator.Click += new System.EventHandler(this.btnEnumerator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 306);
            this.Controls.Add(this.btnEnumerator);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lbEnumerator);
            this.Controls.Add(this.lbForeach);
            this.Controls.Add(this.lbDoWhile);
            this.Controls.Add(this.lbWhile);
            this.Controls.Add(this.lbFor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFor;
        private System.Windows.Forms.ListBox lbWhile;
        private System.Windows.Forms.ListBox lbDoWhile;
        private System.Windows.Forms.ListBox lbForeach;
        private System.Windows.Forms.ListBox lbEnumerator;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnForeach;
        private System.Windows.Forms.Button btnEnumerator;
    }
}

