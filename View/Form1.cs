using YB.DownloadVideos.Model;
using YB.DownloadVideos.Utils;

namespace YB.DownloadVideos
{
    public partial class Form1 : Form
    {
        public static Color SemInternet = Color.Red;
        public static Color ComInternet = Color.Green;

        private VideoYB videoYB = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            status.BackColor = await Internet();
        }

        private async Task<Color> Internet()
        {
            return await Funcoes.isConnected() ? ComInternet : SemInternet;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("Necessário informar uma url!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            videoYB = await VideoYB.GetVideo(txtPesquisa.Text);
            HabilitarControle(videoYB);
        }

        private void HabilitarControle(VideoYB videoYB)
        {
            if (videoYB == null || string.IsNullOrEmpty(videoYB.video.Url))
            {
                txtTitulo.Text = "";
                txtDescricao.Text = "";
                cmbFormato.SelectedIndex = 0;
                thumb.Image = null;
                groupBox1.Enabled = false;
                txtPesquisa.Text = "";
                txtDir.Text = "";
                return;
            }
            groupBox1.Enabled = true;
            txtTitulo.Text = videoYB.video.Title;
            txtDescricao.Text = videoYB.video.Description;
            cmbFormato.SelectedIndex = 0;
            thumb.Image = Funcoes.SetWebImage($"{videoYB.video.Thumbnails.FirstOrDefault().Url}.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoYB = null;
            HabilitarControle(videoYB);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDir.Text) || !Directory.Exists(txtDir.Text))
            {
                MessageBox.Show("Necessário informar um caminho válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string resp = await VideoYB.SaveVideo(videoYB, txtDir.Text, cmbFormato.Text);
            videoYB = null;
            HabilitarControle(videoYB);
            MessageBox.Show($"Salvo no diretório: {resp}", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtDir.Text = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Seleção do diretório cancelada pelo usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}