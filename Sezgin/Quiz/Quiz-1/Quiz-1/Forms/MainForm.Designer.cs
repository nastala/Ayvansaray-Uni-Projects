namespace Quiz_1
{
    partial class MainForm
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
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.btnPurchaseTicket = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnBusTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(28, 41);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(129, 54);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // btnPurchaseTicket
            // 
            this.btnPurchaseTicket.Location = new System.Drawing.Point(165, 41);
            this.btnPurchaseTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchaseTicket.Name = "btnPurchaseTicket";
            this.btnPurchaseTicket.Size = new System.Drawing.Size(129, 54);
            this.btnPurchaseTicket.TabIndex = 3;
            this.btnPurchaseTicket.Text = "Purchase Ticket";
            this.btnPurchaseTicket.UseVisualStyleBackColor = true;
            this.btnPurchaseTicket.Click += new System.EventHandler(this.btnPurchaseTicket_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(302, 41);
            this.btnControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(129, 54);
            this.btnControl.TabIndex = 4;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnBusTracking
            // 
            this.btnBusTracking.Location = new System.Drawing.Point(439, 41);
            this.btnBusTracking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBusTracking.Name = "btnBusTracking";
            this.btnBusTracking.Size = new System.Drawing.Size(129, 54);
            this.btnBusTracking.TabIndex = 5;
            this.btnBusTracking.Text = "Bus Tracking";
            this.btnBusTracking.UseVisualStyleBackColor = true;
            this.btnBusTracking.Click += new System.EventHandler(this.btnBusTracking_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 159);
            this.Controls.Add(this.btnBusTracking);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnPurchaseTicket);
            this.Controls.Add(this.btnAdminPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnPurchaseTicket;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnBusTracking;
    }
}

