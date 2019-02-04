namespace BillingProject.Forms
{
    partial class ManageDistrictsForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDistrictName = new System.Windows.Forms.TextBox();
            this.dgvDistricts = new System.Windows.Forms.DataGridView();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(88, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 28);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 28);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "District Name";
            // 
            // tbDistrictName
            // 
            this.tbDistrictName.Location = new System.Drawing.Point(12, 28);
            this.tbDistrictName.Name = "tbDistrictName";
            this.tbDistrictName.Size = new System.Drawing.Size(232, 20);
            this.tbDistrictName.TabIndex = 7;
            // 
            // dgvDistricts
            // 
            this.dgvDistricts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistricts.Location = new System.Drawing.Point(13, 132);
            this.dgvDistricts.Name = "dgvDistricts";
            this.dgvDistricts.Size = new System.Drawing.Size(232, 247);
            this.dgvDistricts.TabIndex = 6;
            this.dgvDistricts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistricts_CellClick);
            // 
            // cbCities
            // 
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(15, 71);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(229, 21);
            this.cbCities.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "City";
            // 
            // ManageDistrictsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCities);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDistrictName);
            this.Controls.Add(this.dgvDistricts);
            this.Name = "ManageDistrictsForm";
            this.Text = "ManageDistrictsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistricts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDistrictName;
        private System.Windows.Forms.DataGridView dgvDistricts;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label label2;
    }
}