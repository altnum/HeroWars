using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroWarsGame
{
    public partial class BattleLogs : Form
    {
        public BattleLogs()
        {
            InitializeComponent();                

                foreach (var c in StartMenu.Logs)
                {
                string line = c.outcome;
                BattleList.Items.Add(line);
                }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            BattleList.Items.Clear();
            File.Delete(@"D:\\BattleLogs.db");
            StartMenu.Logs.Clear();

        }

        private void BattleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
