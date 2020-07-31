namespace HeroWarsGame
{
    partial class RacePerks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacePerks));
            this.RacePerks_OK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RacePerks_OK
            // 
            this.RacePerks_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RacePerks_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RacePerks_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacePerks_OK.Image = ((System.Drawing.Image)(resources.GetObject("RacePerks_OK.Image")));
            this.RacePerks_OK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RacePerks_OK.Location = new System.Drawing.Point(218, 246);
            this.RacePerks_OK.Name = "RacePerks_OK";
            this.RacePerks_OK.Size = new System.Drawing.Size(75, 23);
            this.RacePerks_OK.TabIndex = 1;
            this.RacePerks_OK.Text = "OK";
            this.RacePerks_OK.UseVisualStyleBackColor = false;
            this.RacePerks_OK.Click += new System.EventHandler(this.RacePerks_OK_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RacePerks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 272);
            this.Controls.Add(this.RacePerks_OK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RacePerks";
            this.Text = "RacePerks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RacePerks_OK;
    }
}