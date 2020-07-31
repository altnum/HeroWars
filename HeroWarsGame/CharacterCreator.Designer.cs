namespace HeroWarsGame
{
    partial class CharacterCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterCreator));
            this.CC_NameBox = new System.Windows.Forms.TextBox();
            this.CC_RaceList = new System.Windows.Forms.ComboBox();
            this.CC_ClassList = new System.Windows.Forms.ComboBox();
            this.CC_RacePerks = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CC_ClassTxt = new System.Windows.Forms.Label();
            this.CC_RaceTxt = new System.Windows.Forms.Label();
            this.CC_GenderTxt = new System.Windows.Forms.Label();
            this.CC_NameTxt = new System.Windows.Forms.Label();
            this.CC_Female = new System.Windows.Forms.RadioButton();
            this.CC_Male = new System.Windows.Forms.RadioButton();
            this.CC_Create = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CC_ClassSpecs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CC_NameBox
            // 
            this.CC_NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_NameBox.Location = new System.Drawing.Point(320, 186);
            this.CC_NameBox.Name = "CC_NameBox";
            this.CC_NameBox.Size = new System.Drawing.Size(199, 22);
            this.CC_NameBox.TabIndex = 0;
            this.CC_NameBox.TextChanged += new System.EventHandler(this.CC_NameBox_TextChanged);
            // 
            // CC_RaceList
            // 
            this.CC_RaceList.AccessibleDescription = "";
            this.CC_RaceList.AccessibleName = "";
            this.CC_RaceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_RaceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_RaceList.FormattingEnabled = true;
            this.CC_RaceList.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Dwarf"});
            this.CC_RaceList.Location = new System.Drawing.Point(320, 266);
            this.CC_RaceList.Name = "CC_RaceList";
            this.CC_RaceList.Size = new System.Drawing.Size(199, 24);
            this.CC_RaceList.TabIndex = 19;
            // 
            // CC_ClassList
            // 
            this.CC_ClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CC_ClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_ClassList.FormattingEnabled = true;
            this.CC_ClassList.Items.AddRange(new object[] {
            "Archer",
            "Mage",
            "Gunner"});
            this.CC_ClassList.Location = new System.Drawing.Point(320, 316);
            this.CC_ClassList.Name = "CC_ClassList";
            this.CC_ClassList.Size = new System.Drawing.Size(199, 24);
            this.CC_ClassList.TabIndex = 20;
            // 
            // CC_RacePerks
            // 
            this.CC_RacePerks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CC_RacePerks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_RacePerks.Image = ((System.Drawing.Image)(resources.GetObject("CC_RacePerks.Image")));
            this.CC_RacePerks.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_RacePerks.Location = new System.Drawing.Point(525, 264);
            this.CC_RacePerks.Name = "CC_RacePerks";
            this.CC_RacePerks.Size = new System.Drawing.Size(32, 26);
            this.CC_RacePerks.TabIndex = 23;
            this.CC_RacePerks.Text = "?";
            this.CC_RacePerks.UseVisualStyleBackColor = true;
            this.CC_RacePerks.Click += new System.EventHandler(this.CC_RacePerks_Click);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cancel.Location = new System.Drawing.Point(321, 374);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 25);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // CC_ClassTxt
            // 
            this.CC_ClassTxt.AutoSize = true;
            this.CC_ClassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_ClassTxt.Image = ((System.Drawing.Image)(resources.GetObject("CC_ClassTxt.Image")));
            this.CC_ClassTxt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_ClassTxt.Location = new System.Drawing.Point(248, 322);
            this.CC_ClassTxt.Name = "CC_ClassTxt";
            this.CC_ClassTxt.Size = new System.Drawing.Size(51, 18);
            this.CC_ClassTxt.TabIndex = 17;
            this.CC_ClassTxt.Text = "Class";
            // 
            // CC_RaceTxt
            // 
            this.CC_RaceTxt.AutoSize = true;
            this.CC_RaceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_RaceTxt.Image = ((System.Drawing.Image)(resources.GetObject("CC_RaceTxt.Image")));
            this.CC_RaceTxt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_RaceTxt.Location = new System.Drawing.Point(252, 272);
            this.CC_RaceTxt.Name = "CC_RaceTxt";
            this.CC_RaceTxt.Size = new System.Drawing.Size(47, 18);
            this.CC_RaceTxt.TabIndex = 16;
            this.CC_RaceTxt.Text = "Race";
            // 
            // CC_GenderTxt
            // 
            this.CC_GenderTxt.AutoSize = true;
            this.CC_GenderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_GenderTxt.Image = ((System.Drawing.Image)(resources.GetObject("CC_GenderTxt.Image")));
            this.CC_GenderTxt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_GenderTxt.Location = new System.Drawing.Point(236, 230);
            this.CC_GenderTxt.Name = "CC_GenderTxt";
            this.CC_GenderTxt.Size = new System.Drawing.Size(63, 18);
            this.CC_GenderTxt.TabIndex = 15;
            this.CC_GenderTxt.Text = "Gender";
            // 
            // CC_NameTxt
            // 
            this.CC_NameTxt.AutoSize = true;
            this.CC_NameTxt.BackColor = System.Drawing.Color.White;
            this.CC_NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_NameTxt.Image = ((System.Drawing.Image)(resources.GetObject("CC_NameTxt.Image")));
            this.CC_NameTxt.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_NameTxt.Location = new System.Drawing.Point(247, 190);
            this.CC_NameTxt.Name = "CC_NameTxt";
            this.CC_NameTxt.Size = new System.Drawing.Size(52, 18);
            this.CC_NameTxt.TabIndex = 14;
            this.CC_NameTxt.Text = "Name";
            // 
            // CC_Female
            // 
            this.CC_Female.AutoSize = true;
            this.CC_Female.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CC_Female.BackgroundImage")));
            this.CC_Female.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CC_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_Female.Location = new System.Drawing.Point(424, 230);
            this.CC_Female.Name = "CC_Female";
            this.CC_Female.Size = new System.Drawing.Size(75, 22);
            this.CC_Female.TabIndex = 8;
            this.CC_Female.TabStop = true;
            this.CC_Female.Text = "Female";
            this.CC_Female.UseVisualStyleBackColor = true;
            // 
            // CC_Male
            // 
            this.CC_Male.AutoSize = true;
            this.CC_Male.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CC_Male.BackgroundImage")));
            this.CC_Male.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CC_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_Male.Location = new System.Drawing.Point(348, 230);
            this.CC_Male.Name = "CC_Male";
            this.CC_Male.Size = new System.Drawing.Size(58, 22);
            this.CC_Male.TabIndex = 7;
            this.CC_Male.TabStop = true;
            this.CC_Male.Text = "Male";
            this.CC_Male.UseVisualStyleBackColor = true;
            // 
            // CC_Create
            // 
            this.CC_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CC_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_Create.Image = ((System.Drawing.Image)(resources.GetObject("CC_Create.Image")));
            this.CC_Create.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_Create.Location = new System.Drawing.Point(434, 374);
            this.CC_Create.Name = "CC_Create";
            this.CC_Create.Size = new System.Drawing.Size(85, 25);
            this.CC_Create.TabIndex = 2;
            this.CC_Create.Text = "Create";
            this.CC_Create.UseVisualStyleBackColor = true;
            this.CC_Create.Click += new System.EventHandler(this.CC_Create_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // CC_ClassSpecs
            // 
            this.CC_ClassSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CC_ClassSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_ClassSpecs.Image = ((System.Drawing.Image)(resources.GetObject("CC_ClassSpecs.Image")));
            this.CC_ClassSpecs.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CC_ClassSpecs.Location = new System.Drawing.Point(525, 313);
            this.CC_ClassSpecs.Name = "CC_ClassSpecs";
            this.CC_ClassSpecs.Size = new System.Drawing.Size(32, 26);
            this.CC_ClassSpecs.TabIndex = 24;
            this.CC_ClassSpecs.Text = "?";
            this.CC_ClassSpecs.UseVisualStyleBackColor = true;
            this.CC_ClassSpecs.Click += new System.EventHandler(this.CC_ClassSpecs_Click);
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.CC_ClassSpecs);
            this.Controls.Add(this.CC_RacePerks);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.CC_ClassList);
            this.Controls.Add(this.CC_RaceList);
            this.Controls.Add(this.CC_ClassTxt);
            this.Controls.Add(this.CC_RaceTxt);
            this.Controls.Add(this.CC_GenderTxt);
            this.Controls.Add(this.CC_NameTxt);
            this.Controls.Add(this.CC_Female);
            this.Controls.Add(this.CC_Male);
            this.Controls.Add(this.CC_Create);
            this.Controls.Add(this.CC_NameBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CharacterCreator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CharacterCreator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CC_NameBox;
        private System.Windows.Forms.Button CC_Create;
        private System.Windows.Forms.RadioButton CC_Male;
        private System.Windows.Forms.RadioButton CC_Female;
        private System.Windows.Forms.Label CC_NameTxt;
        private System.Windows.Forms.Label CC_GenderTxt;
        private System.Windows.Forms.Label CC_RaceTxt;
        private System.Windows.Forms.Label CC_ClassTxt;
        private System.Windows.Forms.ComboBox CC_RaceList;
        private System.Windows.Forms.ComboBox CC_ClassList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button CC_RacePerks;
        private System.Windows.Forms.Button CC_ClassSpecs;
    }
}

