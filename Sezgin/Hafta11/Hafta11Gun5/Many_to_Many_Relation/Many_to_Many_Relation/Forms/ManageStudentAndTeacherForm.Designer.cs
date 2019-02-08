namespace Many_to_Many_Relation.Forms
{
    partial class ManageStudentAndTeacherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeachers = new System.Windows.Forms.ComboBox();
            this.dgvTeacherStudents = new System.Windows.Forms.DataGridView();
            this.lvStudents = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherStudents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Teacher";
            // 
            // cbTeachers
            // 
            this.cbTeachers.FormattingEnabled = true;
            this.cbTeachers.Location = new System.Drawing.Point(9, 33);
            this.cbTeachers.Name = "cbTeachers";
            this.cbTeachers.Size = new System.Drawing.Size(121, 21);
            this.cbTeachers.TabIndex = 1;
            this.cbTeachers.SelectedIndexChanged += new System.EventHandler(this.cbTeachers_SelectedIndexChanged);
            // 
            // dgvTeacherStudents
            // 
            this.dgvTeacherStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherStudents.Location = new System.Drawing.Point(9, 60);
            this.dgvTeacherStudents.Name = "dgvTeacherStudents";
            this.dgvTeacherStudents.Size = new System.Drawing.Size(332, 187);
            this.dgvTeacherStudents.TabIndex = 2;
            // 
            // lvStudents
            // 
            this.lvStudents.Location = new System.Drawing.Point(6, 19);
            this.lvStudents.Name = "lvStudents";
            this.lvStudents.Size = new System.Drawing.Size(222, 228);
            this.lvStudents.TabIndex = 3;
            this.lvStudents.UseCompatibleStateImageBehavior = false;
            this.lvStudents.View = System.Windows.Forms.View.List;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTeachers);
            this.groupBox1.Controls.Add(this.dgvTeacherStudents);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 256);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvStudents);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 256);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Students";
            // 
            // ManageStudentAndTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 323);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Name = "ManageStudentAndTeacherForm";
            this.Text = "ManageStudentAndTeacherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherStudents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeachers;
        private System.Windows.Forms.DataGridView dgvTeacherStudents;
        private System.Windows.Forms.ListView lvStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}