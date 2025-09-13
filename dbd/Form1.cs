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
        //Переменная языка текста
        private bool Ru = true;
        //Переменная роли персонажа
        private bool Pick = true;
        //Лист для хранения всех карточек
        private List<CharactersCard> allCards = new List<CharactersCard>();
        public Form1()
        {
            InitializeComponent();
            this.Load += async (s, e) => await LoadData();
            //Скрытие вкладок в tabControl
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            //Список элементов к которым применяется эффект увеличения при наведении
            foreach (var btn in new[] { pSurv, pKill, langB, bNext, bPrev, ru, eng, bBack1, bBack2, bBack3, button, exitB})
            {
                btn.MouseEnter += Button_MouseEnter;
                btn.MouseLeave += Button_MouseLeave;
            }
            //Центрирование кнопки старта
            button.Location = new Point(
    (this.ClientSize.Width - button.Width) / 2,
    (this.ClientSize.Height - button.Height) / 2);
        }

// Изменение размера элементов при наведении на них

        private Dictionary<Button, (Size, Point)> originalStates = new Dictionary<Button, (Size, Point)>();
// Увеличение
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (!originalStates.ContainsKey(btn))
                originalStates[btn] = (btn.Size, btn.Location);

            int dw = (int)(btn.Width * 0.05);
            int dh = (int)(btn.Height * 0.05);

            btn.Size = new Size(btn.Width + dw, btn.Height + dh);
            btn.Location = new Point(btn.Location.X - dw / 2, btn.Location.Y - dh / 2);
        }
// Уменьшение
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (originalStates.ContainsKey(btn))
            {
                var (size, loc) = originalStates[btn];
                btn.Size = size;
                btn.Location = loc;
            }
        }   
//Логика отображения и загрузки файлов
        private async Task LoadData()
        {
            pSurv.Show();
            pKill.Show();
            string dbFile = Path.Combine(Application.StartupPath, "dbd.db");
            using (var conn = new SqliteConnection($"Data Source={dbFile}"))
            {
                await conn.OpenAsync();
                //Создание SQL запроса на основе выбранного языка и роли персонажа
                string langColumn = Ru ? "Ruverse" : "Name";

                string roleFilter = Pick ? "Survivor" : "Killer";

                string sqlcomm = $"SELECT Url, {langColumn} FROM Characters WHERE Role = '{roleFilter}' ORDER BY Id ASC";

                using (var cmd = new SqliteCommand(sqlcomm, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    allCards.Clear();
                    //Сдвиг порядка карточек на 1
                    CurrentIndex = 1;
                    //Чтение и создание карточек
                    while (await reader.ReadAsync())
                    {
                        var card = new CharactersCard();
                        card.Pers = reader[Ru ? "Ruverse" : "Name"].ToString();
                        string imgsDir = Path.Combine(Application.StartupPath, "dbdImg");
                        string imgFile = reader["Url"].ToString().Trim();
                        string fullPath = Path.Combine(imgsDir, imgFile);
                        card.ImgPath = fullPath;
                        card.cardS = Pick;
                        card.ChooseCard();
                        Console.WriteLine($"Card {card.Pers} -> {fullPath} (exists: {File.Exists(fullPath)})");
                        card.LoadImgFromFile();
                        card.Width = 180;
                        card.Height = 250;
                        card.AutoSize = false;

                        allCards.Add(card);
                    }
                    //Отоброжение колеса выбора персонажей
                    RenderCards();
                }
            }
        }
//Отдельные индексы прокрутки колеса выбора персонажей для разных ролей
        private int currentSurvIndex = 0;
        private int currentKillIndex = 0;

        //Свойство определения текущего индекса в зависимости от роли
        private int CurrentIndex
        {
            get => Pick ? currentSurvIndex : currentKillIndex;
            set
            {
                if (Pick) currentSurvIndex = value;
                else currentKillIndex = value;
            }
        }
// Отображение колеса выбора персонажей из 3 карточек
        private void RenderCards()
        {
            panelCards.Controls.Clear();
            if (allCards.Count == 0) return;
            //Размер
            int cardWidth = 200;
            int cardHeight = 280;
            int spacing = 60;
            //Позиция
            int totalWidth = (cardWidth * 3) + (spacing * 2);
            int startX = (panelCards.Width - totalWidth) / 2;
            int y = (panelCards.Height - cardHeight) / 2;
            //Получение индексов для каждой из 3 карточек
            int count = allCards.Count;
            int leftIndex = (CurrentIndex - 1 + count) % count;
            int midIndex = CurrentIndex % count;
            int rightIndex = (CurrentIndex + 1) % count;
            //создание и добавление клонов карточек
            var leftCard = CloneCard(allCards[leftIndex]);
            leftCard.Bounds = new Rectangle(startX, y, cardWidth, cardHeight);
            panelCards.Controls.Add(leftCard);

            var midCard = CloneCard(allCards[midIndex]);
            midCard.Bounds = new Rectangle(startX + cardWidth + spacing, y, cardWidth, cardHeight);
            panelCards.Controls.Add(midCard);

            var rightCard = CloneCard(allCards[rightIndex]);
            rightCard.Bounds = new Rectangle(startX + (cardWidth + spacing) * 2, y, cardWidth, cardHeight);
            panelCards.Controls.Add(rightCard);
            //Размещение кнопок переключения персонажа
            Point midCardAbsoluteLocation = new Point(
            panelCards.Location.X + midCard.Location.X,
            panelCards.Location.Y + midCard.Location.Y);
            int buttonCenterY = midCardAbsoluteLocation.Y + (cardHeight / 2);
            int buttonY = buttonCenterY - (bPrev.Height / 2);
            int buttonOffset = 15;
            int prevButtonX = midCardAbsoluteLocation.X - bPrev.Width - buttonOffset;
            int nextButtonX = midCardAbsoluteLocation.X + cardWidth + buttonOffset;
            bPrev.Location = new Point(prevButtonX, buttonY);
            bNext.Location = new Point(nextButtonX, buttonY);
            bPrev.BringToFront();
            bNext.BringToFront();
        }

        private CharactersCard CloneCard(CharactersCard original)
        {
            CharactersCard clone = new CharactersCard();
            clone.Pers = original.Pers;
            clone.ImgPath = original.ImgPath;
            clone.cardS = original.cardS;
            clone.Selected = original.Selected;
            clone.ChooseCard();
            clone.LoadImgFromFile();
            return clone;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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
        private void exitB_Click(object sender, EventArgs e)
        {
            this.Close();
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
            pSurv.Hide();
            pKill.Hide();
            tabControl1.SelectedTab = tabPage3;
            Pick = true;
            await LoadData();
        }
        private async void pKill_Click(object sender, EventArgs e)
        {
            pSurv.Hide();
            pKill.Hide();
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
