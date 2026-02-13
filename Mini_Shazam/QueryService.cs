using NAudio.Wave;
using SoundFingerprinting;
using SoundFingerprinting.Audio;
using SoundFingerprinting.Audio.NAudio;
using SoundFingerprinting.Builder;
using SoundFingerprinting.DAO.Data;
using SoundFingerprinting.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Shazam
{
    public class QueryService
    {
        private readonly IModelService _modelService;
        private readonly IAudioService _audioService;
        private readonly string _tempFile = "mic_recording.wav"; // Geçici kayıt dosyası

        public QueryService()
        {
            // v5.2.2 sürümünde SQL servisi App.config'deki "FingerprintConnectionString"i okur.
            _modelService = new SqlModelService();
            _audioService = new NAudioService();
        }

        /// <summary>
        /// Mikrofondan belirtilen süre boyunca ses kaydeder ve veritabanında arar.
        /// </summary>
        /// <param name="secondsToRecord">Kaç saniye dinleneceği (Örn: 10)</param>
        /// <returns>Eşleşen Şarkı Bilgisi (Yoksa null döner)</returns>
        public async Task<TrackData> ListenAndIdentifyAsync(int secondsToRecord)
        {
            // 1. ADIM: Mikrofon Kaydı (Task içinde çalıştırarak UI'ı dondurmaz)
            await Task.Run(() => RecordAudio(secondsToRecord));

            // 2. ADIM: Kaydedilen Dosyayı Sorgula
            return await IdentifyTrackFromFileAsync(_tempFile);
        }

        /// <summary>
        /// Kaydedilen WAV dosyasını MSSQL veritabanında sorgular.
        /// </summary>
        private async Task<TrackData> IdentifyTrackFromFileAsync(string filePath)
        {
            // Dosya var mı kontrolü
            if (!File.Exists(filePath)) return null;

            // v5.2.2 Sorgu Mantığı (Async/Await)
            var queryResult = await QueryCommandBuilder.Instance
                                    .BuildQueryCommand()
                                    .From(filePath)
                                    .UsingServices(_modelService, _audioService)
                                    .Query();

            // En iyi eşleşmeyi kontrol et
            if (queryResult.BestMatch != null)
            {
                // Eşleşme bulunduysa Track bilgisini dön
                return queryResult.BestMatch.Track;
            }

            return null; // Eşleşme yok
        }

        /// <summary>
        /// NAudio kullanarak mikrofondan ses kaydeder.
        /// </summary>
        private void RecordAudio(int seconds)
        {
            // Eski kaydı temizle
            if (File.Exists(_tempFile)) File.Delete(_tempFile);

            using (var waveIn = new WaveInEvent())
            {
                // SoundFingerprinting v5 için ideal format: 5512 Hz, 16 bit, Mono
                waveIn.WaveFormat = new WaveFormat(5512, 16, 1);

                using (var writer = new WaveFileWriter(_tempFile, waveIn.WaveFormat))
                {
                    waveIn.DataAvailable += (s, a) =>
                    {
                        writer.Write(a.Buffer, 0, a.BytesRecorded);
                    };

                    waveIn.StartRecording();

                    // Belirtilen süre kadar bekle (Thread.Sleep burada güvenlidir çünkü Task içindeyiz)
                    System.Threading.Thread.Sleep(seconds * 1000);

                    waveIn.StopRecording();
                }
            }
        }

    }
}
