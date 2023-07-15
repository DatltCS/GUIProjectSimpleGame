namespace ShootMoly
{
    partial class FrmLevel
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
            this.btReturn = new System.Windows.Forms.Button();
            this.btEasy = new System.Windows.Forms.Button();
            this.btMedium = new System.Windows.Forms.Button();
            this.btHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.Wheat;
            this.btReturn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReturn.Location = new System.Drawing.Point(894, 529);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(184, 67);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "Quay lại menu";
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btEasy
            // 
            this.btEasy.BackColor = System.Drawing.Color.Wheat;
            this.btEasy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEasy.Location = new System.Drawing.Point(60, 529);
            this.btEasy.Name = "btEasy";
            this.btEasy.Size = new System.Drawing.Size(158, 67);
            this.btEasy.TabIndex = 1;
            this.btEasy.Text = "Dễ";
            this.btEasy.UseVisualStyleBackColor = false;
            this.btEasy.Click += new System.EventHandler(this.btEasy_Click);
            // 
            // btMedium
            // 
            this.btMedium.BackColor = System.Drawing.Color.Wheat;
            this.btMedium.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMedium.Location = new System.Drawing.Point(336, 529);
            this.btMedium.Name = "btMedium";
            this.btMedium.Size = new System.Drawing.Size(158, 67);
            this.btMedium.TabIndex = 2;
            this.btMedium.Text = "Bình Thường";
            this.btMedium.UseVisualStyleBackColor = false;
            this.btMedium.Click += new System.EventHandler(this.btMedium_Click);
            // 
            // btHard
            // 
            this.btHard.BackColor = System.Drawing.Color.Wheat;
            this.btHard.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btHard.Location = new System.Drawing.Point(636, 529);
            this.btHard.Name = "btHard";
            this.btHard.Size = new System.Drawing.Size(158, 67);
            this.btHard.TabIndex = 1;
            this.btHard.Text = "Khó";
            this.btHard.UseVisualStyleBackColor = false;
            this.btHard.Click += new System.EventHandler(this.btHard_Click);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootMoly.Properties.Resources._121008_moly01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 628);
            this.Controls.Add(this.btMedium);
            this.Controls.Add(this.btEasy);
            this.Controls.Add(this.btHard);
            this.Controls.Add(this.btReturn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLevel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btReturn;
        private Button btEasy;
        private Button btMedium;
        private Button btHard;
    }
}