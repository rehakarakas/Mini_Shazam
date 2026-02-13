using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Shazam
{
    public partial class infoPage : UserControl
    {
        public infoPage()
        {
            InitializeComponent();
            CreateFAQItems();
        }
        public class FAQ
        {
            public string Question { get; set; }
            public string Answer { get; set; }
        }
        List<FAQ> faqList = new List<FAQ>
        {
            new FAQ
            {
            Question = "Mini-Shazam Nedir?",
            Answer = "Mini-Shazam, ses sinyallerini FFT (Hızlı Fourier Dönüşümü) algoritmasıyla analiz ederek dijital parmak izlerine (Hash) dönüştüren bir" +
                " .NET masaüstü uygulamasıdır. Dinletilen müziği, yerel MSSQL veritabanında kayıtlı olan parmak izleriyle karşılaştırarak şarkı" +
                " bilgilerini (Sanatçı, Eser Adı) gerçek zamanlı olarak tespit eder."
            },
            new FAQ
            {
            Question = "Uygulama Nasıl Kullanılır?",
            Answer = "Uygulama iki ana modülden oluşur:\r\n   " +
                " 1. Ana Sayfa (Home): 'Dinle' butonuna tıklandığında mikrofon açılır ve ortamdaki ses 10 saniye boyunca analiz edilir. " +
                "Eşleşme varsa sonuç ekrana yansıtılır.\r\n   " +
                " 2. Veritabanı (Database): Bu panelde .wav formatındaki şarkı dosyaları sisteme yüklenir," +
                " parmak izleri oluşturulur ve şarkı bilgileri (Metadata) veritabanına kaydedilir."
            },
            new FAQ
            {
            Question = "Eşleşme Performansı ve Gürültü",
            Answer = "Sistem, sesin frekans düzlemindeki en belirgin noktalarını (Spectral Peaks) kullanarak eşleşme yapar." +
                " Testler kontrollü ortamlarda gerçekleştirilmiştir; bu nedenle stüdyo kaydı kalitesindeki seslerde başarı oranı çok yüksektir." +
                " Yoğun arka plan gürültüsü, parmak izi yoğunluğunu etkileyebileceğinden, mikrofonun ses kaynağına yakın tutulması önerilir."
            },
             new FAQ
            {
            Question = "Hangi Kütüphane ve Sürümler Kullanıldı?",
            Answer = "Projede SoundFingerprinting v5.2.2 kütüphanesi temel alınmıştır. Ses işleme için SoundFingerprinting.Audio.NAudio, veri kalıcılığı için ise" +
                 " SoundFingerprinting.SQL katmanı kullanılmıştır. Ses parmak izi algoritmaları sürümler arası uyumsuzluk (Breaking Changes) gösterdiği için," +
                 " sistemin tüm bileşenleri (Ses Analizi ve Veritabanı) v5.2.2 sürümü üzerinde stabilize edilmiştir."
            },
            new FAQ
            {
            Question = "Hangi Ses Formatı Kullanılmalıdır?",
            Answer = "Sisteme yüklenen dosyalar standart .WAV (PCM) formatında olmalıdır. Algoritma, performans optimizasyonu için bu sesleri " +
                "arka planda 5512 Hz, Mono formatına dönüştürerek işler. Bu nedenle, mikrofon kayıtları da eşleşmenin sağlıklı olması için " +
                "otomatik olarak 5512 Hz örnekleme hızıyla alınmaktadır."
            }
            };
        private void CreateFAQItems()
        {
            flpFAQ.Controls.Clear();

            foreach (var faq in faqList)
            {
                // SORU BUTONU
                Button btnQuestion = new Button();
                btnQuestion.Text = "▶ " + faq.Question;
                btnQuestion.Width = flpFAQ.Width - 25;
                btnQuestion.Height = 45;
                btnQuestion.TextAlign = ContentAlignment.MiddleLeft;
                btnQuestion.FlatStyle = FlatStyle.Flat;
                btnQuestion.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnQuestion.BackColor = Color.White;
                btnQuestion.Cursor = Cursors.Hand;

                // CEVAP PANELİ
                Panel pnlAnswer = new Panel();
                pnlAnswer.Width = btnQuestion.Width;
                pnlAnswer.AutoSize = true;
                pnlAnswer.Visible = false;
                pnlAnswer.Padding = new Padding(10);

                // CEVAP LABEL
                Label lblAnswer = new Label();
                lblAnswer.Text = faq.Answer;
                lblAnswer.AutoSize = true;
                lblAnswer.MaximumSize = new Size(pnlAnswer.Width - 20, 0);
                lblAnswer.Font = new Font("Segoe UI", 9);
                lblAnswer.ForeColor = Color.DimGray;

                pnlAnswer.Controls.Add(lblAnswer);

                // AÇ / KAPA OLAYI
                btnQuestion.Click += (s, e) =>
                {
                    pnlAnswer.Visible = !pnlAnswer.Visible;

                    btnQuestion.Text = pnlAnswer.Visible
                        ? "▼ " + faq.Question
                        : "▶ " + faq.Question;
                };

                // FLP'YE EKLE
                flpFAQ.Controls.Add(btnQuestion);
                flpFAQ.Controls.Add(pnlAnswer);
            }
        }

        private void infoPage_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flpFAQ.Controls)
            {
                c.Width = flpFAQ.Width - 25;
            }
        }
    }
}
