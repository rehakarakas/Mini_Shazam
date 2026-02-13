namespace Mini_Shazam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidePanel = new Panel();
            logo = new PictureBox();
            buttonInfo = new Button();
            buttonDatabase = new Button();
            homeButton = new Button();
            mainPanel = new Panel();
            databasePage1 = new databasePage();
            infoPage2 = new infoPage();
            infoPage1 = new infoPage();
            homePage1 = new homePage();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.Gainsboro;
            sidePanel.Controls.Add(logo);
            sidePanel.Controls.Add(buttonInfo);
            sidePanel.Controls.Add(buttonDatabase);
            sidePanel.Controls.Add(homeButton);
            sidePanel.Location = new Point(0, -1);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(147, 735);
            sidePanel.TabIndex = 0;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(3, 0);
            logo.Name = "logo";
            logo.Size = new Size(144, 132);
            logo.TabIndex = 2;
            logo.TabStop = false;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Gainsboro;
            buttonInfo.Cursor = Cursors.Hand;
            buttonInfo.FlatAppearance.BorderSize = 0;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonInfo.Image = Properties.Resources.info__2_;
            buttonInfo.Location = new Point(-3, 395);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(147, 122);
            buttonInfo.TabIndex = 3;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDatabase
            // 
            buttonDatabase.BackColor = Color.Gainsboro;
            buttonDatabase.Cursor = Cursors.Hand;
            buttonDatabase.FlatAppearance.BorderSize = 0;
            buttonDatabase.FlatStyle = FlatStyle.Flat;
            buttonDatabase.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDatabase.Image = Properties.Resources.data_management__2_;
            buttonDatabase.Location = new Point(3, 267);
            buttonDatabase.Name = "buttonDatabase";
            buttonDatabase.Size = new Size(147, 122);
            buttonDatabase.TabIndex = 4;
            buttonDatabase.UseVisualStyleBackColor = false;
            buttonDatabase.Click += button2_Click;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Gainsboro;
            homeButton.Cursor = Cursors.Hand;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeButton.Image = Properties.Resources.home__2_;
            homeButton.Location = new Point(-3, 138);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(147, 122);
            homeButton.TabIndex = 2;
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImage = Properties.Resources._4890914;
            mainPanel.Controls.Add(databasePage1);
            mainPanel.Controls.Add(infoPage2);
            mainPanel.Controls.Add(infoPage1);
            mainPanel.Controls.Add(homePage1);
            mainPanel.Location = new Point(142, -1);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1021, 735);
            mainPanel.TabIndex = 1;
            // 
            // databasePage1
            // 
            databasePage1.BackgroundImage = (Image)resources.GetObject("databasePage1.BackgroundImage");
            databasePage1.Dock = DockStyle.Fill;
            databasePage1.Location = new Point(0, 0);
            databasePage1.Name = "databasePage1";
            databasePage1.Size = new Size(1021, 735);
            databasePage1.TabIndex = 2;
            // 
            // infoPage2
            // 
            infoPage2.BackgroundImage = (Image)resources.GetObject("infoPage2.BackgroundImage");
            infoPage2.Dock = DockStyle.Fill;
            infoPage2.Location = new Point(0, 0);
            infoPage2.Name = "infoPage2";
            infoPage2.Size = new Size(1021, 735);
            infoPage2.TabIndex = 2;
            // 
            // infoPage1
            // 
            infoPage1.BackgroundImage = (Image)resources.GetObject("infoPage1.BackgroundImage");
            infoPage1.Dock = DockStyle.Fill;
            infoPage1.Location = new Point(0, 0);
            infoPage1.Name = "infoPage1";
            infoPage1.Size = new Size(1021, 735);
            infoPage1.TabIndex = 2;
            // 
            // homePage1
            // 
            homePage1.BackgroundImage = (Image)resources.GetObject("homePage1.BackgroundImage");
            homePage1.Dock = DockStyle.Fill;
            homePage1.Location = new Point(0, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(1021, 735);
            homePage1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1157, 732);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Mini-Shazam";
            Load += MiniShazam_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Button homeButton;
        private Button buttonInfo;
        private Button buttonDatabase;
        private PictureBox logo;
        private Panel mainPanel;
        private infoPage infoPage1;
        private homePage homePage1;
        private infoPage infoPage2;
        private databasePage databasePage1;
    }
}
