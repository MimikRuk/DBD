using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using System.IO;
using System.Net.Http;

namespace dbd
{
    public partial class Form1 : Form
    {
        private bool Ruverse = true;
        private readonly string dbPath = @"Data Source=C:\Users\Mimik\source\repos\dbd\dbd\dbd.db";
        private List<CharactersCard> allCards = new List<CharactersCard>();
        private int currentIndex = 0;
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
        private async Task LoadData()
        {
            string dbFile = Path.Combine(Application.StartupPath, "dbd.db");
            using (var conn = new SqliteConnection($"Data Source={dbFile}"))
            {
                await conn.OpenAsync();
                string sqlcomm = "SELECT Url, Ruverse FROM Characters ORDER BY Id ASC ";
                using (var cmd = new SqliteCommand(sqlcomm, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (await reader.ReadAsync())
                    {
                        var card = new CharactersCard();
                        card.Pers = reader["Ruverse"].ToString();
                        card.ImageUrl = reader["Url"].ToString().Trim();
                        await card.LoadImageAsync();


                        flowLayoutPanel1.Controls.Add(card);
                    }   
                }
                
            }
            RenderCards();
        }

        private void RenderCards()
        {
            flowLayoutPanel1.Controls.Clear();

            int leftIndex = currentIndex - 1;
            int rightIndex = currentIndex + 1;

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

            if (currentIndex >= 0 && currentIndex < allCards.Count)
            {
                var midCard = allCards[currentIndex];
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
            string query = "SELECT Characters.Ruverse, Perks.Ruverse";
        }
        private void ru_Click(object sender, EventArgs e)
        {
            langP.Visible = false;
        }
        private void eng_Click(object sender, EventArgs e)
        {
            langP.Visible = false;
        }
        private void pSurv_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        private void pKill_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }
        private void bPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                RenderCards();
            }
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < allCards.Count - 1)
            {
                currentIndex++;
                RenderCards();
            }
        }

    }
}
