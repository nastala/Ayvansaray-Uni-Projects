namespace NorthWind.UI
{
    partial class FormCategory
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
            this.tCategoryName = new System.Windows.Forms.TextBox();
            this.tDescription = new System.Windows.Forms.TextBox();
            this.dGVMain = new System.Windows.Forms.DataGridView();
            this.bAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tCategoryName
            // 
            this.tCategoryName.Location = new System.Drawing.Point(12, 39);
            this.tCategoryName.Name = "tCategoryName";
            this.tCategoryName.Size = new System.Drawing.Size(100, 20);
            this.tCategoryName.TabIndex = 0;
            // 
            // tDescription
            // 
            this.tDescription.Location = new System.Drawing.Point(146, 39);
            this.tDescription.Name = "tDescription";
            this.tDescription.Size = new System.Drawing.Size(100, 20);
            this.tDescription.TabIndex = 0;
            // 
            // dGVMain
            // 
            this.dGVMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMain.Location = new System.Drawing.Point(12, 65);
            this.dGVMain.Name = "dGVMain";
            this.dGVMain.Size = new System.Drawing.Size(776, 373);
            this.dGVMain.TabIndex = 1;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(252, 37);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 2;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.dGVMain);
            this.Controls.Add(this.tDescription);
            this.Controls.Add(this.tCategoryName);
            this.Name = "FormCategory";
            this.Text = "Category Form";
            ((System.ComponentModel.ISupportInitialize)(this.dGVMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCategoryName;
        private System.Windows.Forms.TextBox tDescription;
        private System.Windows.Forms.DataGridView dGVMain;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

