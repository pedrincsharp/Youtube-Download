using System.Net;

namespace YB.DownloadVideos.Utils
{
    internal static class Funcoes
    {
        public static async Task<bool> isConnected(string url = "http://www.google.com")
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(url);
                    responseMessage.EnsureSuccessStatusCode();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MsgboxError(ex.Message);
                return false;
            }
        }

        public static void MsgboxError(string msg)
        {
            MessageBox.Show(msg, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Image SetWebImage(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] imageData = webClient.DownloadData(url);
                Image image = null;

                using (var stream = new System.IO.MemoryStream(imageData))
                {
                    Thread.Sleep(1000);
                    image = Image.FromStream(stream);
                }

                return image;
            }
        }
    }
}
