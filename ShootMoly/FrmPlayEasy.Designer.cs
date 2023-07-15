namespace ShootMoly
{
    partial class FrmPlayEasy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayEasy));
            this.picHamster = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTotalShot = new System.Windows.Forms.Label();
            this.lbMiss = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHamster)).BeginInit();
            this.SuspendLayout();
            // 
            // picHamster
            // 
            this.picHamster.BackColor = System.Drawing.Color.Transparent;
            this.picHamster.Image = ((System.Drawing.Image)(resources.GetObject("picHamster.Image")));
            this.picHamster.Location = new System.Drawing.Point(174, 354);
            this.picHamster.Name = "picHamster";
            this.picHamster.Size = new System.Drawing.Size(125, 113);
            this.picHamster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHamster.TabIndex = 0;
            this.picHamster.TabStop = false;
            this.picHamster.Click += new System.EventHandler(this.picHamster_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbScore.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbScore.ForeColor = System.Drawing.Color.Red;
            this.lbScore.Location = new System.Drawing.Point(27, 27);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(196, 54);
            this.lbScore.TabIndex = 1;
            this.lbScore.Text = "Điểm = 0";
            this.lbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalShot
            // 
            this.lbTotalShot.AutoSize = true;
            this.lbTotalShot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTotalShot.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotalShot.ForeColor = System.Drawing.Color.Red;
            this.lbTotalShot.Location = new System.Drawing.Point(27, 81);
            this.lbTotalShot.Name = "lbTotalShot";
            this.lbTotalShot.Size = new System.Drawing.Size(343, 54);
            this.lbTotalShot.TabIndex = 2;
            this.lbTotalShot.Text = "Tổng lần đập = 0";
            this.lbTotalShot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMiss
            // 
            this.lbMiss.AutoSize = true;
            this.lbMiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbMiss.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMiss.ForeColor = System.Drawing.Color.Red;
            this.lbMiss.Location = new System.Drawing.Point(27, 135);
            this.lbMiss.Name = "lbMiss";
            this.lbMiss.Size = new System.Drawing.Size(248, 54);
            this.lbMiss.TabIndex = 3;
            this.lbMiss.Text = "Đập hụt = 0";
            this.lbMiss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExit.ForeColor = System.Drawing.Color.Red;
            this.btExit.Location = new System.Drawing.Point(960, 27);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(158, 54);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btRestart
            // 
            this.btRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btRestart.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRestart.ForeColor = System.Drawing.Color.Red;
            this.btRestart.Location = new System.Drawing.Point(960, 102);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(158, 54);
            this.btRestart.TabIndex = 5;
            this.btRestart.Text = "Chơi lại";
            this.btRestart.UseVisualStyleBackColor = false;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbOver
            // 
            this.lbOver.AutoSize = true;
            this.lbOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbOver.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOver.ForeColor = System.Drawing.Color.Red;
            this.lbOver.Location = new System.Drawing.Point(472, 27);
            this.lbOver.Name = "lbOver";
            this.lbOver.Size = new System.Drawing.Size(0, 54);
            this.lbOver.TabIndex = 6;
            this.lbOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPlayEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootMoly.Properties.Resources.WinXP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.lbOver);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbMiss);
            this.Controls.Add(this.lbTotalShot);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.picHamster);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlayEasy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlayEasy";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmPlayEasy_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.picHamster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picHamster;
        private Label lbScore;
        private Label lbTotalShot;
        private Label lbMiss;
        private Button btExit;
        private Button btRestart;
        private System.Windows.Forms.Timer timer1;
        private Label lbOver;
    }
}