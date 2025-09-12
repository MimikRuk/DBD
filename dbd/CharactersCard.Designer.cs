using System.Drawing;
using System.Windows.Forms;

namespace dbd
{
    partial class CharactersCard
    {
        private System.ComponentModel.IContainer components = null;
        private Panel bottomPanel;
        private Label label1;
        private CheckBox checkBox1;
        private PictureBox pictureBox;


        private void InitializeComponent()
        {
            this.pictureBox = new PictureBox();
            this.bottomPanel = new Panel();
            this.label1 = new Label();
            this.checkBox1 = new CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();

            // === PictureBox (фон + портрет) ===
            this.pictureBox.Dock = DockStyle.Fill;
            this.pictureBox.BackColor = Color.Black;
            this.pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox.BackgroundImageLayout = ImageLayout.Stretch;

            // === Нижняя панель ===
            this.bottomPanel.Dock = DockStyle.Bottom;
            this.bottomPanel.Height = 30;
            this.bottomPanel.BackColor = Color.FromArgb(150, 0, 0, 0);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.checkBox1);

            // === Label ===
            this.label1.Dock = DockStyle.Fill;
            this.label1.Font = new Font("Arial", 9F, FontStyle.Bold);
            this.label1.ForeColor = Color.White;
            this.label1.TextAlign = ContentAlignment.MiddleLeft;
            this.label1.Text = "Имя";

            // === CheckBox ===
            this.checkBox1.Dock = DockStyle.Right;
            this.checkBox1.Width = 20;
            this.checkBox1.Text = "";

            // === UserControl: карточка ===
            this.Controls.Add(this.pictureBox);   // картинка занимает всё
            this.Controls.Add(this.bottomPanel);  // панель снизу поверх картинки

            this.Name = "CharactersCard";
            this.Size = new Size(180, 250);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}