using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Mini_Shazam
{
    public partial class databasePage : UserControl
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        private string path;
        public databasePage()
        {
            InitializeComponent();
        }
        void TrackListele()
        {
            baglanti = new SqlConnection("server=reha_karakas;Initial Catalog=FingerprintsDb;Integrated Security=SSPI;TrustServerCertificate=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM Tracks", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgvTrackList.DataSource = tablo;
            baglanti.Close();
        }
        private void databasePage_Load(object sender, EventArgs e)
        {
            TrackListele();
        }

        private void dgvTrackList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvTrackList.CurrentRow.Cells[0].Value.ToString();
            txtISRC.Text = dgvTrackList.CurrentRow.Cells[1].Value.ToString();
            txtArtist.Text = dgvTrackList.CurrentRow.Cells[2].Value.ToString();
            txtTitle.Text = dgvTrackList.CurrentRow.Cells[3].Value.ToString();
            txtAlbum.Text = dgvTrackList.CurrentRow.Cells[4].Value.ToString();
            txtReleaseYear.Text = dgvTrackList.CurrentRow.Cells[5].Value.ToString();
            txtLength.Text = dgvTrackList.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FingerprintService fingerprintService = new FingerprintService();
            fingerprintService.StoreAudioFileFingerprintsInStorageForLaterRetrieval(path,
               txtISRC.Text,
               txtArtist.Text,
               txtTitle.Text,
               txtAlbum.Text,
               int.Parse(txtReleaseYear.Text),
               int.Parse(txtLength.Text));
            MessageBox.Show("Song added!");
            TrackListele();

        }


        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Audio Files|*.mp3;*.wav;*.flac;*.aac";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    path = open.FileName; // tam yolu göster
                    lblFileName.Text = Path.GetFileName(open.FileName);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = " DELETE FROM SubFingerprints WHERE TrackId=@ID;\r\n    DELETE FROM Tracks WHERE Id=@ID;";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", txtID.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TrackListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Tracks SET ISRC=@ISRC,Artist=@Artist,Title=@Title,Album=@Album,ReleaseYear=@ReleaseYear,Length=@Length WHERE Id=@ID";
            komut= new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@ID", txtID.Text);
            komut.Parameters.AddWithValue("@ISRC", txtISRC.Text);
            komut.Parameters.AddWithValue("@Artist", txtArtist.Text);
            komut.Parameters.AddWithValue("@Title", txtTitle.Text);
            komut.Parameters.AddWithValue("@Album", txtAlbum.Text);
            komut.Parameters.AddWithValue("@ReleaseYear", txtReleaseYear.Text);
            komut.Parameters.AddWithValue("@Length", txtLength.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TrackListele();
        }
    }
}
