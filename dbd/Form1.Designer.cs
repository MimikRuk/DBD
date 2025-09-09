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
            this.button.Location = new System.Drawing.Point(271, 220);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(221, 123);
            this.button.TabIndex = 0;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // langB
            // 
            this.langB.Location = new System.Drawing.Point(20, 570);
            this.langB.Name = "langB";
            this.langB.Size = new System.Drawing.Size(71, 73);
            this.langB.TabIndex = 1;
            this.langB.Text = "Language";
            this.langB.UseVisualStyleBackColor = true;
            this.langB.Click += new System.EventHandler(this.langB_Click);
            // 
            // pSurv
            // 
            this.pSurv.Location = new System.Drawing.Point(49, 119);
            this.pSurv.Name = "pSurv";
            this.pSurv.Size = new System.Drawing.Size(243, 192);
            this.pSurv.TabIndex = 2;
            this.pSurv.Text = "Survivor";
            this.pSurv.UseVisualStyleBackColor = true;
            this.pSurv.Click += new System.EventHandler(this.pSurv_Click);
            // 
            // pKill
            // 
            this.pKill.Location = new System.Drawing.Point(458, 119);
            this.pKill.Name = "pKill";
            this.pKill.Size = new System.Drawing.Size(243, 192);
            this.pKill.TabIndex = 3;
            this.pKill.Text = "Killer";
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
            this.tabPage1.Controls.Add(this.button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bBack1);
            this.tabPage2.Controls.Add(this.pKill);
            this.tabPage2.Controls.Add(this.pSurv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bBack1
            // 
            this.bBack1.Location = new System.Drawing.Point(25, 20);
            this.bBack1.Margin = new System.Windows.Forms.Padding(20);
            this.bBack1.Name = "bBack1";
            this.bBack1.Size = new System.Drawing.Size(46, 43);
            this.bBack1.TabIndex = 7;
            this.bBack1.Text = "<----";
            this.bBack1.UseVisualStyleBackColor = true;
            this.bBack1.Click += new System.EventHandler(this.bBack1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bNext);
            this.tabPage3.Controls.Add(this.bPrev);
            this.tabPage3.Controls.Add(this.bBack2);
            this.tabPage3.Controls.Add(this.flowLayoutPanel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(759, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(500, 275);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(35, 35);
            this.bNext.TabIndex = 9;
            this.bNext.Text = ">";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrev
            // 
            this.bPrev.Location = new System.Drawing.Point(200, 275);
            this.bPrev.Name = "bPrev";
            this.bPrev.Size = new System.Drawing.Size(35, 35);
            this.bPrev.TabIndex = 0;
            this.bPrev.Text = "<";
            this.bPrev.UseVisualStyleBackColor = true;
            this.bPrev.Click += new System.EventHandler(this.bPrev_Click);
            // 
            // bBack2
            // 
            this.bBack2.Location = new System.Drawing.Point(25, 20);
            this.bBack2.Margin = new System.Windows.Forms.Padding(20);
            this.bBack2.Name = "bBack2";
            this.bBack2.Size = new System.Drawing.Size(46, 43);
            this.bBack2.TabIndex = 8;
            this.bBack2.Text = "<----";
            this.bBack2.UseVisualStyleBackColor = true;
            this.bBack2.Click += new System.EventHandler(this.bBack2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 69);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.bBack3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(759, 636);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // bBack3
            // 
            this.bBack3.Location = new System.Drawing.Point(25, 20);
            this.bBack3.Margin = new System.Windows.Forms.Padding(20);
            this.bBack3.Name = "bBack3";
            this.bBack3.Size = new System.Drawing.Size(46, 43);
            this.bBack3.TabIndex = 8;
            this.bBack3.Text = "<----";
            this.bBack3.UseVisualStyleBackColor = true;
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
            // 
            // eng
            // 
            this.eng.Location = new System.Drawing.Point(3, 40);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(45, 30);
            this.eng.TabIndex = 4;
            this.eng.Text = "ENG";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.Click += new System.EventHandler(this.eng_Click);
            // 
            // ru
            // 
            this.ru.Location = new System.Drawing.Point(3, 3);
            this.ru.Name = "ru";
            this.ru.Size = new System.Drawing.Size(45, 30);
            this.ru.TabIndex = 3;
            this.ru.Text = "RU";
            this.ru.UseVisualStyleBackColor = true;
            this.ru.Click += new System.EventHandler(this.ru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 662);
            this.Controls.Add(this.langB);
            this.Controls.Add(this.langP);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bBack1;
        private System.Windows.Forms.Button bBack2;
        private System.Windows.Forms.Button bBack3;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrev;
    }
}

