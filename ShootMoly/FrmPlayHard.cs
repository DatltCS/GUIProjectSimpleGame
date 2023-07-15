﻿using System;
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
    public partial class FrmPlayHard : Form
    {
        public FrmPlayHard()
        {
            InitializeComponent();
        }
        Random r = new Random();
        int score = 0;
        int totalShots = 0;
        int missShot = 0;

        void ShotSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Application.StartupPath + @"\Hamster-Sound.wav");
            player.Play();
        }
        void Shot()
        {
            score++;
            lbScore.Text = "Điểm = " + score;

            totalShots++;
            lbTotalShot.Text = "Tổng lần đập = " + totalShots;

            ShotSound();
        }

        void Reset()
        {
            score = 0;
            missShot = 0;
            totalShots = 0;
            lbScore.Text = "Điểm = " + score;
            lbTotalShot.Text = "Tổng lần đập = " + totalShots;
            lbMiss.Text = "Đập hụt = " + missShot;
            timer1.Start();
            lbOver.Text = "";
        }

        void MissShot()
        {
            missShot++;
            lbMiss.Text = "Đập hụt = " + missShot;
            totalShots++;
            lbTotalShot.Text = "Tổng lần đập = " + totalShots;
        }

        private void picHamster_Click_1(object sender, EventArgs e)
        {
            Shot();
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRestart_Click_1(object sender, EventArgs e)
        {
            Reset();
        }

        private void FrmPlayHard_MouseClick(object sender, MouseEventArgs e)
        {
            MissShot();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 1000);
            y = r.Next(300, 500);
            picHamster.Location = new Point(x, y);

            if (missShot >= 10)
            {
                timer1.Stop();
                lbOver.Text = "Game Over";
            }
        }
    }
}
