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
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using Lib;
using System.Runtime.Serialization;

namespace HeroWarsGame
{
    public partial class StartMenu : Form
    {
        public static List<Battlelogs> Logs = new List<Battlelogs>();

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
            File.Delete(@"D:\\HeroWarsSaves.txt");
            save.QuitGame();
            Application.Exit();
        }

        private void SM_Instr_Click(object sender, EventArgs e)
        {
            Instructions instr = new Instructions();
            instr.ShowDialog();
        }
        private void BattleLogs_Click(object sender, EventArgs e)
        {
            bool isEmpty = true;

                IFormatter binFormatter = new BinaryFormatter();
            using (Stream stream = File.Open(@"D:\\BattleLogs.db", FileMode.Open))
            {
                if (stream.Length != 0)
                {
                    Logs.Clear();
                    ((List<Battlelogs>)binFormatter.Deserialize(stream)).ForEach((battlelog)=> {
                        Logs.Add(battlelog);   
                    });

                    isEmpty = false;
                }
            }
            if (!isEmpty)
            {
                BattleLogs battleLogs = new BattleLogs();
                battleLogs.ShowDialog();
            }
            else
            MessageBox.Show("Log history is empty!");
        }
    }
}
