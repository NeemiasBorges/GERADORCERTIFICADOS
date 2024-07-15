using System.Drawing;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace GeradorImagem
{
    public class Main
    {
        public void GenerateImage()
        {
            Console.WriteLine("Informe o Caminho da Imagem que deseja Utilizar (BMP): ");
            string imagePath           = "C:\\Users\\Neemias2\\Desktop\\thumb.bmp";

            Console.WriteLine("Informe o Caminho para salvar as imagens: ");
            string caminhoParaSalvar = "C:\\Users\\Neemias2\\Desktop\\PROJETOS\\PESSOAL\\Imagens";

            Console.WriteLine("Informe o caminho da lista do texto em formato CSV: ");
            string sourceText          = "LÉIA CRISTINA ANDRADE RIBEIRO;LEANDRO CASSANO MARTINS";

            List<string> txtTratado  = new List<string>();
            txtTratado               = sourceText.Split(";").ToList();

            foreach (var item in txtTratado)
            {
                Bitmap bitmap            = new Bitmap(imagePath);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font arialFont = new Font("Proxima Nova Rg", 52))
                    {
                        graphics.DrawString(item, arialFont, Brushes.Black, new PointF(110,335));
                    }
                }
                bitmap.Save(@$"{caminhoParaSalvar}\\{item.Trim()}.jpeg", ImageFormat.Jpeg);
            }
        }
    }
}



