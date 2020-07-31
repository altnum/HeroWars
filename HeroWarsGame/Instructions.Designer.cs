namespace HeroWarsGame
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Instr_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Instr_OK
            // 
            this.Instr_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Instr_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Instr_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instr_OK.Image = ((System.Drawing.Image)(resources.GetObject("Instr_OK.Image")));
            this.Instr_OK.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Instr_OK.Location = new System.Drawing.Point(231, 245);
            this.Instr_OK.Name = "Instr_OK";
            this.Instr_OK.Size = new System.Drawing.Size(64, 23);
            this.Instr_OK.TabIndex = 2;
            this.Instr_OK.Text = "OK";
            this.Instr_OK.UseVisualStyleBackColor = false;
            this.Instr_OK.Click += new System.EventHandler(this.Instr_OK_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 272);
            this.Controls.Add(this.Instr_OK);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Instructions";
            this.Text = "Instructions";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Instr_OK;
    }
}