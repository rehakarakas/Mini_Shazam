namespace Mini_Shazam
{
    partial class infoPage
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
            flpFAQ = new FlowLayoutPanel();
            lblBaşlık = new Label();
            SuspendLayout();
            // 
            // flpFAQ
            // 
            flpFAQ.AutoScroll = true;
            flpFAQ.BackColor = Color.Transparent;
            flpFAQ.FlowDirection = FlowDirection.TopDown;
            flpFAQ.Location = new Point(23, 101);
            flpFAQ.Name = "flpFAQ";
            flpFAQ.Size = new Size(976, 619);
            flpFAQ.TabIndex = 0;
            flpFAQ.WrapContents = false;
            // 
            // lblBaşlık
            // 
            lblBaşlık.AutoSize = true;
            lblBaşlık.BackColor = Color.Transparent;
            lblBaşlık.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaşlık.Location = new Point(23, 48);
            lblBaşlık.Name = "lblBaşlık";
            lblBaşlık.Size = new Size(284, 38);
            lblBaşlık.TabIndex = 1;
            lblBaşlık.Text = "Sıkça Sorulan Sorular";
            // 
            // infoPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._4890914;
            Controls.Add(lblBaşlık);
            Controls.Add(flpFAQ);
            Name = "infoPage";
            Size = new Size(1021, 735);
            Resize += infoPage_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpFAQ;
        private Label lblBaşlık;
    }
}
