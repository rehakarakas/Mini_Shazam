using SoundFingerprinting;
using SoundFingerprinting.Audio;
using SoundFingerprinting.Audio.NAudio;
using SoundFingerprinting.Builder;
using SoundFingerprinting.DAO.Data;
using SoundFingerprinting.SQL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
namespace Mini_Shazam
{
    public class FingerprintService
    {
        private readonly IModelService modelService = new SqlModelService(); // SQL back end
        private readonly IAudioService audioService = new NAudioService(); // use NAudio audio processing library
        private readonly IFingerprintCommandBuilder fingerprintCommandBuilder = new FingerprintCommandBuilder();

        public void StoreAudioFileFingerprintsInStorageForLaterRetrieval(string pathToAudioFile,
                                                                                    string isrc,
                                                                                  string artist,
                                                                                   string title,
                                                                                   string album,
                                                                                int releaseYear,
                                                                                   int length)
        {
            var audioService = new NAudioService();
            var modelService = new SqlModelService();
            var fingerprintCommandBuilder = new FingerprintCommandBuilder();

            var track = new TrackData(isrc, artist, title, album, releaseYear, length);

            var hashedFingerprints = fingerprintCommandBuilder
                                        .BuildFingerprintCommand()
                                        .From(pathToAudioFile)
                                        .UsingServices(audioService)
                                        .Hash()
                                        .Result;

            if (hashedFingerprints.Count == 0)
            {
                MessageBox.Show("Fingerprint üretilemedi!");
                return;
            }

            var trackRef = modelService.InsertTrack(track);
            modelService.InsertHashDataForTrack(hashedFingerprints, trackRef);

            MessageBox.Show($"OK: {hashedFingerprints.Count} fingerprint");
        }
    }
}
