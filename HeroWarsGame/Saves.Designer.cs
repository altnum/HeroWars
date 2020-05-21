namespace HeroWarsGame
{
    partial class Saves
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
            this.SavedCharacterList = new System.Windows.Forms.ListBox();
            this.Saves_Chose = new System.Windows.Forms.Button();
            this.Saves_Delete = new System.Windows.Forms.Button();
            this.Saves_OK = new System.Windows.Forms.Button();
            this.Start_GameName = new System.Windows.Forms.TextBox();
            this.Saves_CreateC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SavedCharacterList
            // 
            this.SavedCharacterList.FormattingEnabled = true;
            this.SavedCharacterList.Location = new System.Drawing.Point(12, 69);
            this.SavedCharacterList.Name = "SavedCharacterList";
            this.SavedCharacterList.Size = new System.Drawing.Size(260, 173);
            this.SavedCharacterList.TabIndex = 0;
            this.SavedCharacterList.SelectedIndexChanged += new System.EventHandler(this.SavedCharacterList_SelectedIndexChanged);
            // 
            // Saves_Chose
            // 
            this.Saves_Chose.AutoEllipsis = true;
            this.Saves_Chose.Location = new System.Drawing.Point(12, 248);
            this.Saves_Chose.Name = "Saves_Chose";
            this.Saves_Chose.Size = new System.Drawing.Size(75, 23);
            this.Saves_Chose.TabIndex = 1;
            this.Saves_Chose.Text = "Choose";
            this.Saves_Chose.UseVisualStyleBackColor = true;
            this.Saves_Chose.Click += new System.EventHandler(this.Saves_Chose_Click);
            // 
            // Saves_Delete
            // 
            this.Saves_Delete.Location = new System.Drawing.Point(93, 248);
            this.Saves_Delete.Name = "Saves_Delete";
            this.Saves_Delete.Size = new System.Drawing.Size(75, 23);
            this.Saves_Delete.TabIndex = 2;
            this.Saves_Delete.Text = "Delete";
            this.Saves_Delete.UseVisualStyleBackColor = true;
            this.Saves_Delete.Click += new System.EventHandler(this.Saves_Delete_Click);
            // 
            // Saves_OK
            // 
            this.Saves_OK.Location = new System.Drawing.Point(197, 277);
            this.Saves_OK.Name = "Saves_OK";
            this.Saves_OK.Size = new System.Drawing.Size(75, 23);
            this.Saves_OK.TabIndex = 3;
            this.Saves_OK.Text = "OK";
            this.Saves_OK.UseVisualStyleBackColor = true;
            this.Saves_OK.Click += new System.EventHandler(this.Saves_OK_Click);
            // 
            // Start_GameName
            // 
            this.Start_GameName.AccessibleName = "False";
            this.Start_GameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Start_GameName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Start_GameName.Font = new System.Drawing.Font("Mistral", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_GameName.Location = new System.Drawing.Point(75, 23);
            this.Start_GameName.Multiline = true;
            this.Start_GameName.Name = "Start_GameName";
            this.Start_GameName.ReadOnly = true;
            this.Start_GameName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Start_GameName.Size = new System.Drawing.Size(126, 40);
            this.Start_GameName.TabIndex = 19;
            this.Start_GameName.Text = "HeroWars";
            this.Start_GameName.TextChanged += new System.EventHandler(this.Start_GameName_TextChanged);
            // 
            // Saves_CreateC
            // 
            this.Saves_CreateC.Location = new System.Drawing.Point(30, 277);
            this.Saves_CreateC.Name = "Saves_CreateC";
            this.Saves_CreateC.Size = new System.Drawing.Size(120, 21);
            this.Saves_CreateC.TabIndex = 20;
            this.Saves_CreateC.Text = "Create Character";
            this.Saves_CreateC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Saves_CreateC.UseVisualStyleBackColor = true;
            this.Saves_CreateC.Click += new System.EventHandler(this.Saves_CreateC_Click);
            // 
            // Saves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 312);
            this.Controls.Add(this.Saves_CreateC);
            this.Controls.Add(this.Start_GameName);
            this.Controls.Add(this.Saves_OK);
            this.Controls.Add(this.Saves_Delete);
            this.Controls.Add(this.Saves_Chose);
            this.Controls.Add(this.SavedCharacterList);
            this.Name = "Saves";
            this.Text = "Saves";
            this.Load += new System.EventHandler(this.Saves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SavedCharacterList;
        private System.Windows.Forms.Button Saves_Chose;
        private System.Windows.Forms.Button Saves_Delete;
        private System.Windows.Forms.Button Saves_OK;
        private System.Windows.Forms.TextBox Start_GameName;
        private System.Windows.Forms.Button Saves_CreateC;
    }
}