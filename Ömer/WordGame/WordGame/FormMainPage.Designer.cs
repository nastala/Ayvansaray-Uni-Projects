namespace WordGame
{
    partial class FormMainPage
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
            this.bNewGame = new System.Windows.Forms.Button();
            this.lBFoundNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bNewGame
            // 
            this.bNewGame.Location = new System.Drawing.Point(12, 12);
            this.bNewGame.Name = "bNewGame";
            this.bNewGame.Size = new System.Drawing.Size(158, 23);
            this.bNewGame.TabIndex = 0;
            this.bNewGame.Text = "New Game";
            this.bNewGame.UseVisualStyleBackColor = true;
            this.bNewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // lBFoundNames
            // 
            this.lBFoundNames.FormattingEnabled = true;
            this.lBFoundNames.Location = new System.Drawing.Point(12, 41);
            this.lBFoundNames.Name = "lBFoundNames";
            this.lBFoundNames.Size = new System.Drawing.Size(158, 121);
            this.lBFoundNames.TabIndex = 1;
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 173);
            this.Controls.Add(this.lBFoundNames);
            this.Controls.Add(this.bNewGame);
            this.Name = "FormMainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewGame;
        private System.Windows.Forms.ListBox lBFoundNames;
    }
}

