namespace DictionarySamples
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
            this.lbListDictionary = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnBringValue = new System.Windows.Forms.Button();
            this.lbBringValue = new System.Windows.Forms.ListBox();
            this.btnUseKeys = new System.Windows.Forms.Button();
            this.lbUseKeys = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lbRemove = new System.Windows.Forms.ListBox();
            this.cbActivate = new System.Windows.Forms.CheckBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbRemoveKey = new System.Windows.Forms.TextBox();
            this.cbValue = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbListDictionary
            // 
            this.lbListDictionary.FormattingEnabled = true;
            this.lbListDictionary.ItemHeight = 16;
            this.lbListDictionary.Location = new System.Drawing.Point(13, 13);
            this.lbListDictionary.Name = "lbListDictionary";
            this.lbListDictionary.Size = new System.Drawing.Size(142, 308);
            this.lbListDictionary.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(22, 327);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(121, 33);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List Dictionary";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnBringValue
            // 
            this.btnBringValue.Location = new System.Drawing.Point(170, 326);
            this.btnBringValue.Name = "btnBringValue";
            this.btnBringValue.Size = new System.Drawing.Size(121, 34);
            this.btnBringValue.TabIndex = 3;
            this.btnBringValue.Text = "Bring Value";
            this.btnBringValue.UseVisualStyleBackColor = true;
            this.btnBringValue.Click += new System.EventHandler(this.btnBringValue_Click);
            // 
            // lbBringValue
            // 
            this.lbBringValue.FormattingEnabled = true;
            this.lbBringValue.ItemHeight = 16;
            this.lbBringValue.Location = new System.Drawing.Point(161, 12);
            this.lbBringValue.Name = "lbBringValue";
            this.lbBringValue.Size = new System.Drawing.Size(142, 276);
            this.lbBringValue.TabIndex = 2;
            // 
            // btnUseKeys
            // 
            this.btnUseKeys.Location = new System.Drawing.Point(318, 326);
            this.btnUseKeys.Name = "btnUseKeys";
            this.btnUseKeys.Size = new System.Drawing.Size(121, 34);
            this.btnUseKeys.TabIndex = 5;
            this.btnUseKeys.Text = "Use Keys";
            this.btnUseKeys.UseVisualStyleBackColor = true;
            this.btnUseKeys.Click += new System.EventHandler(this.btnUseKeys_Click);
            // 
            // lbUseKeys
            // 
            this.lbUseKeys.FormattingEnabled = true;
            this.lbUseKeys.ItemHeight = 16;
            this.lbUseKeys.Location = new System.Drawing.Point(309, 12);
            this.lbUseKeys.Name = "lbUseKeys";
            this.lbUseKeys.Size = new System.Drawing.Size(142, 308);
            this.lbUseKeys.TabIndex = 4;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(466, 326);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(121, 34);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbRemove
            // 
            this.lbRemove.FormattingEnabled = true;
            this.lbRemove.ItemHeight = 16;
            this.lbRemove.Location = new System.Drawing.Point(457, 12);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(142, 276);
            this.lbRemove.TabIndex = 6;
            // 
            // cbActivate
            // 
            this.cbActivate.AutoSize = true;
            this.cbActivate.Location = new System.Drawing.Point(606, 13);
            this.cbActivate.Name = "cbActivate";
            this.cbActivate.Size = new System.Drawing.Size(152, 21);
            this.cbActivate.TabIndex = 8;
            this.cbActivate.Text = "Activate Sorted List";
            this.cbActivate.UseVisualStyleBackColor = true;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(170, 298);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(121, 22);
            this.tbKey.TabIndex = 9;
            this.tbKey.Text = "Enter Key";
            // 
            // tbRemoveKey
            // 
            this.tbRemoveKey.Location = new System.Drawing.Point(466, 299);
            this.tbRemoveKey.Name = "tbRemoveKey";
            this.tbRemoveKey.Size = new System.Drawing.Size(121, 22);
            this.tbRemoveKey.TabIndex = 10;
            this.tbRemoveKey.Text = "Enter Key";
            // 
            // cbValue
            // 
            this.cbValue.AutoSize = true;
            this.cbValue.Location = new System.Drawing.Point(606, 40);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(123, 21);
            this.cbValue.TabIndex = 11;
            this.cbValue.Text = "Sort By Values";
            this.cbValue.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 393);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.tbRemoveKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.cbActivate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lbRemove);
            this.Controls.Add(this.btnUseKeys);
            this.Controls.Add(this.lbUseKeys);
            this.Controls.Add(this.btnBringValue);
            this.Controls.Add(this.lbBringValue);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lbListDictionary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListDictionary;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnBringValue;
        private System.Windows.Forms.ListBox lbBringValue;
        private System.Windows.Forms.Button btnUseKeys;
        private System.Windows.Forms.ListBox lbUseKeys;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lbRemove;
        private System.Windows.Forms.CheckBox cbActivate;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbRemoveKey;
        private System.Windows.Forms.CheckBox cbValue;
    }
}

