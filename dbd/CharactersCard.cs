using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;




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

                    using (FileStream fs = new FileStream(ImgPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBox1.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                pictureBox1.Image = null;
                Console.WriteLine("Ошибка загрузки картинки: " + ex.Message);
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