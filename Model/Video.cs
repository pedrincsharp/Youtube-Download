using YB.DownloadVideos.Utils;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YB.DownloadVideos.Model
{
    internal class VideoYB
    {
        public Video video { get; set; }

        public VideoYB() { }

        public static async Task<VideoYB> GetVideo(string url)
        {
            try
            {
                YoutubeClient cliente = new YoutubeClient();
                Video video = await cliente.Videos.GetAsync(url);
                if (video == null)
                    throw new Exception("Video inválido ou URL informada é inválida!");
                //await SaveVideo(video, savePath, formato);
                return new VideoYB()
                {
                    video = video,
                };
            }
            catch (Exception ex)
            {
                Funcoes.MsgboxError($"Erro ao tentar encontrar o video!\n{ex.Message}");
                return new VideoYB();
            }
        }

        public static async Task<string> SaveVideo(VideoYB videoYB, string path, string formato)
        {
            YoutubeClient cliente = new YoutubeClient();
            StreamManifest streamManifest = await cliente.Videos.Streams.GetManifestAsync(videoYB.video.Url);
            IVideoStreamInfo videoFormat = null;
            IStreamInfo musicFormat = null;
            string caminhoSalvo = string.Empty;

            if (formato == "MP4")
            {
                videoFormat = streamManifest.GetVideoOnlyStreams()
                    .Where(s => s.Container == Container.Mp4)
                    .GetWithHighestVideoQuality();
            }
            else
            {
                musicFormat = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            }


            caminhoSalvo = Path.Combine(path, $"{videoYB.video.Title.Substring(0, 10)}." +
                $"{(videoFormat != null ? videoFormat.Container : musicFormat.Container)}");

            await cliente.Videos.Streams
                .DownloadAsync(videoFormat != null ? videoFormat : musicFormat, caminhoSalvo);
            return caminhoSalvo;
        }

    }
}
