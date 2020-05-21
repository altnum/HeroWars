using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroWarsGame
{
    public partial class Battle : Form
    {
        static int PlayerShotSpeed; // = Hero.AttackSpeed!
        static int PlayerDmg; //= Hero.Dmg
        static int PLvl;
        static int PGold;
        static int PWins;
        static string PRace;
        static int MobShotSpeed;
        static int PHealth;
        static string PEnemy;
        static int PAddDmg;
        static int MHealth;
        static int MGold;
        static int MDmg;
        static string MRace;
        static bool isCharged = true;
        static bool fire = false;
        static bool bomb = false;
        static bool shieldActivated = false;
        static bool usedShield = false;
        static bool usedHeal = false;
        
        Mob mob;

        DateTime time1 = DateTime.Now;
        DateTime startTime = DateTime.Now;

        
        public Battle()
        {
            //BattleEvents Bevents = new BattleEvent();
            //BEvents.GetCharArr(); *Returns Arr to use in battle;
            // string[]...  * Use and update in battle;-> form1
            //...
            // BEvents.UpdateChar(string[]); -> *Makes a CharLine* -> *Vika Update Save.UpdateCurFile(charLine)* -> Save.UpdateSaved();

            InitializeComponent();

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    PLvl = n.Lvl;
                    break;
                }
            }

            CreateChars create = new CreateChars(PushMob);
            create += PushPlayer;
            create.Invoke(12);

            CalculateDmg();

            usedShield = false;
            usedHeal = false;
            //GetHeroInfo
            //../
            // UpdateChanges
            

            timer1.Start();

        }
        private delegate void CreateChars(int Shot);

        private void CalculateDmg()
        {
            mob.Enemy = PRace;
            MDmg = (int)(mob.Dmg) + mob.AdditionalDmg();

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Enemy = MRace;
                    PAddDmg = n.AdditionalDmg();
                    PlayerDmg = (int)(n.Dmg) + PAddDmg;
                    break;
                }
            }
        }
        private void PushMob(int ShotSpeed)
        {
            mob = new Mob(PLvl);
            MRace = mob.Race;
            MHealth = mob.Health;
            MGold = mob.Gold;
            MobHealth.Text = MHealth.ToString();
            ShotSpeed = 12;
            MobShotSpeed = ShotSpeed;

            if (mob._Class == "Gunner")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.bullet21;
            else if (mob._Class == "Mage")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.lightning21;
            else if (mob._Class == "Archer")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.arrow21;
        }
        private void PushPlayer(int ShotSpeed)
        {
            PlayerHealth.Text = PHealth.ToString();
            GetHeroInfo();
            PlayerShotSpeed = ShotSpeed;
        }

        private void GetHeroInfo()
        {
            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    PLvl = n.Lvl;
                    PGold = n.Gold;
                    PHealth = n.Health;
                    PWins = n.Wins;
                    PRace = n.Race;
                    decimal a = n.Dmg;

                    if (n._Class == "Gunner")
                        PlayerShot.BackgroundImage = HeroWarsGame.Properties.Resources.bullet;
                    else if (n._Class == "Mage")
                        PlayerShot.BackgroundImage = HeroWarsGame.Properties.Resources.lightning;
                    else if (n._Class == "Archer")
                        PlayerShot.BackgroundImage = HeroWarsGame.Properties.Resources.arrow;

                    break;
                }

            }
        }
        private void UpdateHeroInfo()
        {
            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Lvl = PLvl;
                    n.Dmg = PlayerDmg - PAddDmg;
                    n.Gold = PGold;
                    n.Wins = PWins;
                    break;
                }

            }
        }
        private void Battle_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CallTraps();

            if (MobShot.Left - MobShot.Width / 2 <= Player1.Left + Player1.Width && (MobShot.Top > Player1.Top && MobShot.Top < Player1.Top + Player1.Height))
            {
                if (!shieldActivated)
                {
                    PHealth -= MDmg;
                    MobShot.Top = Mob1.Top;
                    MobShot.Left = Mob1.Left;


                    if (PHealth <= 0)
                        Lose();
                }
                else
                {
                    shieldActivated = false;
                    BigShield.Visible = false;

                    MobShot.Top = Mob1.Top;
                    MobShot.Left = Mob1.Left; 
                }
            } 
            else if (MobShot.Left < 0 && (MobShot.Top < Player1.Top || MobShot.Top > Player1.Bottom))
            {
                MobShot.Top = Mob1.Top;
                MobShot.Left = Mob1.Left;
            }
            Invalidate();

            if (isCharged == false)
            {
                if (PlayerShot.Left >= Mob1.Left - PlayerShot.Width && (PlayerShot.Top > Mob1.Top && PlayerShot.Top < Mob1.Top + Mob1.Height))
                {
                    MHealth -= PlayerDmg;
                    PlayerShot.Visible = false;
                    isCharged = true;

                    if (MHealth <= 0)
                    {
                        Win();
                    }
                }
                else if (PlayerShot.Left + PlayerShot.Width > Mob1.Left && (PlayerShot.Top < Mob1.Top || PlayerShot.Top > Mob1.Bottom))
                {
                    isCharged = true;
                    PlayerShot.Visible = false;
                }
            }

            Invalidate();
            Application.DoEvents();

            PlayerHealth.Text = PHealth.ToString();
            MobHealth.Text = MHealth.ToString();
            GoldAmount.Text = PGold.ToString();

            if (isCharged)
                charge.Text = "Ready";
            else
                charge.Text = "Loading...";

            if (!isCharged)
                PlayerShot.Left += PlayerShotSpeed;

            MobShot.Left -= MobShotSpeed;
            MobMovement();
            Invalidate();

            
        }
        private void CallTraps()
        {
            DateTime trapTime = DateTime.Now;

            if (Math.Abs(trapTime.Second - startTime.Second) > 5)
            {
                Random random = new Random();
                int random1 = random.Next(1, 200);
                int x = random.Next(0, 100);
                int y = random.Next(0, panel1.Height);

                if (random1 >= 1 && random1 <= 80)
                {
                    bomb = false;
                    Bomb1.Visible = false;
                    Bomb2.Visible = false;
                    fire = false;
                    Fire1.Visible = false;
                    Fire2.Visible = false;
                    startTime = trapTime;
                }
                else if (random1 > 80 && random1 <= 140)
                {
                    Point point = new Point(x, y);
                    Fire1.Location = point;
                    Fire2.Location = point;
                    fire = true;
                    bomb = false;
                    Bomb1.Visible = false;
                    Bomb2.Visible = false;
                    Fire1.Visible = true;
                    startTime = trapTime;
                }
                else if (random1 > 140 && random1 <= 200)
                {
                    Point point = new Point(x, y);
                    Bomb1.Location = point;
                    Bomb2.Location = point;
                    bomb = true;
                    Bomb1.Visible = true;
                    fire = false;
                    Fire1.Visible = false;
                    Fire2.Visible = false;
                    startTime = trapTime;
                }
            }
            else if (fire)
            {
                FireTrap();

                Point upRight = new Point(Fire1.Location.X + Fire1.Width, Fire1.Location.Y);
                Point downRight = new Point(Fire1.Location.X + Fire1.Width, Fire1.Location.Y + Fire1.Height);
                Point downLeft = new Point(Fire1.Location.X, Fire1.Location.Y + Fire1.Height);

                if (Math.Abs(trapTime.Second - startTime.Second) >= 1 && (PlayerHits(Fire1.Location) ||
                    PlayerHits(upRight) ||
                    PlayerHits(downRight) ||
                    PlayerHits(downLeft)))
                {
                    PHealth -= 5;
                    startTime = trapTime;
                    if (PHealth <= 0)
                        Lose();
                }
            }
            else if (bomb)
            {
                BombTrap();

                Point upRight = new Point(Bomb1.Location.X + Bomb1.Width, Bomb1.Location.Y);
                Point downRight = new Point(Bomb1.Location.X + Bomb1.Width, Bomb1.Location.Y + Bomb1.Height);
                Point downLeft = new Point(Bomb1.Location.X, Bomb1.Location.Y + Bomb1.Height);

                if (PlayerHits(Bomb1.Location) ||
                    PlayerHits(upRight) ||
                    PlayerHits(downRight) ||
                    PlayerHits(downLeft))
                {
                    PHealth -= 15;
                    bomb = false;
                    Bomb1.Visible = false;
                    Bomb2.Visible = false;

                    if (PHealth <= 0)
                        Lose();
                }
            }
        }
        private bool PlayerHits(Point pt)
        {
            if (pt.X >= Player1.Location.X && pt.X <= Player1.Location.X + Player1.Width && pt.Y >= Player1.Location.Y && pt.Y <= Player1.Location.Y + Player1.Height)
            {
                return true;
            }
            return false;
        }
        private void FireTrap()
        {
            if (Fire1.Visible)
            {
                DateTime time2 = DateTime.Now;
                decimal diff = Math.Abs((decimal)time2.Millisecond - (decimal)time1.Millisecond);

                if (diff > 55)
                {
                    Fire1.Visible = false;
                    Fire2.Visible = true;
                    time1 = time2;
                }
            }
            if (!Fire1.Visible)
            {
                DateTime time2 = DateTime.Now;
                decimal diff = Math.Abs((decimal)time2.Millisecond - (decimal)time1.Millisecond);

                if (diff > 55)
                {
                    Fire1.Visible = true;
                    Fire2.Visible = false;
                    time1 = time2;
                }
            }
            Invalidate();
        }
        private void BombTrap()
        {
            if (Bomb1.Visible)
            {
                DateTime time2 = DateTime.Now;
                decimal diff = Math.Abs((decimal)time2.Millisecond - (decimal)time1.Millisecond);

                if (diff > 55)
                {
                    Bomb1.Visible = false;
                    Bomb2.Visible = true;
                    time1 = time2;
                }
            }
            if (!Bomb1.Visible)
            {
                DateTime time2 = DateTime.Now;
                decimal diff = Math.Abs((decimal)time2.Millisecond - (decimal)time1.Millisecond);

                if (diff > 55)
                {
                    Bomb1.Visible = true;
                    Bomb2.Visible = false;
                    time1 = time2;
                }
            }
            Invalidate();
        }
        public void Lose()
        {
            timer1.Stop();
            MessageBox.Show("You loose!");

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Enemy = "";
                    break;
                }
            }

            UpdateHeroInfo();

            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();

        }
        public void Win()
        {
            timer1.Stop();
            MessageBox.Show("You win!");

            PLvl += 1;
            PGold += MGold;
            PWins += 1;

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Enemy = "";
                    break;
                }
            }

            UpdateHeroInfo();

            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }
        public void Shoot()
        {
            isCharged = false;
            PlayerShot.Top = Player1.Top;
            PlayerShot.Left = Player1.Left + Player1.Width;
            Invalidate();
        }
        public void MobMovement()
        {
            Random random1 = new Random();
            int randomPixels = random1.Next(2, 22);
            Random random2 = new Random();
            int randomDirection = random2.Next(1, 6);

            if (randomDirection == 2 || randomDirection == 5)
            {
                if (Mob1.Top < 0 || Mob1.Top <= randomPixels)
                {
                    Mob1.Top = 0;
                }
                else
                {
                    Mob1.Top -= randomPixels;
                }
            }
            else if (randomDirection == 3 || randomDirection == 4)
            {
                if (Mob1.Bottom > panel1.Height || Mob1.Bottom >= panel1.Height - randomPixels)
                {
                    Mob1.Top = panel1.Height - Mob1.Height - randomPixels;
                }
                else
                {
                    Mob1.Top += randomPixels;
                }
            }
            Invalidate();
        }

        private void w(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                if (Player1.Top < 0 || Player1.Top <= 3)
                {
                    Player1.Top = 0;
                }
                else
                {
                    Player1.Top -= 3;
                }
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                if (Player1.Bottom > panel1.Height || Player1.Bottom >= panel1.Height - 3)
                {
                    Player1.Top = panel1.Height - Player1.Height - 3;
                }
                else
                {
                    Player1.Top += 3;
                }
            }
            if (e.KeyChar == ' ')
            {
                PlayerShot.Visible = true;
                if (isCharged)
                {
                    Shoot();
                }
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                if (Player1.Left >= 100)
                {
                    Player1.Left = 100;
                }
                else
                {
                    Player1.Left += 3;
                }
            }
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                if (Player1.Left <= 8)
                {
                    Player1.Left = 8;
                }
                else
                {
                    Player1.Left -= 3;
                }
            }
            if (shieldActivated)
            {
                BigShield.Top = Player1.Top;
                BigShield.Left = Player1.Left + Player1.Width + 5;

            }
            if (e.KeyChar == '2' && !usedShield)
            {
                if (PGold - 20 >= 0)
                {
                    PGold -= 20;
                    BigShield.Left = Player1.Location.X + Player1.Width + 5;
                    BigShield.Top = Player1.Top;
                    shieldActivated = true;
                    BigShield.Visible = true;
                    usedShield = true;
                    Shield.Visible = false;
                    GoldAmount.Text = PGold.ToString();
                }
            }
            if (e.KeyChar == '1' && !usedHeal && ((PGold - 20) >= 0))
            {
                if (PGold - 20 >= 0)
                {
                    PGold -= 20;
                    PHealth += (int)Math.Ceiling(0.2 * (double)PHealth);
                    usedHeal = true;
                    Heal.Visible = false;
                    GoldAmount.Text = PGold.ToString();
                }
            }
            

        }

        private void Heal_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Heal, "Heal Pack: 20 Gold");
        }

        private void Heal_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Fire2_Click(object sender, EventArgs e)
        {

        }

        private void Shield_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(Shield, "1 hit shield: 20 Gold");
        }

        private void Shield_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 