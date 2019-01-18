namespace Serialization
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
            this.tBSurname = new System.Windows.Forms.TextBox();
            this.dTPBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bImport = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.lbObjects = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(72, 26);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 0;
            // 
            // tBSurname
            // 
            this.tBSurname.Location = new System.Drawing.Point(72, 52);
            this.tBSurname.Name = "tBSurname";
            this.tBSurname.Size = new System.Drawing.Size(100, 20);
            this.tBSurname.TabIndex = 0;
            // 
            // dTPBirthday
            // 
            this.dTPBirthday.Location = new System.Drawing.Point(72, 78);
            this.dTPBirthday.Name = "dTPBirthday";
            this.dTPBirthday.Size = new System.Drawing.Size(175, 20);
            this.dTPBirthday.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(24, 141);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(216, 141);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(75, 23);
            this.bImport.TabIndex = 3;
            this.bImport.Text = "Import";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.Import_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(216, 170);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 3;
            this.bExport.Text = "Export";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.Export_Click);
            // 
            // lbObjects
            // 
            this.lbObjects.FormattingEnabled = true;
            this.lbObjects.Location = new System.Drawing.Point(332, 12);
            this.lbObjects.Name = "lbObjects";
            this.lbObjects.Size = new System.Drawing.Size(119, 173);
            this.lbObjects.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.lbObjects);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dTPBirthday);
            this.Controls.Add(this.tBSurname);
            this.Controls.Add(this.tBName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBSurname;
        private System.Windows.Forms.DateTimePicker dTPBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.ListBox lbObjects;
    }
}

