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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Sign_Up_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < UsernameBox.Text.Length; i++)
                {
                    if (!((char)UsernameBox.Text[i] >= 65 && (char)UsernameBox.Text[i] <= 90) &&
                        !((char)UsernameBox.Text[i] >= 97 && (char)UsernameBox.Text[i] <= 122))
                    {
                        MessageBox.Show("Your username must not contain special characters!");
                            throw new Exception();
                    }
                }
                
                if (UsernameBox.Text.Length < 2)
                {
                    MessageBox.Show("Please choose a longer username!");
                    throw new Exception();
                }
                if (PasswordBox.Text != RepeatPass.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    throw new Exception();
                }
                if (PasswordBox.Text.Length == 0)
                {
                    MessageBox.Show("Enter a password!");
                    throw new Exception();
                }
                if (LogIn.users.Length != 0)
                    foreach (var c in LogIn.users)
                    {
                        if (c.Name != null && c.Name == UsernameBox.Text)
                        {
                            MessageBox.Show("Username already taken!");
                            throw new Exception();
                        }
                        else
                        {
                            using (FileStream file = new FileStream(@"D:\\Users.txt", FileMode.Append, FileAccess.Write))
                            {
                                StreamWriter sw = new StreamWriter(file);
                                sw.WriteLine(UsernameBox.Text + "|" + PasswordBox.Text + "|Test,Male,Mage,Elf,1,0,3,5,0");
                                sw.Close();
                                sw.Dispose();
                            }
                        }
                    }
                else
                {
                        using (FileStream file = new FileStream(@"D:\\Users.txt", FileMode.Append, FileAccess.Write))
                        {
                            StreamWriter sw = new StreamWriter(file);
                            sw.WriteLine(UsernameBox.Text + "|" + PasswordBox.Text + "|Test,Male,Mage,Elf,1,0,3,5,0");
                            sw.Close();
                            sw.Dispose();
                        }
                }
            } 
            catch
            {

            }
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn login = new LogIn();
            login.ShowDialog();
            this.Close();
        }
    }
}
