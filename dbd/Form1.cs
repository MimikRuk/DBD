using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace dbd
{
// Объявление переменых и стартовые данные
    public partial class Form1 : Form
    {
        private bool Ru = true;
        private bool Pick = true;
        private List<CharactersCard> allCards = new List<CharactersCard>();
        public Form1()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadData();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            langP.Visible = false;
            langP.BringToFront();
            langB.BringToFront();

        }
// Выборка по роли и языку, а так же логика отображения персонажей
        private async Task LoadData()
        {
            string dbFile = Path.Combine(Application.StartupPath, "dbd.db");
            using (var conn = new SqliteConnection($"Data Source={dbFile}"))
            {
                await conn.OpenAsync();

                string langColumn = Ru ? "Ruverse" : "Name";

                string roleFilter = Pick ? "Survivor" : "Killer";

                string sqlcomm = $"SELECT Url, {langColumn} FROM Characters WHERE Role = '{roleFilter}' ORDER BY Id ASC";

                using (var cmd = new SqliteCommand(sqlcomm, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    allCards.Clear();
                    CurrentIndex = 0;

                    while (await reader.ReadAsync())
                    {
                        var card = new CharactersCard();
                        card.Pers = reader[Ru ? "Ruverse" : "Name"].ToString();
                        string imgsDir = Path.Combine(Application.StartupPath, "dbdImg");
                        string imgFile = reader["Url"].ToString().Trim();
                        string fullPath = Path.Combine(imgsDir, imgFile);
                        card.ImgPath = fullPath;
                        card.LoadImgFromFile();
                        allCards.Add(card);
                    }

                }
                RenderCards();
            }
        }
//Отдельные индексы прокрутки колеса выбора персонажей
        private int currentSurvIndex = 0;
        private int currentKillIndex = 0;

        private int CurrentIndex
        {
            get => Pick ? currentSurvIndex : currentKillIndex;
            set
            {
                if (Pick) currentSurvIndex = value;
                else currentKillIndex = value;
            }
        }
// Логика колеса
        private void RenderCards()
        {
            flowLayoutPanel1.Controls.Clear();

            int leftIndex = CurrentIndex - 1;
            int rightIndex = CurrentIndex + 1;

            int spacing = 20;
            int cardWidth = 180;
            int cardHeight = 250;

            int startX = (flowLayoutPanel1.Width - (cardWidth * 3 + spacing * 2)) / 2;
            int y = (flowLayoutPanel1.Height - cardHeight) / 2;

            if (leftIndex >= 0)
            {
                var leftCard = allCards[leftIndex];
                leftCard.Width = cardWidth;
                leftCard.Height = cardHeight;
                leftCard.Location = new Point(startX, y);
                flowLayoutPanel1.Controls.Add(leftCard);
            }

            if (CurrentIndex >= 0 && CurrentIndex < allCards.Count)
            {
                var midCard = allCards[CurrentIndex];
                midCard.Width = cardWidth;
                midCard.Height = cardHeight;
                midCard.Location = new Point(startX + cardWidth + spacing, y);
                flowLayoutPanel1.Controls.Add(midCard);
            }

            if (rightIndex < allCards.Count)
            {
                var rightCard = allCards[rightIndex];
                rightCard.Width = cardWidth;
                rightCard.Height = cardHeight;
                rightCard.Location = new Point(startX + (cardWidth + spacing) * 2, y);
                flowLayoutPanel1.Controls.Add(rightCard);
            }
        }
// Функционал кнопок
        private void bBack1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        private void bBack2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void bBack3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        private void button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }
        private void langB_Click(object sender, EventArgs e)
        {
            langP.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private async void ru_Click(object sender, EventArgs e)
        {
            langP.Hide();
            Ru = true;
            await LoadData();
        }
        private async void eng_Click(object sender, EventArgs e)
        {
            langP.Hide();
            Ru = false;
            await LoadData();
        }
        private async void pSurv_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Pick = true;
            await LoadData();
        }
        private async void pKill_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            Pick = false;
            await LoadData();
        }
        private void bPrev_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                RenderCards();
            }
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < allCards.Count - 1)
            {
                CurrentIndex++;
                RenderCards();
            }
        }

    }
}
