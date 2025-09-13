using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace dbd
{
//шаблон карточки персонажа
    public partial class CharactersCard : UserControl
    {
        public CharactersCard()
        {
            InitializeComponent();
            this.Width = 180;
            this.Height = 250;
            this.AutoSize = false;
            //Двойная буфферизация для отсутствия мерцания экрана
            this.DoubleBuffered = true; 
        }
        //Выбор ассетов в зависимости от выбранной роли
        public bool cardS { get; set; }
        //Путь до портрета персонажа
        public string ImgPath { get; set; }

        public string Pers
        {
            //Изменение текста на карточке персонажа
            get => label1.Text;
            set => label1.Text = value;
        }
        //Управление чекбоксом
        public bool Selected
        {
            get => checkBox1.Checked;
            set => checkBox1.Checked = value;
        }
        //Выбор фона в зависимости от роли персонажа
        public void ChooseCard()
        {
            pictureBox.BackgroundImage = cardS
                ? Properties.Resources.survC
                : Properties.Resources.killC;
        }
        //Загрузка портрета по пути указаному ранее
        public void LoadImgFromFile()
        {
            if (File.Exists(ImgPath))
                pictureBox.Image = new Bitmap(ImgPath);
            else
                pictureBox.Image = null;
        }
    }
    
}