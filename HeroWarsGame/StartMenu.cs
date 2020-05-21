using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeroWarsGame
{
    public partial class StartMenu : Form
    {
        
        private Save save = new Save();
        
        public StartMenu()
        {
            InitializeComponent();

            save.RefreshCharNames();
            

        }

        private void Start_GameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartMenu_CreateCharacter_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterCreator createcharacter = new CharacterCreator();
            createcharacter.ShowDialog();
            this.Close();
        }

        private void StartMenu_StartGame_Click(object sender, EventArgs e)
        {
            string[] file;
            if (File.Exists(@"D:\\HeroWarsSaves.txt"))
            { 
                file = File.ReadAllLines(@"D:\\HeroWarsSaves.txt");

                if (file.Length >= 1)
                {
                    this.Hide();
                    Saves saves = new Saves();
                    saves.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No characters found! Please create a character!");
                    this.Hide();
                    CharacterCreator createcharacter = new CharacterCreator();
                    createcharacter.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No characters found! Please create a character!");
                this.Hide();
                CharacterCreator createcharacter = new CharacterCreator();
                createcharacter.ShowDialog();
                this.Close();
            }
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void StarMenu_Quit_Click(object sender, EventArgs e)
        {  
            save.QuitGame();
            Application.Exit();
        }

        private void SM_Instr_Click(object sender, EventArgs e)
        {
            Instructions instr = new Instructions();
            instr.ShowDialog();
        }
    }
}
