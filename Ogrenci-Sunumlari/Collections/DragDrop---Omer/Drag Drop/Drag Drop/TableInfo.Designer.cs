namespace Drag_Drop
{
    partial class TableInfo
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
            this.lTableName = new System.Windows.Forms.Label();
            this.lBTableAdditions = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lTableName
            // 
            this.lTableName.AutoSize = true;
            this.lTableName.Location = new System.Drawing.Point(56, 9);
            this.lTableName.Name = "lTableName";
            this.lTableName.Size = new System.Drawing.Size(35, 13);
            this.lTableName.TabIndex = 0;
            this.lTableName.Text = "label1";
            // 
            // lBTableAdditions
            // 
            this.lBTableAdditions.FormattingEnabled = true;
            this.lBTableAdditions.Location = new System.Drawing.Point(12, 39);
            this.lBTableAdditions.Name = "lBTableAdditions";
            this.lBTableAdditions.Size = new System.Drawing.Size(120, 134);
            this.lBTableAdditions.TabIndex = 1;
            // 
            // TableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 182);
            this.Controls.Add(this.lBTableAdditions);
            this.Controls.Add(this.lTableName);
            this.Name = "TableInfo";
            this.Text = "TableInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTableName;
        private System.Windows.Forms.ListBox lBTableAdditions;
    }
}