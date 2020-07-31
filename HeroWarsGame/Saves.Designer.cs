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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saves));
            this.SavedCharacterList = new System.Windows.Forms.ListBox();
            this.Saves_Chose = new System.Windows.Forms.Button();
            this.Saves_Delete = new System.Windows.Forms.Button();
            this.Saves_OK = new System.Windows.Forms.Button();
            this.Saves_CreateC = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedCharacterList
            // 
            this.SavedCharacterList.FormattingEnabled = true;
            this.SavedCharacterList.ItemHeight = 16;
            this.SavedCharacterList.Location = new System.Drawing.Point(155, 139);
            this.SavedCharacterList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SavedCharacterList.Name = "SavedCharacterList";
            this.SavedCharacterList.Size = new System.Drawing.Size(345, 212);
            this.SavedCharacterList.TabIndex = 0;
            this.SavedCharacterList.SelectedIndexChanged += new System.EventHandler(this.SavedCharacterList_SelectedIndexChanged);
            // 
            // Saves_Chose
            // 
            this.Saves_Chose.AutoEllipsis = true;
            this.Saves_Chose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Saves_Chose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Saves_Chose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saves_Chose.Image = ((System.Drawing.Image)(resources.GetObject("Saves_Chose.Image")));
            this.Saves_Chose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Saves_Chose.Location = new System.Drawing.Point(509, 288);
            this.Saves_Chose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Saves_Chose.Name = "Saves_Chose";
            this.Saves_Chose.Size = new System.Drawing.Size(100, 28);
            this.Saves_Chose.TabIndex = 1;
            this.Saves_Chose.Text = "Choose";
            this.Saves_Chose.UseVisualStyleBackColor = false;
            this.Saves_Chose.Click += new System.EventHandler(this.Saves_Chose_Click);
            // 
            // Saves_Delete
            // 
            this.Saves_Delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Saves_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Saves_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saves_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Saves_Delete.Image")));
            this.Saves_Delete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Saves_Delete.Location = new System.Drawing.Point(155, 359);
            this.Saves_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Saves_Delete.Name = "Saves_Delete";
            this.Saves_Delete.Size = new System.Drawing.Size(100, 28);
            this.Saves_Delete.TabIndex = 2;
            this.Saves_Delete.Text = "Delete";
            this.Saves_Delete.UseVisualStyleBackColor = false;
            this.Saves_Delete.Click += new System.EventHandler(this.Saves_Delete_Click);
            // 
            // Saves_OK
            // 
            this.Saves_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Saves_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Saves_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saves_OK.Image = ((System.Drawing.Image)(resources.GetObject("Saves_OK.Image")));
            this.Saves_OK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Saves_OK.Location = new System.Drawing.Point(509, 324);
            this.Saves_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Saves_OK.Name = "Saves_OK";
            this.Saves_OK.Size = new System.Drawing.Size(100, 28);
            this.Saves_OK.TabIndex = 3;
            this.Saves_OK.Text = "OK";
            this.Saves_OK.UseVisualStyleBackColor = false;
            this.Saves_OK.Click += new System.EventHandler(this.Saves_OK_Click);
            // 
            // Saves_CreateC
            // 
            this.Saves_CreateC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Saves_CreateC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Saves_CreateC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saves_CreateC.Image = ((System.Drawing.Image)(resources.GetObject("Saves_CreateC.Image")));
            this.Saves_CreateC.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Saves_CreateC.Location = new System.Drawing.Point(352, 359);
            this.Saves_CreateC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Saves_CreateC.Name = "Saves_CreateC";
            this.Saves_CreateC.Size = new System.Drawing.Size(149, 28);
            this.Saves_CreateC.TabIndex = 20;
            this.Saves_CreateC.Text = "Create Character";
            this.Saves_CreateC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Saves_CreateC.UseVisualStyleBackColor = false;
            this.Saves_CreateC.Click += new System.EventHandler(this.Saves_CreateC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Saves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 537);
            this.Controls.Add(this.Saves_CreateC);
            this.Controls.Add(this.Saves_OK);
            this.Controls.Add(this.Saves_Delete);
            this.Controls.Add(this.Saves_Chose);
            this.Controls.Add(this.SavedCharacterList);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Saves";
            this.Text = "Saves";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Saves_FormClosing);
            this.Load += new System.EventHandler(this.Saves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SavedCharacterList;
        private System.Windows.Forms.Button Saves_Chose;
        private System.Windows.Forms.Button Saves_Delete;
        private System.Windows.Forms.Button Saves_OK;
        private System.Windows.Forms.Button Saves_CreateC;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}