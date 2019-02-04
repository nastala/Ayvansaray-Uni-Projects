namespace Quiz_1.Forms.AdminForms
{
    partial class AdminMainForm
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
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnManageDrivers = new System.Windows.Forms.Button();
            this.btnManageCities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(16, 44);
            this.btnAddBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(113, 50);
            this.btnAddBus.TabIndex = 0;
            this.btnAddBus.Text = "Manage Busses";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnManageDrivers
            // 
            this.btnManageDrivers.Location = new System.Drawing.Point(137, 44);
            this.btnManageDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageDrivers.Name = "btnManageDrivers";
            this.btnManageDrivers.Size = new System.Drawing.Size(113, 50);
            this.btnManageDrivers.TabIndex = 1;
            this.btnManageDrivers.Text = "Manage Drivers";
            this.btnManageDrivers.UseVisualStyleBackColor = true;
            this.btnManageDrivers.Click += new System.EventHandler(this.btnManageDrivers_Click);
            // 
            // btnManageCities
            // 
            this.btnManageCities.Location = new System.Drawing.Point(258, 44);
            this.btnManageCities.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageCities.Name = "btnManageCities";
            this.btnManageCities.Size = new System.Drawing.Size(113, 50);
            this.btnManageCities.TabIndex = 2;
            this.btnManageCities.Text = "Manage Cities";
            this.btnManageCities.UseVisualStyleBackColor = true;
            this.btnManageCities.Click += new System.EventHandler(this.btnManageCities_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 154);
            this.Controls.Add(this.btnManageCities);
            this.Controls.Add(this.btnManageDrivers);
            this.Controls.Add(this.btnAddBus);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnManageDrivers;
        private System.Windows.Forms.Button btnManageCities;
    }
}