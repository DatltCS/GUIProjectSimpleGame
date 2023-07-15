namespace ShootMoly
{
    partial class FrmIntructioncs
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbInstruc = new System.Windows.Forms.Label();
            this.lbDetail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShootMoly.Properties.Resources.Hướng_dẫn;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbInstruc
            // 
            this.lbInstruc.BackColor = System.Drawing.Color.Transparent;
            this.lbInstruc.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInstruc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbInstruc.Location = new System.Drawing.Point(601, 295);
            this.lbInstruc.Name = "lbInstruc";
            this.lbInstruc.Size = new System.Drawing.Size(502, 38);
            this.lbInstruc.TabIndex = 1;
            this.lbInstruc.Text = "label1";
            this.lbInstruc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDetail.ForeColor = System.Drawing.Color.Black;
            this.lbDetail.Location = new System.Drawing.Point(550, 359);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(70, 28);
            this.lbDetail.TabIndex = 2;
            this.lbDetail.Text = "label1";
            this.lbDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmIntructioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootMoly.Properties.Resources._121008_moly01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.lbInstruc);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIntructioncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn chơi game";
            this.Load += new System.EventHandler(this.FrmIntructioncs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbInstruc;
        private Label lbDetail;
    }
}