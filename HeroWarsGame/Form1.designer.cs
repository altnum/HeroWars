namespace HeroWarsGame
{
    partial class Battle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player1 = new System.Windows.Forms.Panel();
            this.Mob1 = new System.Windows.Forms.Panel();
            this.PlayerHealth = new System.Windows.Forms.Label();
            this.MobHealth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charge = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HealPack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.Label();
            this.GoldAmount = new System.Windows.Forms.Label();
            this.Shield = new System.Windows.Forms.PictureBox();
            this.Heal = new System.Windows.Forms.PictureBox();
            this.BigShield = new System.Windows.Forms.PictureBox();
            this.MobShot = new System.Windows.Forms.Panel();
            this.PlayerShot = new System.Windows.Forms.Panel();
            this.Fire2 = new System.Windows.Forms.PictureBox();
            this.Fire1 = new System.Windows.Forms.PictureBox();
            this.Bomb1 = new System.Windows.Forms.PictureBox();
            this.Bomb2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 42;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BigShield);
            this.panel1.Controls.Add(this.Player1);
            this.panel1.Controls.Add(this.Mob1);
            this.panel1.Controls.Add(this.MobShot);
            this.panel1.Controls.Add(this.PlayerShot);
            this.panel1.Controls.Add(this.Fire2);
            this.panel1.Controls.Add(this.Fire1);
            this.panel1.Controls.Add(this.Bomb1);
            this.panel1.Controls.Add(this.Bomb2);
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 605);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Player1
            // 
            this.Player1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1.BackColor = System.Drawing.Color.Red;
            this.Player1.Location = new System.Drawing.Point(11, 209);
            this.Player1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(39, 62);
            this.Player1.TabIndex = 2;
            // 
            // Mob1
            // 
            this.Mob1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Mob1.BackColor = System.Drawing.Color.YellowGreen;
            this.Mob1.Location = new System.Drawing.Point(851, 209);
            this.Mob1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mob1.Name = "Mob1";
            this.Mob1.Size = new System.Drawing.Size(39, 62);
            this.Mob1.TabIndex = 3;
            // 
            // PlayerHealth
            // 
            this.PlayerHealth.AutoSize = true;
            this.PlayerHealth.Location = new System.Drawing.Point(54, 0);
            this.PlayerHealth.Name = "PlayerHealth";
            this.PlayerHealth.Size = new System.Drawing.Size(46, 17);
            this.PlayerHealth.TabIndex = 1;
            this.PlayerHealth.Text = "label1";
            // 
            // MobHealth
            // 
            this.MobHealth.AutoSize = true;
            this.MobHealth.Location = new System.Drawing.Point(849, 0);
            this.MobHealth.Name = "MobHealth";
            this.MobHealth.Size = new System.Drawing.Size(46, 17);
            this.MobHealth.TabIndex = 4;
            this.MobHealth.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weapon:";
            // 
            // charge
            // 
            this.charge.AutoSize = true;
            this.charge.Location = new System.Drawing.Point(68, 30);
            this.charge.Name = "charge";
            this.charge.Size = new System.Drawing.Size(46, 17);
            this.charge.TabIndex = 7;
            this.charge.Text = "label3";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // HealPack
            // 
            this.HealPack.AutoSize = true;
            this.HealPack.BackColor = System.Drawing.Color.Transparent;
            this.HealPack.Location = new System.Drawing.Point(108, 0);
            this.HealPack.Name = "HealPack";
            this.HealPack.Size = new System.Drawing.Size(30, 17);
            this.HealPack.TabIndex = 9;
            this.HealPack.Text = "\"1\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(183, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "\"2\":";
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.Location = new System.Drawing.Point(-3, 13);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(42, 17);
            this.Gold.TabIndex = 12;
            this.Gold.Text = "Gold:";
            // 
            // GoldAmount
            // 
            this.GoldAmount.AutoSize = true;
            this.GoldAmount.Location = new System.Drawing.Point(45, 13);
            this.GoldAmount.Name = "GoldAmount";
            this.GoldAmount.Size = new System.Drawing.Size(46, 17);
            this.GoldAmount.TabIndex = 13;
            this.GoldAmount.Text = "label4";
            // 
            // Shield
            // 
            this.Shield.Image = ((System.Drawing.Image)(resources.GetObject("Shield.Image")));
            this.Shield.Location = new System.Drawing.Point(219, 0);
            this.Shield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Shield.Name = "Shield";
            this.Shield.Size = new System.Drawing.Size(37, 37);
            this.Shield.TabIndex = 10;
            this.Shield.TabStop = false;
            this.Shield.Click += new System.EventHandler(this.Shield_Click);
            this.Shield.MouseHover += new System.EventHandler(this.Shield_MouseHover);
            // 
            // Heal
            // 
            this.Heal.BackColor = System.Drawing.Color.Transparent;
            this.Heal.Image = ((System.Drawing.Image)(resources.GetObject("Heal.Image")));
            this.Heal.Location = new System.Drawing.Point(144, 0);
            this.Heal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Heal.Name = "Heal";
            this.Heal.Size = new System.Drawing.Size(37, 37);
            this.Heal.TabIndex = 8;
            this.Heal.TabStop = false;
            this.Heal.Click += new System.EventHandler(this.Heal_Click);
            this.Heal.MouseHover += new System.EventHandler(this.Heal_MouseHover);
            // 
            // BigShield
            // 
            this.BigShield.Image = ((System.Drawing.Image)(resources.GetObject("BigShield.Image")));
            this.BigShield.Location = new System.Drawing.Point(61, 316);
            this.BigShield.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BigShield.Name = "BigShield";
            this.BigShield.Size = new System.Drawing.Size(60, 78);
            this.BigShield.TabIndex = 12;
            this.BigShield.TabStop = false;
            this.BigShield.Visible = false;
            // 
            // MobShot
            // 
            this.MobShot.BackColor = System.Drawing.Color.Transparent;
            this.MobShot.BackgroundImage = global::HeroWarsGame.Properties.Resources.arrow21;
            this.MobShot.Location = new System.Drawing.Point(819, 238);
            this.MobShot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MobShot.Name = "MobShot";
            this.MobShot.Size = new System.Drawing.Size(35, 14);
            this.MobShot.TabIndex = 1;
            // 
            // PlayerShot
            // 
            this.PlayerShot.BackColor = System.Drawing.Color.Transparent;
            this.PlayerShot.BackgroundImage = global::HeroWarsGame.Properties.Resources.lightning;
            this.PlayerShot.Location = new System.Drawing.Point(55, 238);
            this.PlayerShot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerShot.Name = "PlayerShot";
            this.PlayerShot.Size = new System.Drawing.Size(35, 14);
            this.PlayerShot.TabIndex = 0;
            this.PlayerShot.Visible = false;
            // 
            // Fire2
            // 
            this.Fire2.BackColor = System.Drawing.Color.Transparent;
            this.Fire2.Image = ((System.Drawing.Image)(resources.GetObject("Fire2.Image")));
            this.Fire2.Location = new System.Drawing.Point(11, 316);
            this.Fire2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fire2.Name = "Fire2";
            this.Fire2.Size = new System.Drawing.Size(45, 46);
            this.Fire2.TabIndex = 10;
            this.Fire2.TabStop = false;
            this.Fire2.Visible = false;
            this.Fire2.Click += new System.EventHandler(this.Fire2_Click);
            // 
            // Fire1
            // 
            this.Fire1.BackColor = System.Drawing.Color.Transparent;
            this.Fire1.Image = ((System.Drawing.Image)(resources.GetObject("Fire1.Image")));
            this.Fire1.Location = new System.Drawing.Point(11, 316);
            this.Fire1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fire1.Name = "Fire1";
            this.Fire1.Size = new System.Drawing.Size(45, 46);
            this.Fire1.TabIndex = 9;
            this.Fire1.TabStop = false;
            this.Fire1.Visible = false;
            // 
            // Bomb1
            // 
            this.Bomb1.BackColor = System.Drawing.Color.Transparent;
            this.Bomb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bomb1.BackgroundImage")));
            this.Bomb1.Location = new System.Drawing.Point(11, 367);
            this.Bomb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bomb1.Name = "Bomb1";
            this.Bomb1.Size = new System.Drawing.Size(51, 50);
            this.Bomb1.TabIndex = 9;
            this.Bomb1.TabStop = false;
            this.Bomb1.Visible = false;
            // 
            // Bomb2
            // 
            this.Bomb2.BackColor = System.Drawing.Color.Transparent;
            this.Bomb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bomb2.BackgroundImage")));
            this.Bomb2.Location = new System.Drawing.Point(11, 367);
            this.Bomb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bomb2.Name = "Bomb2";
            this.Bomb2.Size = new System.Drawing.Size(51, 50);
            this.Bomb2.TabIndex = 11;
            this.Bomb2.TabStop = false;
            this.Bomb2.Visible = false;
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(903, 654);
            this.Controls.Add(this.GoldAmount);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shield);
            this.Controls.Add(this.HealPack);
            this.Controls.Add(this.Heal);
            this.Controls.Add(this.charge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MobHealth);
            this.Controls.Add(this.PlayerHealth);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Battle";
            this.Text = "Battle";
            this.Load += new System.EventHandler(this.Battle_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.w);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bomb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MobShot;
        private System.Windows.Forms.Panel PlayerShot;
        private System.Windows.Forms.Panel Player1;
        private System.Windows.Forms.Panel Mob1;
        private System.Windows.Forms.Label PlayerHealth;
        private System.Windows.Forms.Label MobHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label charge;
        private System.Windows.Forms.PictureBox Heal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Fire2;
        private System.Windows.Forms.PictureBox Fire1;
        private System.Windows.Forms.PictureBox Bomb2;
        private System.Windows.Forms.PictureBox Bomb1;
        private System.Windows.Forms.Label HealPack;
        private System.Windows.Forms.PictureBox Shield;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BigShield;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.Label GoldAmount;
    }
}

