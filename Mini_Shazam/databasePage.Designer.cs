namespace Mini_Shazam
{
    partial class databasePage
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
            lblID = new Label();
            lblISRC = new Label();
            lblArtist = new Label();
            lblTitle = new Label();
            lblAlbum = new Label();
            lblReleaseYear = new Label();
            txtID = new TextBox();
            txtISRC = new TextBox();
            txtArtist = new TextBox();
            txtTitle = new TextBox();
            txtAlbum = new TextBox();
            txtReleaseYear = new TextBox();
            txtLength = new TextBox();
            lblLength = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvTrackList = new DataGridView();
            lblTrackList = new Label();
            btnDosyaSec = new Button();
            lblFileName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTrackList).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(130, 39);
            lblID.Name = "lblID";
            lblID.Size = new Size(31, 28);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblISRC
            // 
            lblISRC.AutoSize = true;
            lblISRC.BackColor = Color.Transparent;
            lblISRC.Font = new Font("Segoe UI", 12F);
            lblISRC.Location = new Point(109, 87);
            lblISRC.Name = "lblISRC";
            lblISRC.Size = new Size(52, 28);
            lblISRC.TabIndex = 1;
            lblISRC.Text = "ISRC";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.BackColor = Color.Transparent;
            lblArtist.Font = new Font("Segoe UI", 12F);
            lblArtist.Location = new Point(102, 131);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(59, 28);
            lblArtist.TabIndex = 2;
            lblArtist.Text = "Artist";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 12F);
            lblTitle.Location = new Point(112, 178);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 28);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblAlbum
            // 
            lblAlbum.AutoSize = true;
            lblAlbum.BackColor = Color.Transparent;
            lblAlbum.Font = new Font("Segoe UI", 12F);
            lblAlbum.Location = new Point(94, 221);
            lblAlbum.Name = "lblAlbum";
            lblAlbum.Size = new Size(70, 28);
            lblAlbum.TabIndex = 4;
            lblAlbum.Text = "Album";
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.BackColor = Color.Transparent;
            lblReleaseYear.Font = new Font("Segoe UI", 12F);
            lblReleaseYear.Location = new Point(47, 268);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(117, 28);
            lblReleaseYear.TabIndex = 5;
            lblReleaseYear.Text = "Release Year";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(182, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(241, 34);
            txtID.TabIndex = 6;
            // 
            // txtISRC
            // 
            txtISRC.Font = new Font("Segoe UI", 12F);
            txtISRC.Location = new Point(182, 81);
            txtISRC.Name = "txtISRC";
            txtISRC.Size = new Size(241, 34);
            txtISRC.TabIndex = 7;
            // 
            // txtArtist
            // 
            txtArtist.Font = new Font("Segoe UI", 12F);
            txtArtist.Location = new Point(182, 131);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(241, 34);
            txtArtist.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.Location = new Point(182, 175);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(241, 34);
            txtTitle.TabIndex = 9;
            // 
            // txtAlbum
            // 
            txtAlbum.Font = new Font("Segoe UI", 12F);
            txtAlbum.Location = new Point(182, 221);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(241, 34);
            txtAlbum.TabIndex = 10;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Font = new Font("Segoe UI", 12F);
            txtReleaseYear.Location = new Point(182, 265);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(241, 34);
            txtReleaseYear.TabIndex = 11;
            // 
            // txtLength
            // 
            txtLength.Font = new Font("Segoe UI", 12F);
            txtLength.Location = new Point(182, 311);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(241, 34);
            txtLength.TabIndex = 12;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.BackColor = Color.Transparent;
            lblLength.Font = new Font("Segoe UI", 12F);
            lblLength.Location = new Point(89, 314);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(72, 28);
            lblLength.TabIndex = 13;
            lblLength.Text = "Length";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(582, 168);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(113, 61);
            btnEkle.TabIndex = 14;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(582, 245);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(113, 61);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(582, 321);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(113, 61);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dgvTrackList
            // 
            dgvTrackList.AllowUserToAddRows = false;
            dgvTrackList.AllowUserToDeleteRows = false;
            dgvTrackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrackList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrackList.Location = new Point(32, 436);
            dgvTrackList.Name = "dgvTrackList";
            dgvTrackList.ReadOnly = true;
            dgvTrackList.RowHeadersWidth = 51;
            dgvTrackList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrackList.Size = new Size(972, 286);
            dgvTrackList.TabIndex = 17;
            dgvTrackList.CellEnter += dgvTrackList_CellEnter;
            // 
            // lblTrackList
            // 
            lblTrackList.AutoSize = true;
            lblTrackList.BackColor = Color.Transparent;
            lblTrackList.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTrackList.Location = new Point(31, 395);
            lblTrackList.Name = "lblTrackList";
            lblTrackList.Size = new Size(130, 38);
            lblTrackList.TabIndex = 18;
            lblTrackList.Text = "Track List";
            // 
            // btnDosyaSec
            // 
            btnDosyaSec.Location = new Point(582, 39);
            btnDosyaSec.Name = "btnDosyaSec";
            btnDosyaSec.Size = new Size(113, 61);
            btnDosyaSec.TabIndex = 19;
            btnDosyaSec.Text = "Dosya Seç";
            btnDosyaSec.UseVisualStyleBackColor = true;
            btnDosyaSec.Click += btnDosyaSec_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.BackColor = Color.Transparent;
            lblFileName.Location = new Point(582, 125);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(129, 20);
            lblFileName.TabIndex = 20;
            lblFileName.Text = "Dosya Seçili Değil";
            // 
            // databasePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources._4890914;
            Controls.Add(lblFileName);
            Controls.Add(btnDosyaSec);
            Controls.Add(lblTrackList);
            Controls.Add(dgvTrackList);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(lblLength);
            Controls.Add(txtLength);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtAlbum);
            Controls.Add(txtTitle);
            Controls.Add(txtArtist);
            Controls.Add(txtISRC);
            Controls.Add(txtID);
            Controls.Add(lblReleaseYear);
            Controls.Add(lblAlbum);
            Controls.Add(lblTitle);
            Controls.Add(lblArtist);
            Controls.Add(lblISRC);
            Controls.Add(lblID);
            Name = "databasePage";
            Size = new Size(1021, 735);
            Load += databasePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrackList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblISRC;
        private Label lblArtist;
        private Label lblTitle;
        private Label lblAlbum;
        private Label lblReleaseYear;
        private TextBox txtID;
        private TextBox txtISRC;
        private TextBox txtArtist;
        private TextBox txtTitle;
        private TextBox txtAlbum;
        private TextBox txtReleaseYear;
        private TextBox txtLength;
        private Label lblLength;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvTrackList;
        private Label lblTrackList;
        private Button btnDosyaSec;
        private Label lblFileName;
    }
}
