using System.Drawing.Text;
using System.Windows.Forms;

namespace GeradorDeCertificado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbImagePath;
        private TextBox tbSavePath;
        private TextBox tbCSVPath;
        private Button btnGenerate;
        private Button btnCancel;
        private ToolTip toolTip1;
        ProgressBar progressBar1 = new ProgressBar();
        InstalledFontCollection installedfontcollection = new InstalledFontCollection();

        public Button GerarImagem { get; private set; }
        public Button Cancelar { get; private set; }
        public Label CaminhoImagemLabel { get; private set; }
        public TextBox CaminhoImagemTextBox { get; private set; }
        public Label CaminhoSalvarLabel { get; private set; }
        public TextBox CaminhoSalvarTextBox { get; private set; }
        public Label CaminhoCSVLabel { get; private set; }
        public TextBox CaminhoCSVTextBox { get; private set; }


   
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.tbSavePath = new System.Windows.Forms.TextBox();
            this.tbCSVPath = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho da Imagem:";
            this.toolTip1.SetToolTip(this.label1, "Insira o caminho da imagem que deseja utilizar como modelo.");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Caminho para salvar as imagens:";
            this.toolTip1.SetToolTip(this.label2, "Insira o caminho onde deseja salvar as imagens geradas.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caminho do arquivo CSV:";
            this.toolTip1.SetToolTip(this.label3, "Insira o caminho do arquivo CSV contendo a lista de textos a serem adicionados na" +
        "s imagens.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Selecione uma font:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(198, 12);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(330, 23);
            this.tbImagePath.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbImagePath, "Insira o caminho da imagem que deseja utilizar como modelo.");
            // 
            // tbSavePath
            // 
            this.tbSavePath.Location = new System.Drawing.Point(198, 38);
            this.tbSavePath.Name = "tbSavePath";
            this.tbSavePath.Size = new System.Drawing.Size(330, 23);
            this.tbSavePath.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbSavePath, "Insira o caminho onde deseja salvar as imagens geradas.");
            this.tbSavePath.TextChanged += new System.EventHandler(this.tbSavePath_TextChanged);
            // 
            // tbCSVPath
            // 
            this.tbCSVPath.Location = new System.Drawing.Point(198, 64);
            this.tbCSVPath.Name = "tbCSVPath";
            this.tbCSVPath.Size = new System.Drawing.Size(330, 23);
            this.tbCSVPath.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbCSVPath, "Insira o caminho do arquivo CSV contendo a lista de textos a serem adicionados na" +
        "s imagens.");
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(180, 226);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Gerar";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // dropDown
            // 
            this.dropDown.Items.AddRange(new object[] {
            ""});
            this.dropDown.Location = new System.Drawing.Point(198, 93);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(330, 23);
            this.dropDown.TabIndex = 24;

            using (InstalledFontCollection col = new InstalledFontCollection())
            {
                foreach (FontFamily fa in col.Families)
                {
                    this.dropDown.Items.Add(fa.Name);
                }
            }

            this.progressBar1.Visible = false;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Location = new System.Drawing.Point(134, 180);
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(554, 261);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.tbSavePath);
            this.Controls.Add(this.tbCSVPath);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dropDown);

            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GerarImagem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ComboBox dropDown;
    }
}