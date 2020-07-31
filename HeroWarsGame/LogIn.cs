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
    public partial class LogIn : Form
    {
        internal static Users[] users;
        public int sizeOfTable = 0;
        internal static string username = "";
        public LogIn()
        {
            InitializeComponent();

            var f = File.AppendText(@"D:\\Users.txt");
            f.Close();

            using (StreamReader readNames = File.OpenText(@"D:\\Users.txt"))
            {
                while (!readNames.EndOfStream)
                {
                    string line = readNames.ReadLine();
                    sizeOfTable++;
                }
                users = new Users[sizeOfTable];
            }
            if(sizeOfTable != 0)
            InitializeUsers(sizeOfTable);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sizeOfTable == 0)
                {
                    MessageBox.Show("Please register first!");
                    throw new Exception("No users");
                }
                    
                if (UsernameBox.Text.Length == 0)
                    MessageBox.Show("Enter a username!");
                else if (users.Any(o => o.Name == UsernameBox.Text))
                {
                    string pass = "";
                    string heroes = "";

                    foreach (var c in users)
                    {
                        if (c.Name == UsernameBox.Text)
                        {
                            pass += c.Password;
                            if (c.Heroes != null)
                                heroes += c.Heroes;
                            break;
                        }
                    }
                    if (pass == PasswordBox.Text)
                    {
                        CreateHeroes(heroes);
                        username = UsernameBox.Text;
                        this.Hide();
                        StartMenu startM = new StartMenu();
                        startM.ShowDialog();
                        this.Close();
                    }
                    else if (!(pass == PasswordBox.Text))
                    {
                        MessageBox.Show("Not a valid password!");
                    }
                }
                else if (!users.Any(o => o.Name == UsernameBox.Text))
                {
                    MessageBox.Show("Not a valid username!");
                }
            }
            catch{}
        }
        public static void CreateHeroes(string str)
        {
            string[] arrHeroes = str.Split('/');
            string filePath = @"D:\\HeroWarsSaves.txt";
            File.Delete(filePath);

            using (FileStream file = File.Open(filePath, FileMode.CreateNew, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(file);
                foreach (var c in arrHeroes)
                {
                    string[] heroInfo = c.Split(',');
                    string SaveContents = heroInfo[0] + "," + heroInfo[1] + "," + heroInfo[2] + "," + heroInfo[3] +
                            "," + heroInfo[4] + "," + heroInfo[5] + "," + heroInfo[6] + "," + heroInfo[7] + "," + heroInfo[8];

                    sw.WriteLine(SaveContents);
                }
                sw.Close();
                sw.Dispose();
            }
        }
        public static void InitializeUsers(int sizeOfTable)
        {
           
                using (StreamReader readNames = File.OpenText(@"D:\\Users.txt"))
                {

                    int tILL = users.Length;
                    while (!readNames.EndOfStream)
                    {
                        string line = readNames.ReadLine();
                        string[] info = line.Split('|');

                        string username = info[0];
                        string password = info[1];
                        string heroes;
                    if (info[2] == "")
                         heroes = "Test,Male,Mage,Elf,1,0,3,5,0";
                    else
                         heroes = info[2];

                        if (users.Any(o => o == null) && users.Any(o => o != null))
                        {
                            var noNulls = users.Skip(tILL).ToArray();
                            users = noNulls;
                            var Idi = users.SkipWhile(o => o.Name == null).Max(o => o.Id);


                            var newPeople = new Users[]
                            {
                new Users{ Id = Idi + 1, Name = username, Password = password, Heroes = heroes }
                            };

                            users = users.Concat(newPeople).ToArray();

                        }
                        else if (users.Any(o => o == null))
                        {
                            var newPeople = new Users[]
                            {
                new Users{ Id = 1, Name = username, Password = password, Heroes = heroes }
                            };

                            users = users.Concat(newPeople).ToArray();
                        }
                        else if (users.Any(o => o != null))
                        {
                            var Idi = users.Max(o => o.Id);

                            var newPeople = new Users[]
                            {
                new Users{ Id = Idi + 1, Name = username, Password = password, Heroes = heroes }
                            };

                            users = users.Concat(newPeople).ToArray();
                        }
                    }
                }
                if (sizeOfTable == 1)
                {
                    var noNulls = users.Skip(1).ToArray();
                    users = noNulls;
                }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.ShowDialog();
            this.Close();
        }
    }
}
