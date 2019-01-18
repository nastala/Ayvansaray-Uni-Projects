namespace Serialization_JSON_1
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStudentSurname = new System.Windows.Forms.TextBox();
            this.dtpStudentBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToInternal = new System.Windows.Forms.Button();
            this.btnToExternal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(240, 12);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(131, 238);
            this.lbStudents.TabIndex = 0;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(91, 19);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(143, 20);
            this.tbStudentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(47, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad: ";
            // 
            // tbStudentSurname
            // 
            this.tbStudentSurname.Location = new System.Drawing.Point(91, 45);
            this.tbStudentSurname.Name = "tbStudentSurname";
            this.tbStudentSurname.Size = new System.Drawing.Size(143, 20);
            this.tbStudentSurname.TabIndex = 4;
            // 
            // dtpStudentBirthDate
            // 
            this.dtpStudentBirthDate.Location = new System.Drawing.Point(91, 71);
            this.dtpStudentBirthDate.Name = "dtpStudentBirthDate";
            this.dtpStudentBirthDate.Size = new System.Drawing.Size(143, 20);
            this.dtpStudentBirthDate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doğum Tarihi: ";
            // 
            // btnToInternal
            // 
            this.btnToInternal.Location = new System.Drawing.Point(47, 149);
            this.btnToInternal.Name = "btnToInternal";
            this.btnToInternal.Size = new System.Drawing.Size(131, 35);
            this.btnToInternal.TabIndex = 10;
            this.btnToInternal.Text = "İçe Aktar";
            this.btnToInternal.UseVisualStyleBackColor = true;
            this.btnToInternal.Click += new System.EventHandler(this.btnToInternal_Click);
            // 
            // btnToExternal
            // 
            this.btnToExternal.Location = new System.Drawing.Point(47, 190);
            this.btnToExternal.Name = "btnToExternal";
            this.btnToExternal.Size = new System.Drawing.Size(131, 35);
            this.btnToExternal.TabIndex = 11;
            this.btnToExternal.Text = "Dışa Aktar";
            this.btnToExternal.UseVisualStyleBackColor = true;
            this.btnToExternal.Click += new System.EventHandler(this.btnToExternal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 295);
            this.Controls.Add(this.btnToExternal);
            this.Controls.Add(this.btnToInternal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStudentBirthDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbStudentSurname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStudentSurname;
        private System.Windows.Forms.DateTimePicker dtpStudentBirthDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToInternal;
        private System.Windows.Forms.Button btnToExternal;
    }
}

