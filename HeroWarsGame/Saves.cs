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
using System.Linq.Expressions;
using System.CodeDom;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;

namespace HeroWarsGame
{

    public partial class Saves : Form
    {
        public static string SetHeroName = "";
        public static string SetHeroGender = "";
        public static string SetHeroClass = "";
        public static string SetHeroRace = "";
        public static int SetLvl = 0;
        public static int SetGold = 0;
        public static decimal SetDmg = 0;
        private string selectedProfile = "";
        public static int SetHealth = 0;
        public static int SetWins = 0;

        internal static List<Hero> heroes = new List<Hero>();
        public Saves()
        {
            InitializeComponent();

            RefreshCharList();


        }

        public void SavedCharacterList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Saves_Load(object sender, EventArgs e)
        {

        }
        private string GetCharName(string[] Info)
        {
            string characterName = "";
            string FinalName = "";
            for (int i = 0; i < Info.Length; i++)
            {
                if (Info.Length - i > 2)
                    characterName = characterName + Info[i] + " ";
                else
                {
                    for (int j = 0; j < characterName.Length - 1; j++)
                        FinalName += characterName[j];

                    break;
                }
            }
            return FinalName;
        }

        private void RefreshCharList()
        {
            Save save = new Save();

            string filePath = @"D:\\HeroWarsSaves.txt";
            FileStream file = new FileStream(filePath, FileMode.Append);
            file.Dispose();

            SavedCharacterList.Items.Clear();
            heroes.Clear();

            try
            {
                if (new FileInfo(filePath).Length != 0)
                    using (StreamReader heroFile = File.OpenText(@"D:\\HeroWarsSaves.txt"))
                    {

                        while (!heroFile.EndOfStream)
                        {
                            string line = heroFile.ReadLine();
                            string[] info = line.Split(',');
                            SavedCharacterList.Items.Add(info[0] + " lvl: " + info[4]);

                            if (info[3] == "Elf")
                            {
                                Elf elf = new Elf(info[0], info[1], info[2]);

                                elf.Lvl = int.Parse(info[4]);
                                elf.Gold = int.Parse(info[5]);
                                elf.Dmg = int.Parse(info[6]);
                                elf.Wins = int.Parse(info[8]);

                                heroes.Add(elf);
                            }
                            else if (info[3] == "Dwarf")
                            {
                                Dwarf dwarf = new Dwarf(info[0], info[1], info[2]);

                                dwarf.Lvl = int.Parse(info[4]);
                                dwarf.Gold = int.Parse(info[5]);
                                dwarf.Dmg = int.Parse(info[6]);
                                dwarf.Wins = int.Parse(info[8]);

                                heroes.Add(dwarf);
                            }
                            else if (info[3] == "Human")
                            {
                                Human human = new Human(info[0], info[1], info[2]);

                                human.Lvl = int.Parse(info[4]);
                                human.Gold = int.Parse(info[5]);
                                human.Dmg = int.Parse(info[6]);
                                human.Wins = int.Parse(info[8]);

                                heroes.Add(human);
                            }

                        }
                    }
                save.RefreshCharNames();

            }
            catch { }

        }
        private void NoCharacters()
        {
            this.Hide();
            MessageBox.Show("You ran out of characters! Create a new one.");
            CharacterCreator createcharacter = new CharacterCreator();
            createcharacter.ShowDialog();
            this.Close();
        }
        private void Saves_Chose_Click(object sender, EventArgs e)
        {
            try
            {
                if (SavedCharacterList.SelectedItem != null)
                {
                    string[] line = SavedCharacterList.SelectedItem.ToString().Split(' ');
                    string characterName = GetCharName(line);


                    foreach (var n in heroes)
                    {
                        if (characterName == n.Name)
                        {
                            SetHeroName = n.Name;
                            SetHeroGender = n.Gender;
                            SetHeroClass = n._Class;
                            SetHeroRace = n.Race;
                            SetLvl = n.Lvl;
                            SetGold = n.Gold;
                            SetDmg = n.Dmg;
                            SetHealth = n.Health;
                            SetWins = n.Wins;
                            break;
                        }

                    }
                    selectedProfile = SavedCharacterList.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("No character selected!");
                    throw new Exception("No character selected!");
                }


            }
            catch
            {
            }


        }
        public void CurrentCharFile()
        {
            using (FileStream CurHeroFile = new FileStream(@"D:\\CurrentChar.txt", FileMode.Create, FileAccess.ReadWrite))
            {
                byte[] lineBytes = Encoding.UTF8.GetBytes(SetHeroName + "," + SetHeroGender + "," + SetHeroClass + ","
                    + SetHeroRace + "," + SetLvl.ToString() + "," + SetGold.ToString()
                    + "," + SetDmg.ToString() + "," + SetHealth.ToString() + "," + SetWins.ToString());
                CurHeroFile.Write(lineBytes, 0, lineBytes.Length);
            }       
                
        }

        private void Saves_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if(SavedCharacterList.SelectedItem != null)
                if (SavedCharacterList.SelectedItem.ToString() == selectedProfile)
                {
                        CurrentCharFile();

                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.ShowDialog();
                    this.Close();
                }
                else
                    throw new Exception("No character selected!");
                else
                    throw new Exception("No character selected!");
            } 
            catch
            {
                MessageBox.Show("No character selected!");
            }
        }

        private void Saves_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                 DialogResult result = MessageBox.Show("Are you sure?", "", buttons);
                 if (result == DialogResult.Yes)
                 {
                
                    if (SavedCharacterList.SelectedItem != null)
                    {

                        Save save = new Save();
                        string[] line = SavedCharacterList.SelectedItem.ToString().Split(' ');
                        string characterNameToDelete = GetCharName(line);

                        save.DeleteChar(characterNameToDelete);
                        
                        RefreshCharList();
                        

                        if (new FileInfo(@"D:\\HeroWarsSaves.txt").Length == 0)
                            NoCharacters();



                    }
                    else
                    {
                        MessageBox.Show("No character selected!");
                        throw new Exception("No character selected!");

                    }
                
                 }
                 else
                     return;
            }
            catch
            { }
        }

        private void Start_GameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Saves_CreateC_Click(object sender, EventArgs e)
        {
            this.Hide();
            CharacterCreator createcharacter = new CharacterCreator();
            createcharacter.ShowDialog();
            this.Close();
        }
    }
}
