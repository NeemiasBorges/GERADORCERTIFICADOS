using System.Drawing;
using System.Drawing;
using System.Drawing.Imaging;

namespace GeradorImagem
{
    public class Main
    {
        public void GenerateImage()
        {
            //load image by path
            Console.WriteLine("Informe o Caminho da Imagem que deseja Utilizar (BMP): ");
            //string imagePath         = Console.ReadLine("C:\\Users\\Neemias2\\Desktop\\PROJETOS\\PESSOAL\\Imagens");
            string imagePath           = "C:\\Users\\Neemias2\\Downloads\\test.bmp";

            //Path to save images
            Console.WriteLine("Informe o Caminho para salvar as imagens: ");
            //string caminhoParaSalvar = Console.ReadLine();
            string caminhoParaSalvar = "C:\\Users\\Neemias2\\Desktop\\PROJETOS\\PESSOAL\\Imagens";

            //Path of list of text to be generated
            Console.WriteLine("Informe o caminho da lista do texto em formato CSV: ");
            //string sourceText        = Console.ReadLine();
            string sourceText          = "LÉIA CRISTINA ANDRADE RIBEIRO;LEANDRO CASSANO MARTINS";

            List<string> txtTratado  = new List<string>();
            txtTratado               = sourceText.Split(";").ToList();

            foreach (var item in txtTratado)
            {
                Bitmap bitmap            = new Bitmap(imagePath);
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font arialFont = new Font("Arial", 10))
                    {
                        graphics.DrawString("Text to add", arialFont, Brushes.Black, new PointF(0, 0));
                    }
                }

                bitmap.Save(@$"{caminhoParaSalvar}\\TEST.jpeg", ImageFormat.Jpeg);
            }
        }
    }
}



