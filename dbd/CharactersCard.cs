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

            // 🔥 Задаём стартовый размер карточки ещё при создании
            this.Width = 180;
            this.Height = 250;
            this.AutoSize = false;

            // 🔥 Чтобы не моргало
            this.DoubleBuffered = true;
        }

        public bool cardS { get; set; }
        public string ImgPath { get; set; }

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

        public void ChooseCard()
        {
            pictureBox.BackgroundImage = cardS
                ? Properties.Resources.survC
                : Properties.Resources.killC;
        }

        public void LoadImgFromFile()
        {
            if (File.Exists(ImgPath))
                pictureBox.Image = new Bitmap(ImgPath);
            else
                pictureBox.Image = null;
        }
    }
    
}