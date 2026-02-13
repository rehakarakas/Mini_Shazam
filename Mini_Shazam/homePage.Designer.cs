namespace Mini_Shazam
{
    partial class homePage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDinle = new Button();
            lblDurum = new Label();
            picWave = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picWave).BeginInit();
            SuspendLayout();
            // 
            // btnDinle
            // 
            btnDinle.Location = new Point(396, 359);
            btnDinle.Name = "btnDinle";
            btnDinle.Size = new Size(107, 52);
            btnDinle.TabIndex = 1;
            btnDinle.Text = "Dinle";
            btnDinle.UseVisualStyleBackColor = true;
            btnDinle.Click += btnDinle_Click;
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.BackColor = Color.Transparent;
            lblDurum.Location = new Point(392, 440);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(111, 20);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "Mikrofon Hazır.";
            // 
            // picWave
            // 
            picWave.BackColor = Color.Transparent;
            picWave.Image = Properties.Resources._07_wave;
            picWave.Location = new Point(320, 133);
            picWave.Name = "picWave";
            picWave.Size = new Size(265, 200);
            picWave.SizeMode = PictureBoxSizeMode.Zoom;
            picWave.TabIndex = 3;
            picWave.TabStop = false;
            picWave.Visible = false;
            // 
            // homePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources._4890914;
            Controls.Add(picWave);
            Controls.Add(lblDurum);
            Controls.Add(btnDinle);
            Name = "homePage";
            Size = new Size(1021, 735);
            ((System.ComponentModel.ISupportInitialize)picWave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDinle;
        private Label lblDurum;
        private PictureBox picWave;
    }
}
