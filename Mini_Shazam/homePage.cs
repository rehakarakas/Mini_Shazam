using SoundFingerprinting.DAO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mini_Shazam
{
    public partial class homePage : UserControl
    {
        private QueryService _queryService;
        public homePage()
        {
            InitializeComponent();
            // Servisi başlatıyoruz (SQL bağlantısını hazırlar)
            _queryService = new QueryService();
            picWave.Image = Properties.Resources._07_wave;
            picWave.Visible = false;
        }

        private async void btnDinle_Click(object sender, EventArgs e)
        {
            btnDinle.Enabled = false; // Çift tıklamayı önle
            btnDinle.Text = "Dinleniyor...";
            lblDurum.Text = "Lütfen 10 saniye müzik dinletin...";
            picWave.Visible = true;
            picWave.BringToFront();
            try
            {
                // --- AŞAMA 2: KAYIT VE SORGULAMA (ARKA PLAN) ---
                // Bu satır çalıştığında UI donmaz, kullanıcı pencereyi sürükleyebilir.
                // 10 saniye boyunca ses kaydeder ve SQL'de arar.
                TrackData result = await _queryService.ListenAndIdentifyAsync(10);
                if (result != null)
                {
                    // EŞLEŞME BULUNDU!
                    lblDurum.Text = "ŞARKI BULUNDU!";
                    MessageBox.Show($"Buldum!\n\nŞarkı: {result.Title}\nSanatçı: {result.Artist}",
                             "Mini-Shazam", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // EŞLEŞME YOK
                    lblDurum.Text = "Eşleşme Bulunamadı.";
                    MessageBox.Show("Veritabanında bu şarkıya ait kayıt yok veya ses çok gürültülü.",
                                    "Sonuçsuz", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Olası mikrofon hataları veya SQL hataları burada yakalanır
                lblDurum.Text = "Hata Oluştu!";
                MessageBox.Show($"Bir sorun var: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // --- AŞAMA 4: ARAYÜZÜ SIFIRLA ---
                // Ne olursa olsun (hata da olsa) buton tekrar aktif olmalı
                picWave.Visible = false;
                btnDinle.Enabled = true;
                btnDinle.Text = "DİNLE";
            }
        }
    } 
}
