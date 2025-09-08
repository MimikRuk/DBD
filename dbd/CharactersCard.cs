using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;



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
        public string ImageUrl { get; set; }

        public async Task LoadImageAsync()
        {
        Console.WriteLine("URL картинки: " + ImageUrl);
            try
            {
                using (var http = new HttpClient())
                {
                    // ставим нормальный заголовок как у браузера
                    http.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                    var bytes = await http.GetByteArrayAsync(ImageUrl);
                    using (var ms = new MemoryStream(bytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
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