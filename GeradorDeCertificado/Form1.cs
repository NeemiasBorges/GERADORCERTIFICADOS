using System.Drawing.Imaging;

namespace GeradorDeCertificado
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {
            progressBar1.Visible = true;


            // Verifica se os caminhos dos arquivos de entrada e sa�da foram fornecidos
            if (string.IsNullOrEmpty(tbImagePath.Text) || string.IsNullOrEmpty(tbSavePath.Text) || string.IsNullOrEmpty(tbCSVPath.Text))
            {
                MessageBox.Show("Por favor, forne�a o caminho da imagem, o caminho para salvar as imagens geradas e o caminho do arquivo CSV.", "Informa��o incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tbImagePath.Text = tbImagePath.Text.Replace("\"", "");
            tbSavePath.Text = tbSavePath.Text.Replace("\"", "");
            tbCSVPath.Text = tbCSVPath.Text.Replace("\"", "");


            // Verifica se a imagem de entrada existe
            if (!File.Exists(tbImagePath.Text))
            {
                MessageBox.Show("O arquivo da imagem n�o foi encontrado no caminho especificado.", "Arquivo n�o encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifica se o diret�rio de sa�da existe e o cria se n�o existir
            if (!Directory.Exists(tbSavePath.Text))
            {
                try
                {
                    Directory.CreateDirectory(tbSavePath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"O diret�rio de sa�da n�o pode ser criado. Erro: {ex.Message}", "Erro ao criar diret�rio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // L� os dados do arquivo CSV
            try
            {
                using (var reader = new StreamReader(tbCSVPath.Text))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        int progressBarCounter = 1;
                        foreach (var item in values.ToList())
                        {
                            progressBar1.Value = progressBarCounter;
                            Bitmap bitmap = new Bitmap(tbImagePath.Text);
                            using (Graphics graphics = Graphics.FromImage(bitmap))
                            {
                                using (Font arialFont = new Font("Proxima Nova Rg", 52))
                                {
                                    graphics.DrawString(item, arialFont, Brushes.Black, new PointF(110, 335));
                                }
                            }

                            bitmap.Save(@$"{tbSavePath.Text}\\{item.Trim()}.jpeg", ImageFormat.Jpeg);

                            Thread.Sleep(500);
                            progressBarCounter = progressBarCounter + (100 / values.Count());
                        }
                    }
                }

                MessageBox.Show("As imagens foram geradas com sucesso!", "Conclu�do", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar as imagens. Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            progressBar1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void tbSavePath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
