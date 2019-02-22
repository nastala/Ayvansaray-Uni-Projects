namespace FormApp
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
            this.btnFillProducts = new System.Windows.Forms.Button();
            this.btnBringProducts = new System.Windows.Forms.Button();
            this.btnBringCategories = new System.Windows.Forms.Button();
            this.btnFillCategories = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillProducts
            // 
            this.btnFillProducts.Location = new System.Drawing.Point(13, 13);
            this.btnFillProducts.Name = "btnFillProducts";
            this.btnFillProducts.Size = new System.Drawing.Size(203, 55);
            this.btnFillProducts.TabIndex = 0;
            this.btnFillProducts.Text = "Fill Products";
            this.btnFillProducts.UseVisualStyleBackColor = true;
            this.btnFillProducts.Click += new System.EventHandler(this.btnFillProducts_Click);
            // 
            // btnBringProducts
            // 
            this.btnBringProducts.Location = new System.Drawing.Point(12, 74);
            this.btnBringProducts.Name = "btnBringProducts";
            this.btnBringProducts.Size = new System.Drawing.Size(203, 55);
            this.btnBringProducts.TabIndex = 1;
            this.btnBringProducts.Text = "Bring Products";
            this.btnBringProducts.UseVisualStyleBackColor = true;
            this.btnBringProducts.Click += new System.EventHandler(this.btnBringProducts_Click);
            // 
            // btnBringCategories
            // 
            this.btnBringCategories.Location = new System.Drawing.Point(452, 74);
            this.btnBringCategories.Name = "btnBringCategories";
            this.btnBringCategories.Size = new System.Drawing.Size(203, 55);
            this.btnBringCategories.TabIndex = 3;
            this.btnBringCategories.Text = "Bring Categories";
            this.btnBringCategories.UseVisualStyleBackColor = true;
            this.btnBringCategories.Click += new System.EventHandler(this.btnBringCategories_Click);
            // 
            // btnFillCategories
            // 
            this.btnFillCategories.Location = new System.Drawing.Point(453, 13);
            this.btnFillCategories.Name = "btnFillCategories";
            this.btnFillCategories.Size = new System.Drawing.Size(203, 55);
            this.btnFillCategories.TabIndex = 2;
            this.btnFillCategories.Text = "Fill Categories";
            this.btnFillCategories.UseVisualStyleBackColor = true;
            this.btnFillCategories.Click += new System.EventHandler(this.btnFillCategories_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(13, 135);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(642, 289);
            this.dgvMain.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 435);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnBringCategories);
            this.Controls.Add(this.btnFillCategories);
            this.Controls.Add(this.btnBringProducts);
            this.Controls.Add(this.btnFillProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFillProducts;
        private System.Windows.Forms.Button btnBringProducts;
        private System.Windows.Forms.Button btnBringCategories;
        private System.Windows.Forms.Button btnFillCategories;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}

