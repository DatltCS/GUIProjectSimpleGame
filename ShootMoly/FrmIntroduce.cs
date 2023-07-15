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
    public partial class FrmIntroduce : Form
    {
        public FrmIntroduce()
        {
            InitializeComponent();
        }

        private void lbIntroduce_Click(object sender, EventArgs e)
        {

        }

        private void FrmIntroduce_Load(object sender, EventArgs e)
        {
            lbIntroduce.Text = "Giảng viên hướng dẫn: ThS. Nguyễn Thị Huyền Trang\n" 
                + "Sinh viên thực hiện:\n" +"Lương Tấn Đạt - 2051012019\n"
                + "\tTăng Thị Mỹ Liên - 2051010167\n"
                + "\tNguyễn Minh Hoài - 2051012028\n"
                + "Lớp: CS2002";
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }
    }
}
