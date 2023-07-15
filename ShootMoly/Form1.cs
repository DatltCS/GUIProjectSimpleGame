namespace ShootMoly
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = lbTitle.Location.X;
            x--;
            lbTitle.Location = new Point(x, lbTitle.Location.Y);

            if (x == 0)
            {
                FrmMain frmMain = new FrmMain();
                x = frmMain.Size.Width;
                lbTitle.Location = new Point(frmMain.Size.Width, lbTitle.Location.Y);
            }
        }

        private void btIntroduce_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmIntroduce frmIntroduce = new FrmIntroduce();
            frmIntroduce.ShowDialog();
            this.Close();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLevel frmLevel = new FrmLevel();
            frmLevel.ShowDialog();
            this.Close();
        }

        private void btInstruction_Click(object sender, EventArgs e)
        {
            FrmIntructioncs frmIntructioncs = new FrmIntructioncs();
            frmIntructioncs.ShowDialog();
        }
    }
}