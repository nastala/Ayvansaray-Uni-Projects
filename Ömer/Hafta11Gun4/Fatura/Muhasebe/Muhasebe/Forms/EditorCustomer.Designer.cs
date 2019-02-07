namespace Muhasebe.Forms
{
    partial class EditorCustomer
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
            this.tBCustomerTitle = new System.Windows.Forms.TextBox();
            this.cBCities = new Muhasebe.Controls.EntityComboBox();
            this.cBDistricts = new Muhasebe.Controls.EntityComboBox();
            this.tBAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBCustomerTitle
            // 
            this.tBCustomerTitle.Location = new System.Drawing.Point(57, 9);
            this.tBCustomerTitle.Name = "tBCustomerTitle";
            this.tBCustomerTitle.Size = new System.Drawing.Size(100, 20);
            this.tBCustomerTitle.TabIndex = 0;
            // 
            // cBCities
            // 
            this.cBCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCities.FormattingEnabled = true;
            this.cBCities.Location = new System.Drawing.Point(57, 35);
            this.cBCities.Name = "cBCities";
            this.cBCities.Size = new System.Drawing.Size(121, 21);
            this.cBCities.TabIndex = 1;
            this.cBCities.SelectedIndexChanged += new System.EventHandler(this.Cities_SelectedIndexChanged);
            // 
            // cBDistricts
            // 
            this.cBDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDistricts.FormattingEnabled = true;
            this.cBDistricts.Location = new System.Drawing.Point(57, 62);
            this.cBDistricts.Name = "cBDistricts";
            this.cBDistricts.Size = new System.Drawing.Size(121, 21);
            this.cBDistricts.TabIndex = 1;
            // 
            // tBAddress
            // 
            this.tBAddress.Location = new System.Drawing.Point(245, 9);
            this.tBAddress.Multiline = true;
            this.tBAddress.Name = "tBAddress";
            this.tBAddress.Size = new System.Drawing.Size(209, 75);
            this.tBAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ünvan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "İlçe";
            // 
            // EditorCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBDistricts);
            this.Controls.Add(this.cBCities);
            this.Controls.Add(this.tBAddress);
            this.Controls.Add(this.tBCustomerTitle);
            this.Name = "EditorCustomer";
            this.Text = "EditorCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBCustomerTitle;
        private Controls.EntityComboBox cBCities;
        private Controls.EntityComboBox cBDistricts;
        private System.Windows.Forms.TextBox tBAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}