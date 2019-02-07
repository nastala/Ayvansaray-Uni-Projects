namespace Muhasebe.Forms
{
    partial class EditorDistrict
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
            this.tBDistrictName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBCities = new Muhasebe.Controls.EntityComboBox();
            this.SuspendLayout();
            // 
            // tBDistrictName
            // 
            this.tBDistrictName.Location = new System.Drawing.Point(89, 22);
            this.tBDistrictName.Name = "tBDistrictName";
            this.tBDistrictName.Size = new System.Drawing.Size(100, 20);
            this.tBDistrictName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "District Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // cBCities
            // 
            this.cBCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCities.FormattingEnabled = true;
            this.cBCities.Location = new System.Drawing.Point(277, 22);
            this.cBCities.Name = "cBCities";
            this.cBCities.Size = new System.Drawing.Size(121, 21);
            this.cBCities.TabIndex = 3;
            this.cBCities.SelectedIndexChanged += new System.EventHandler(this.Cities_SelectedIndexChanged);
            // 
            // EditorDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBCities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBDistrictName);
            this.Name = "EditorDistrict";
            this.Text = "EditorDistrict";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBDistrictName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.EntityComboBox cBCities;
    }
}