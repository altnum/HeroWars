namespace HeroWarsGame
{
    partial class ClassSpecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassSpecs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClassSpecs_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ClassSpecs_Ok
            // 
            this.ClassSpecs_Ok.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClassSpecs_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSpecs_Ok.Location = new System.Drawing.Point(239, 276);
            this.ClassSpecs_Ok.Name = "ClassSpecs_Ok";
            this.ClassSpecs_Ok.Size = new System.Drawing.Size(66, 25);
            this.ClassSpecs_Ok.TabIndex = 1;
            this.ClassSpecs_Ok.Text = "OK";
            this.ClassSpecs_Ok.UseVisualStyleBackColor = false;
            this.ClassSpecs_Ok.Click += new System.EventHandler(this.ClassSpecs_Ok_Click);
            // 
            // ClassSpecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 302);
            this.Controls.Add(this.ClassSpecs_Ok);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClassSpecs";
            this.Text = "ClassSpecs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClassSpecs_Ok;
    }
}