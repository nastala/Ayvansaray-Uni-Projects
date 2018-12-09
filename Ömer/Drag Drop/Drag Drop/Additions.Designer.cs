namespace Drag_Drop
{
    partial class Additions
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
            this.lBAdditions = new System.Windows.Forms.ListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBAdditions
            // 
            this.lBAdditions.FormattingEnabled = true;
            this.lBAdditions.Location = new System.Drawing.Point(12, 12);
            this.lBAdditions.Name = "lBAdditions";
            this.lBAdditions.Size = new System.Drawing.Size(155, 264);
            this.lBAdditions.TabIndex = 0;
            this.lBAdditions.DragOver += new System.Windows.Forms.DragEventHandler(this.Additions_DragOver);
            this.lBAdditions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Additions_MouseDown);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(173, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(173, 41);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(75, 23);
            this.bEdit.TabIndex = 2;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(173, 70);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 3;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Additions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 287);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lBAdditions);
            this.Name = "Additions";
            this.Text = "Additions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Additions_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lBAdditions;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
    }
}