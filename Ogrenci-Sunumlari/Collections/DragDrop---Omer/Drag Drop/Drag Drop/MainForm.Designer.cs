namespace Drag_Drop
{
    partial class FMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.lVTables = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bAdditions = new System.Windows.Forms.Button();
            this.bAddTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lVTables
            // 
            this.lVTables.AllowDrop = true;
            this.lVTables.LargeImageList = this.ımageList1;
            this.lVTables.Location = new System.Drawing.Point(12, 12);
            this.lVTables.Name = "lVTables";
            this.lVTables.Size = new System.Drawing.Size(776, 359);
            this.lVTables.SmallImageList = this.ımageList1;
            this.lVTables.TabIndex = 0;
            this.lVTables.UseCompatibleStateImageBehavior = false;
            this.lVTables.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tables_DragDrop);
            this.lVTables.DragOver += new System.Windows.Forms.DragEventHandler(this.Tables_DragOver);
            this.lVTables.DoubleClick += new System.EventHandler(this.Tables_DoubleClick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "TablePicture.png");
            // 
            // bAdditions
            // 
            this.bAdditions.Location = new System.Drawing.Point(704, 377);
            this.bAdditions.Name = "bAdditions";
            this.bAdditions.Size = new System.Drawing.Size(75, 23);
            this.bAdditions.TabIndex = 1;
            this.bAdditions.Text = "Addition";
            this.bAdditions.UseVisualStyleBackColor = true;
            this.bAdditions.Click += new System.EventHandler(this.Additions_Click);
            // 
            // bAddTable
            // 
            this.bAddTable.Location = new System.Drawing.Point(12, 390);
            this.bAddTable.Name = "bAddTable";
            this.bAddTable.Size = new System.Drawing.Size(75, 23);
            this.bAddTable.TabIndex = 2;
            this.bAddTable.Text = "Add Table";
            this.bAddTable.UseVisualStyleBackColor = true;
            this.bAddTable.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAddTable);
            this.Controls.Add(this.bAdditions);
            this.Controls.Add(this.lVTables);
            this.Name = "FMain";
            this.Text = "Main Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lVTables;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button bAdditions;
        private System.Windows.Forms.Button bAddTable;
    }
}

