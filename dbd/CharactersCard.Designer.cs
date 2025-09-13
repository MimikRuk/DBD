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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // pictureBox (для фона и портрета)
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 220);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // 
            // bottomPanel (для имени и чекбокса)
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.checkBox1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 220);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(180, 30);
            this.bottomPanel.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // checkBox1
            // 
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(160, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(20, 30);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "";
            this.checkBox1.UseVisualStyleBackColor = true;

            // 
            // CharactersCard
            // 
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.bottomPanel);
            this.Name = "CharactersCard";
            this.Size = new System.Drawing.Size(180, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}