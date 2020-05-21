namespace HeroWarsGame
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.StartMenu_StartGame = new System.Windows.Forms.Button();
            this.StartMenu_CreateCharacter = new System.Windows.Forms.Button();
            this.StarMenu_Quit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SM_Instr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMenu_StartGame
            // 
            this.StartMenu_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMenu_StartGame.Image = ((System.Drawing.Image)(resources.GetObject("StartMenu_StartGame.Image")));
            this.StartMenu_StartGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartMenu_StartGame.Location = new System.Drawing.Point(317, 293);
            this.StartMenu_StartGame.Name = "StartMenu_StartGame";
            this.StartMenu_StartGame.Size = new System.Drawing.Size(157, 39);
            this.StartMenu_StartGame.TabIndex = 2;
            this.StartMenu_StartGame.Text = "Start Game";
            this.StartMenu_StartGame.UseVisualStyleBackColor = true;
            this.StartMenu_StartGame.Click += new System.EventHandler(this.StartMenu_StartGame_Click);
            // 
            // StartMenu_CreateCharacter
            // 
            this.StartMenu_CreateCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMenu_CreateCharacter.Image = ((System.Drawing.Image)(resources.GetObject("StartMenu_CreateCharacter.Image")));
            this.StartMenu_CreateCharacter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartMenu_CreateCharacter.Location = new System.Drawing.Point(317, 234);
            this.StartMenu_CreateCharacter.Name = "StartMenu_CreateCharacter";
            this.StartMenu_CreateCharacter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartMenu_CreateCharacter.Size = new System.Drawing.Size(157, 39);
            this.StartMenu_CreateCharacter.TabIndex = 1;
            this.StartMenu_CreateCharacter.Text = "Create Character";
            this.StartMenu_CreateCharacter.UseVisualStyleBackColor = true;
            this.StartMenu_CreateCharacter.Click += new System.EventHandler(this.StartMenu_CreateCharacter_Click);
            // 
            // StarMenu_Quit
            // 
            this.StarMenu_Quit.BackColor = System.Drawing.SystemColors.HighlightText;
            this.StarMenu_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarMenu_Quit.Image = ((System.Drawing.Image)(resources.GetObject("StarMenu_Quit.Image")));
            this.StarMenu_Quit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StarMenu_Quit.Location = new System.Drawing.Point(343, 354);
            this.StarMenu_Quit.Name = "StarMenu_Quit";
            this.StarMenu_Quit.Size = new System.Drawing.Size(101, 31);
            this.StarMenu_Quit.TabIndex = 3;
            this.StarMenu_Quit.Text = "Quit";
            this.StarMenu_Quit.UseVisualStyleBackColor = false;
            this.StarMenu_Quit.Click += new System.EventHandler(this.StarMenu_Quit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SM_Instr
            // 
            this.SM_Instr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SM_Instr.Image = ((System.Drawing.Image)(resources.GetObject("SM_Instr.Image")));
            this.SM_Instr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SM_Instr.Location = new System.Drawing.Point(317, 173);
            this.SM_Instr.Name = "SM_Instr";
            this.SM_Instr.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SM_Instr.Size = new System.Drawing.Size(157, 39);
            this.SM_Instr.TabIndex = 13;
            this.SM_Instr.Text = "Instructions";
            this.SM_Instr.UseVisualStyleBackColor = true;
            this.SM_Instr.Click += new System.EventHandler(this.SM_Instr_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.SM_Instr);
            this.Controls.Add(this.StarMenu_Quit);
            this.Controls.Add(this.StartMenu_CreateCharacter);
            this.Controls.Add(this.StartMenu_StartGame);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.Load += new System.EventHandler(this.StartMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartMenu_StartGame;
        private System.Windows.Forms.Button StartMenu_CreateCharacter;
        private System.Windows.Forms.Button StarMenu_Quit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SM_Instr;
    }
}