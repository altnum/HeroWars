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
    public partial class ClassSpecs : Form
    {
        public ClassSpecs()
        {
            InitializeComponent();
        }

        private void ClassSpecs_Ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
