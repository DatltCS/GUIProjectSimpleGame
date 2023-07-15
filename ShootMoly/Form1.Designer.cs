namespace ShootMoly
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btPlay = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btInstruction = new System.Windows.Forms.Button();
            this.btIntroduce = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.Wheat;
            this.btPlay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlay.Location = new System.Drawing.Point(53, 529);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(158, 67);
            this.btPlay.TabIndex = 0;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Wheat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btClose.Location = new System.Drawing.Point(914, 529);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(158, 67);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btInstruction
            // 
            this.btInstruction.BackColor = System.Drawing.Color.Wheat;
            this.btInstruction.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInstruction.Location = new System.Drawing.Point(340, 529);
            this.btInstruction.Name = "btInstruction";
            this.btInstruction.Size = new System.Drawing.Size(158, 67);
            this.btInstruction.TabIndex = 1;
            this.btInstruction.Text = "Hướng dẫn";
            this.btInstruction.UseVisualStyleBackColor = false;
            this.btInstruction.Click += new System.EventHandler(this.btInstruction_Click);
            // 
            // btIntroduce
            // 
            this.btIntroduce.BackColor = System.Drawing.Color.Wheat;
            this.btIntroduce.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btIntroduce.Location = new System.Drawing.Point(627, 529);
            this.btIntroduce.Name = "btIntroduce";
            this.btIntroduce.Size = new System.Drawing.Size(158, 67);
            this.btIntroduce.TabIndex = 2;
            this.btIntroduce.Text = "Giới thiệu";
            this.btIntroduce.UseVisualStyleBackColor = false;
            this.btIntroduce.Click += new System.EventHandler(this.btIntroduce_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbTitle.Location = new System.Drawing.Point(207, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(658, 65);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Chào bạn đến với game đập chuột";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootMoly.Properties.Resources._121008_moly01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btIntroduce);
            this.Controls.Add(this.btInstruction);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPlay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoot Moly";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btPlay;
        private Button btClose;
        private Button btInstruction;
        private Button btIntroduce;
        private Label lbTitle;
        private System.Windows.Forms.Timer timer1;
    }
}