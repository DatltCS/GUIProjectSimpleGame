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
    public partial class FrmIntructioncs : Form
    {
        public FrmIntructioncs()
        {
            InitializeComponent();
        }

        private void FrmIntructioncs_Load(object sender, EventArgs e)
        {
            lbInstruc.Text = "Hướng dẫn chơi đập chuột";
            lbDetail.Text = "1. Sử dụng chuột để đập các con chuột xuất hiện ngẫu nhiên\n\n"
                + "2. Đập trung chuột sẽ được cộng 1 điểm\n\n"
                + "3. Đập hụt chuột quá 10 lần trò chơi kết thúc";
        }
    }
}
