using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace HeroWarsGame
{
    public partial class Battle : Form
    {
        static int PlayerShotSpeed;
        static int PlayerDmg;
        static int PLvl;
        static int PGold;
        static int PWins;
        static string PRace;
        static int MobShotSpeed;
        static int PHealth;
        static int PAddDmg;
        static int MHealth;
        static int MGold;
        static int MDmg;
        static string MRace;
        static string MClass;
        static bool isCharged = true;
        static bool fire = false;
        static bool bomb = false;
        static bool diamond = false;
        static bool coin = false;
        static bool shieldActivated = false;
        static bool usedShield = false;
        static bool usedHeal = false;
        
        Mob mob;

        DateTime time1 = DateTime.Now;
        DateTime startTime = DateTime.Now;
        DateTime timeBonuses = DateTime.Now;

        


        public Battle()
        {
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

            string PictureBox = mob.Race + mob._Class;
            MClass = mob._Class;
            Mob1.Image = (Image)HeroWarsGame.Properties.Resources.ResourceManager.GetObject(PictureBox);

            if (mob._Class == "Gunner")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.bullet21;
            else if (mob._Class == "Archer")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.arrow21;
            else if (mob._Class == "Mage")
                MobShot.BackgroundImage = HeroWarsGame.Properties.Resources.lightning21;

            MobInfo.Text = mob.Race + " " + mob._Class;
        }
        private void PushPlayer(int ShotSpeed)
        {
            PlayerHealth.Text = PHealth.ToString();
            GetHeroInfo();
            PlayerShotSpeed = ShotSpeed;
            
            Save save = new Save();
            string PictureBox = save.GetHeroPictureBox() + "_B";
            Player2.Image = (Image)HeroWarsGame.Properties.Resources.ResourceManager.GetObject(PictureBox);
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
            CallBonuses();

            if (MobShot.Left - MobShot.Width / 2 <= Player2.Left + Player2.Width && (MobShot.Top > Player2.Top && MobShot.Top < Player2.Top + Player2.Height))
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
            else if (MobShot.Left < 0 && (MobShot.Top < Player2.Top || MobShot.Top > Player2.Bottom))
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
        private void CallBonuses()
        {
            DateTime bonusesTime = DateTime.Now;

            if (Math.Abs(bonusesTime.Second - timeBonuses.Second) > 3)
            {
                Random random = new Random();
                int random1 = random.Next(1, 200);
                int x = random.Next(0, 100);
                int y = random.Next(0, panel1.Height);

                if (random1 >= 1 && random1 <= 120)
                {
                    diamond = false;
                    DiamondBox.Visible = false;
                    coin = false;
                    CoinBox.Visible = false;
                    timeBonuses = bonusesTime;
                }
                else if (random1 > 120 && random1 <= 170)
                {
                    Point point = new Point(x, y);
                    CoinBox.Location = point;
                    coin = true;
                    diamond = false;
                    DiamondBox.Visible = false;
                    CoinBox.Visible = true;
                    timeBonuses = bonusesTime;
                }
                else if (random1 > 170 && random1 <= 200)
                {
                    Point point = new Point(x, y);
                    DiamondBox.Location = point;
                    diamond = true;
                    DiamondBox.Visible = true;
                    coin = false;
                    CoinBox.Visible = false;
                    timeBonuses = bonusesTime;
                }
            }
            else if (coin)
            {

                Point upRight = new Point(CoinBox.Location.X + CoinBox.Width, CoinBox.Location.Y);
                Point downRight = new Point(CoinBox.Location.X + CoinBox.Width, CoinBox.Location.Y + CoinBox.Height);
                Point downLeft = new Point(CoinBox.Location.X, CoinBox.Location.Y + CoinBox.Height);

                if (PlayerHits(CoinBox.Location) ||
                    PlayerHits(upRight) ||
                    PlayerHits(downRight) ||
                    PlayerHits(downLeft))
                {
                    PGold += 3;
                    coin = false;
                    CoinBox.Visible = false;
                    startTime = bonusesTime;
                }
            }
            else if (diamond)
            {

                Point upRight = new Point(DiamondBox.Location.X + DiamondBox.Width, DiamondBox.Location.Y);
                Point downRight = new Point(DiamondBox.Location.X + DiamondBox.Width, DiamondBox.Location.Y + DiamondBox.Height);
                Point downLeft = new Point(DiamondBox.Location.X, DiamondBox.Location.Y + DiamondBox.Height);

                if (PlayerHits(DiamondBox.Location) ||
                    PlayerHits(upRight) ||
                    PlayerHits(downRight) ||
                    PlayerHits(downLeft))
                {
                    PGold += 7;
                    diamond = false;
                    DiamondBox.Visible = false;
                    startTime = bonusesTime;
                }
            }
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
            if (pt.X >= Player2.Location.X && pt.X <= Player2.Location.X + Player2.Width && pt.Y >= Player2.Location.Y && pt.Y <= Player2.Location.Y + Player2.Height)
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
            MessageBox.Show("You lost!");

            foreach (var n in Saves.heroes)
            {
                if (Saves.SetHeroName.ToString() == n.Name)
                {
                    n.Enemy = "";
                    break;
                }
            }

            UpdateHeroInfo();
            bool win = false;
            LogBattle(win);

            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();

        }
        public static void LogBattle(bool win)
        {
            Lib.Battlelogs newInfo = new Lib.Battlelogs();
            newInfo.user = LogIn.username;
            newInfo.mob = MRace + " " + MClass;
            newInfo.outcome = "";

            if (win)
                newInfo.outcome = newInfo.user + " vs. " + newInfo.mob + " - " + "Win";
            else
                newInfo.outcome = newInfo.user + " vs. " + newInfo.mob + " - " + "Lost";


            StartMenu.Logs.Add(newInfo);

             IFormatter binFormatter = new BinaryFormatter();
            using (Stream fileStream = File.Open(@"D:\\BattleLogs.db", FileMode.Create))
            {
                binFormatter.Serialize(fileStream, StartMenu.Logs);
            }
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
            bool win = true;
            LogBattle(win);

            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }
        public void Shoot()
        {
            isCharged = false;
            PlayerShot.Top = Player2.Top;
            PlayerShot.Left = Player2.Left + Player2.Width;
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
                if (Player2.Top < 0 || Player2.Top <= 3)
                {
                    Player2.Top = 0;
                }
                else
                {
                    Player2.Top -= 3;
                }
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                if (Player2.Bottom > panel1.Height || Player2.Bottom >= panel1.Height - 3)
                {
                    Player2.Top = panel1.Height - Player2.Height - 3;
                }
                else
                {
                    Player2.Top += 3;
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
                if (Player2.Left >= 100)
                {
                    Player2.Left = 100;
                }
                else
                {
                    Player2.Left += 3;
                }
            }
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                if (Player2.Left <= 8)
                {
                    Player2.Left = 8;
                }
                else
                {
                    Player2.Left -= 3;
                }
            }
            if (shieldActivated)
            {
                BigShield.Top = Player2.Top;
                BigShield.Left = Player2.Left + Player2.Width + 5;

            }
            if (e.KeyChar == '2' && !usedShield)
            {
                if (PGold - 20 >= 0)
                {
                    PGold -= 20;
                    BigShield.Left = Player2.Location.X + Player2.Width + 5;
                    BigShield.Top = Player2.Top;
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
 