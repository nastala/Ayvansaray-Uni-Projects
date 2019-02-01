namespace Quiz_1.Forms.AdminForms
{
    partial class AddBusForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSeatCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDrivers = new System.Windows.Forms.ComboBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.mtbPlate = new System.Windows.Forms.MaskedTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seat Count";
            // 
            // tbSeatCount
            // 
            this.tbSeatCount.Location = new System.Drawing.Point(12, 77);
            this.tbSeatCount.Name = "tbSeatCount";
            this.tbSeatCount.Size = new System.Drawing.Size(121, 20);
            this.tbSeatCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plate";
            // 
            // tbPlate
            // 
            this.tbPlate.Location = new System.Drawing.Point(12, 126);
            this.tbPlate.Name = "tbPlate";
            this.tbPlate.Size = new System.Drawing.Size(121, 20);
            this.tbPlate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Driver";
            // 
            // cbDrivers
            // 
            this.cbDrivers.FormattingEnabled = true;
            this.cbDrivers.Location = new System.Drawing.Point(12, 178);
            this.cbDrivers.Name = "cbDrivers";
            this.cbDrivers.Size = new System.Drawing.Size(121, 21);
            this.cbDrivers.TabIndex = 8;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(163, 29);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(261, 170);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 9;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPath.Location = new System.Drawing.Point(180, 202);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(244, 13);
            this.lblPath.TabIndex = 10;
            this.lblPath.Text = "Please click on the picture above to add an image";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // mtbPlate
            // 
            this.mtbPlate.Location = new System.Drawing.Point(288, 226);
            this.mtbPlate.Mask = "00 >L>L>? 0099";
            this.mtbPlate.Name = "mtbPlate";
            this.mtbPlate.Size = new System.Drawing.Size(100, 20);
            this.mtbPlate.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(99, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddBusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 258);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.mtbPlate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.cbDrivers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSeatCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "AddBusForm";
            this.Text = "AddBusForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSeatCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDrivers;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtbPlate;
        private System.Windows.Forms.Button btnClear;
    }
}