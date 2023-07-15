namespace ShootMoly
{
    partial class FrmIntroduce
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
            this.lbIntroduce = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIntroduce
            // 
            this.lbIntroduce.AutoSize = true;
            this.lbIntroduce.BackColor = System.Drawing.Color.Transparent;
            this.lbIntroduce.Font = new System.Drawing.Font("SimSun-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbIntroduce.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbIntroduce.Location = new System.Drawing.Point(208, 244);
            this.lbIntroduce.Name = "lbIntroduce";
            this.lbIntroduce.Size = new System.Drawing.Size(0, 30);
            this.lbIntroduce.TabIndex = 0;
            this.lbIntroduce.Click += new System.EventHandler(this.lbIntroduce_Click);
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.Wheat;
            this.btReturn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReturn.Location = new System.Drawing.Point(930, 535);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(158, 67);
            this.btReturn.TabIndex = 2;
            this.btReturn.Text = "Quay lại";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // FrmIntroduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootMoly.Properties.Resources._121008_moly01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.lbIntroduce);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIntroduce";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giới thiệu";
            this.Load += new System.EventHandler(this.FrmIntroduce_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbIntroduce;
        private Button btReturn;
    }
}