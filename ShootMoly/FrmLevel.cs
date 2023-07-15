using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootMoly
{
    public partial class FrmLevel : Form
    {
        public FrmLevel()
        {
            InitializeComponent();
        }

        private void btEasy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlayEasy frmPlayEasy = new FrmPlayEasy();
            frmPlayEasy.ShowDialog();
            this.Close();
        }

        private void btMedium_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlayMedium frmPlayMedium = new FrmPlayMedium();
            frmPlayMedium.ShowDialog();
            this.Close();
        }

        private void btHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlayHard frmPlayHard = new FrmPlayHard();
            frmPlayHard.ShowDialog();
            this.Close();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            this.Close();
        }
    }
}
