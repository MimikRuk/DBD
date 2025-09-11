using System.Drawing;
using System.Windows.Forms;

namespace dbd
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button = new System.Windows.Forms.Button();
            this.langB = new System.Windows.Forms.Button();
            this.pSurv = new System.Windows.Forms.Button();
            this.pKill = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bBack1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrev = new System.Windows.Forms.Button();
            this.bBack2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.bBack3 = new System.Windows.Forms.Button();
            this.langP = new System.Windows.Forms.Panel();
            this.eng = new System.Windows.Forms.Button();
            this.ru = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.langP.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImage = global::dbd.Properties.Resources.startB;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(216, 123);
            this.button.Name = "button";
            this.button.Size = global::dbd.Properties.Resources.startB.Size;
            this.button.TabIndex = 0;
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // langB
            // 
            this.langB.BackgroundImage = global::dbd.Properties.Resources.langB;
            this.langB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.langB.FlatAppearance.BorderSize = 0;
            this.langB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langB.Location = new System.Drawing.Point(20, 570);
            this.langB.Name = "langB";
            this.langB.Size = global::dbd.Properties.Resources.langB.Size;
            this.langB.TabIndex = 1;
            this.langB.TabStop = false;
            this.langB.UseVisualStyleBackColor = true;
            this.langB.Click += new System.EventHandler(this.langB_Click);
            // 
            // pSurv
            // 
            this.pSurv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pSurv.BackgroundImage")));
            this.pSurv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSurv.FlatAppearance.BorderSize = 0;
            this.pSurv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pSurv.Location = new System.Drawing.Point(49, 119);
            this.pSurv.Name = "pSurv";
            this.pSurv.Size = new System.Drawing.Size(256, 297);
            this.pSurv.TabIndex = 2;
            this.pSurv.TabStop = false;
            this.pSurv.UseVisualStyleBackColor = true;
            this.pSurv.Click += new System.EventHandler(this.pSurv_Click);
            // 
            // pKill
            // 
            this.pKill.BackgroundImage = global::dbd.Properties.Resources.killB;
            this.pKill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pKill.FlatAppearance.BorderSize = 0;
            this.pKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pKill.Location = new System.Drawing.Point(458, 119);
            this.pKill.Name = "pKill";
            this.pKill.Size = global::dbd.Properties.Resources.killB.Size;
            this.pKill.TabIndex = 3;
            this.pKill.TabStop = false;
            this.pKill.UseVisualStyleBackColor = true;
            this.pKill.Click += new System.EventHandler(this.pKill_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 662);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::dbd.Properties.Resources.wallP;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = global::dbd.Properties.Resources.wallP.Size;
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::dbd.Properties.Resources.wallP;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.bBack1);
            this.tabPage2.Controls.Add(this.pKill);
            this.tabPage2.Controls.Add(this.pSurv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = global::dbd.Properties.Resources.wallP.Size;
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bBack1
            // 
            this.bBack1.BackColor = System.Drawing.Color.Transparent;
            this.bBack1.BackgroundImage = global::dbd.Properties.Resources.prevPageB;
            this.bBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBack1.FlatAppearance.BorderSize = 0;
            this.bBack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bBack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack1.Location = new System.Drawing.Point(25, 20);
            this.bBack1.Margin = new System.Windows.Forms.Padding(20);
            this.bBack1.Name = "bBack1";
            this.bBack1.Size = global::dbd.Properties.Resources.prevPageB.Size;
            this.bBack1.TabIndex = 7;
            this.bBack1.TabStop = false;
            this.bBack1.UseVisualStyleBackColor = false;
            this.bBack1.Click += new System.EventHandler(this.bBack1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::dbd.Properties.Resources.wallP;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.bNext);
            this.tabPage3.Controls.Add(this.bPrev);
            this.tabPage3.Controls.Add(this.bBack2);
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = global::dbd.Properties.Resources.wallP.Size;
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.BackgroundImage = global::dbd.Properties.Resources.nextB;
            this.bNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bNext.FlatAppearance.BorderSize = 0;
            this.bNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNext.Location = new System.Drawing.Point(500, 281);
            this.bNext.Name = "bNext";
            this.bNext.Size = global::dbd.Properties.Resources.nextB.Size;
            this.bNext.TabIndex = 9;
            this.bNext.TabStop = false;
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrev
            // 
            this.bPrev.BackgroundImage = global::dbd.Properties.Resources.prevB;
            this.bPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrev.FlatAppearance.BorderSize = 0;
            this.bPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrev.Location = new System.Drawing.Point(200, 281);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = global::dbd.Properties.Resources.prevB.Size;
            this.bPrev.TabIndex = 0;
            this.bPrev.TabStop = false;
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bBack2
            // 
            this.bBack2.BackColor = System.Drawing.Color.Transparent;
            this.bBack2.BackgroundImage = global::dbd.Properties.Resources.prevPageB;
            this.bBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBack2.FlatAppearance.BorderSize = 0;
            this.bBack2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bBack2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack2.Location = new System.Drawing.Point(25, 20);
            this.bBack2.Margin = new System.Windows.Forms.Padding(20);
            this.bBack2.Name = "bBack2";
            this.bBack2.Size = global::dbd.Properties.Resources.prevPageB.Size;
            this.bBack2.TabIndex = 8;
            this.bBack2.TabStop = false;
            this.bBack2.UseVisualStyleBackColor = false;
            this.bBack2.Click += new System.EventHandler(this.bBack2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 327);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::dbd.Properties.Resources.wallP;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.bBack3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = global::dbd.Properties.Resources.wallP.Size;
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bBack3
            // 
            this.bBack3.BackColor = System.Drawing.Color.Transparent;
            this.bBack3.BackgroundImage = global::dbd.Properties.Resources.prevPageB;
            this.bBack3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bBack3.FlatAppearance.BorderSize = 0;
            this.bBack3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bBack3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bBack3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack3.Location = new System.Drawing.Point(25, 20);
            this.bBack3.Margin = new System.Windows.Forms.Padding(20);
            this.bBack3.Name = "bBack3";
            this.bBack3.Size = global::dbd.Properties.Resources.prevPageB.Size;
            this.bBack3.TabIndex = 8;
            this.bBack3.TabStop = false;
            this.bBack3.UseVisualStyleBackColor = false;
            this.bBack3.Click += new System.EventHandler(this.bBack3_Click);
            // 
            // langP
            // 
            this.langP.Controls.Add(this.eng);
            this.langP.Controls.Add(this.ru);
            this.langP.Location = new System.Drawing.Point(100, 570);
            this.langP.Name = "langP";
            this.langP.Size = new System.Drawing.Size(51, 73);
            this.langP.TabIndex = 2;
            this.langP.Visible = false;
            // 
            // eng
            // 
            this.eng.BackColor = System.Drawing.Color.Transparent;
            this.eng.FlatAppearance.BorderSize = 0;
            this.eng.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eng.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eng.Location = new System.Drawing.Point(3, 40);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(45, 30);
            this.eng.TabIndex = 4;
            this.eng.TabStop = false;
            this.eng.Text = "ENG";
            this.eng.UseVisualStyleBackColor = false;
            this.eng.Click += new System.EventHandler(this.eng_Click);
            // 
            // ru
            // 
            this.ru.BackColor = System.Drawing.Color.Transparent;
            this.ru.FlatAppearance.BorderSize = 0;
            this.ru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ru.Location = new System.Drawing.Point(3, 3);
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(45, 30);
            this.ru.TabIndex = 3;
            this.ru.TabStop = false;
            this.ru.Text = "RU";
            this.ru.UseVisualStyleBackColor = false;
            this.ru.Click += new System.EventHandler(this.ru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(767, 662);
            this.Controls.Add(this.langB);
            this.Controls.Add(this.langP);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DBDRandom";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.langP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button langB;
        private System.Windows.Forms.Button pSurv;
        private System.Windows.Forms.Button pKill;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel langP;
        private System.Windows.Forms.Button ru;
        private System.Windows.Forms.Button eng;
        private System.Windows.Forms.Button bBack1;
        private System.Windows.Forms.Button bBack2;
        private System.Windows.Forms.Button bBack3;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrev;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

