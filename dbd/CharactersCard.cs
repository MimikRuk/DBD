using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;




namespace dbd
{
    public partial class CharactersCard : UserControl
    {
        public CharactersCard()
        {
            InitializeComponent();

            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Height = 128;
            label1.Dock = DockStyle.Bottom;
            checkBox1.Dock = DockStyle.Bottom;
        }
    public bool cardS { get; set; }
    public void ChooseCard()
    {
            if (cardS)
                pictureBox1.BackgroundImage = Properties.Resources.survC;
            else
                pictureBox1.BackgroundImage = Properties.Resources.killC;

            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public string Pers
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public bool Selected
        {
            get => checkBox1.Checked;
            set => checkBox1.Checked = value;
        }
        public string ImgPath { get; set; }

        public void LoadImgFromFile()
        {
            try
            {
                if (File.Exists(ImgPath))
                {
                    pictureBox1.Image = new Bitmap(ImgPath);
                }
                else
                {
                    Console.WriteLine("Нет файла: " + ImgPath);
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при попытке загрузки: " + ImgPath);
                Console.WriteLine(" -> " + ex.Message);
                pictureBox1.Image = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}