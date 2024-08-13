using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube_Downloader
{
    public partial class frDown : Form
    {
        private readonly YoutubeClient youtube = new YoutubeClient();
        private IStreamInfo selectedStreamInfo;
        private Progress<double> progressHandler;

        public frDown()
        {
            InitializeComponent();
            progressHandler = new Progress<double>(progress =>
            {
                int percentage = (int)(progress * 100);
                Avanco.Value = percentage;

                // Atualiza o texto de LBFicheiro com base no progresso
                if (percentage < 100)
                {
                    LBFicheiro.Text = $"Download {percentage}%";
                }
                else
                {
                    LBFicheiro.Text = $"Download {percentage}% - Seu Download Está Concluído";
                }
            });
            CmbQualidade.Text = "Qualidade";
        }

        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            var url = txtUrl.Text;
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por favor, insira uma URL.","URL",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try
            {
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                CmbQualidade.Items.Clear();

                if (rdMp4.Checked)
                {
                    foreach (var streamInfo in streamManifest.GetVideoStreams())
                    {
                        if (IsMp4Container(streamInfo.Container))
                        {
                            CmbQualidade.Items.Add($"{streamInfo.VideoQuality.Label} - {streamInfo.Container}");
                        }
                    }
                }
                else if (rdMp3.Checked)
                {
                    foreach (var streamInfo in streamManifest.GetAudioStreams())
                    {
                        CmbQualidade.Items.Add($"{streamInfo.Bitrate.KiloBitsPerSecond} Kbps - {streamInfo.Container}");
                    }
                }

                if (CmbQualidade.Items.Count > 0)
                    CmbQualidade.SelectedIndex = 0;
                else
                    MessageBox.Show("Não foram encontrados streams disponíveis para o tipo selecionado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }


        private bool IsMp4Container(Container container)
        {
            // Método para verificar se o contêiner é MP4
            return container.ToString().Equals("Mp4", StringComparison.OrdinalIgnoreCase);
        }

        private async void BtnDownload_Click(object sender, EventArgs e)
        {
            var url = txtUrl.Text;
            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por favor, insira uma URL.");
                return;
            }

            if (CmbQualidade.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma qualidade.");
                return;
            }

            var selectedQuality = CmbQualidade.SelectedItem.ToString();
            var containerName = selectedQuality.Split('-').Last().Trim(); // Obter o nome do contêiner

            try
            {
                LBFicheiro.Text = "Download 0%"; // Define o texto inicial

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = $"{containerName}_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                saveFileDialog.Filter = "Arquivos MP3|*.mp3|Arquivos MP4|*.mp4";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;

                    var video = await youtube.Videos.GetAsync(url);
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                    if (rdMp4.Checked)
                    {
                        selectedStreamInfo = streamManifest.GetVideoStreams()
                            .FirstOrDefault(s => $"{s.VideoQuality.Label} - {s.Container}" == selectedQuality && IsMp4Container(s.Container));
                    }
                    else if (rdMp3.Checked)
                    {
                        selectedStreamInfo = streamManifest.GetAudioStreams()
                            .FirstOrDefault(s => $"{s.Bitrate.KiloBitsPerSecond} Kbps - {s.Container}" == selectedQuality);
                    }

                    if (selectedStreamInfo == null)
                    {
                        MessageBox.Show("Stream selecionada não encontrada.");
                        return;
                    }

                    await youtube.Videos.Streams.DownloadAsync(selectedStreamInfo, filePath, progress: progressHandler);

                    Avanco.Value = 100;
                    LBFicheiro.Text = "Download 100% "; // Define o texto quando o download é concluído
                }
                else
                {
                    LBFicheiro.Text = string.Empty; // Limpa o texto se o usuário cancelar o SaveFileDialog
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        private void Limpar()
        {
            if (rdMp3.Checked || rdMp4.Checked || !string.IsNullOrEmpty(txtUrl.Text) || CmbQualidade.Items.Count > 0 || Avanco.Value > 0 || LBFicheiro.Text != "Ficheiro ...")
            {
                rdMp3.Checked = false;
                rdMp4.Checked = false;
                txtUrl.Clear();
                CmbQualidade.Items.Clear();
                CmbQualidade.Text = "Qualidade";
                Avanco.Value = 0;
                LBFicheiro.Text = "Download ...";
                MessageBox.Show("Dados Limpos com Sucesso", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sem Dados para Limpar", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair Do Programa?Sim Nao",
                "SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            Application.Exit();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            var url = txtUrl.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Por favor, insira uma URL.", "URL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Abre o navegador padrão com a URL inserida em txtUrl
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a URL: {ex.Message}");
            }
        }

        private void BtnAutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome:Joel António Gonçalves Tigeleiro\n"+"Pais:Portugal"+"Idade:32\n"
                +"Profisão:Programador de Informatico C# ASP.Net JAVA, Python , C e C++\n"
                +"e Tecnico De informatica Instalação e Gestão de Redes\n"
                +"Certificado: Pelo Estado Portugues União europeia e POCH e IEFP\n"+
                "Que te Torna um Bom Programador e quando Acrescentas Valor a Uma Empresa\n"+
                "Nao tens de Saber Tudo tens So de ir Atrás Das Soluções es Pago\n" +
                "Para Implementar Um Solução de Software e rescolver Um Probelema\n", 
                "Autor",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

