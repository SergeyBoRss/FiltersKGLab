namespace Filters
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенкиСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышенеиЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светящиесяКраяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеВДвиженииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.другоеПовышениеРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторЩарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторПрюиттаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.файлToolStripMenuItem, this.фильтрыToolStripMenuItem, this.назадToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.открытьToolStripMenuItem, this.сохранитьToolStripMenuItem });
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.точечныеToolStripMenuItem, this.матричныеToolStripMenuItem, this.движениеToolStripMenuItem });
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.инверсияToolStripMenuItem, this.оттенкиСерогоToolStripMenuItem, this.сепияToolStripMenuItem, this.повышенеиЯркостиToolStripMenuItem, this.светящиесяКраяToolStripMenuItem });
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // оттенкиСерогоToolStripMenuItem
            // 
            this.оттенкиСерогоToolStripMenuItem.Name = "оттенкиСерогоToolStripMenuItem";
            this.оттенкиСерогоToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.оттенкиСерогоToolStripMenuItem.Text = "Оттенки серого";
            this.оттенкиСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенкиСерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // повышенеиЯркостиToolStripMenuItem
            // 
            this.повышенеиЯркостиToolStripMenuItem.Name = "повышенеиЯркостиToolStripMenuItem";
            this.повышенеиЯркостиToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.повышенеиЯркостиToolStripMenuItem.Text = "Повышение яркости";
            this.повышенеиЯркостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеЯркостиToolStripMenuItem_Click);
            // 
            // светящиесяКраяToolStripMenuItem
            // 
            this.светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
            this.светящиесяКраяToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
            this.светящиесяКраяToolStripMenuItem.Click += new System.EventHandler(this.светящиесяКраяToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.размытиеToolStripMenuItem, this.собеляToolStripMenuItem, this.повышениеРезкостиToolStripMenuItem, this.тиснениеToolStripMenuItem, this.размытиеВДвиженииToolStripMenuItem, this.другоеПовышениеРезкостиToolStripMenuItem, this.операторЩарраToolStripMenuItem, this.операторПрюиттаToolStripMenuItem });
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.обычноеToolStripMenuItem, this.гауссToolStripMenuItem });
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            // 
            // обычноеToolStripMenuItem
            // 
            this.обычноеToolStripMenuItem.Name = "обычноеToolStripMenuItem";
            this.обычноеToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.обычноеToolStripMenuItem.Text = "Обычное";
            this.обычноеToolStripMenuItem.Click += new System.EventHandler(this.обычноеToolStripMenuItem_Click);
            // 
            // гауссToolStripMenuItem
            // 
            this.гауссToolStripMenuItem.Name = "гауссToolStripMenuItem";
            this.гауссToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.гауссToolStripMenuItem.Text = "Гаусс";
            this.гауссToolStripMenuItem.Click += new System.EventHandler(this.гауссToolStripMenuItem_Click);
            // 
            // собеляToolStripMenuItem
            // 
            this.собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            this.собеляToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.собеляToolStripMenuItem.Text = "Собеля";
            this.собеляToolStripMenuItem.Click += new System.EventHandler(this.собеляToolStripMenuItem_Click);
            // 
            // повышениеРезкостиToolStripMenuItem
            // 
            this.повышениеРезкостиToolStripMenuItem.Name = "повышениеРезкостиToolStripMenuItem";
            this.повышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.повышениеРезкостиToolStripMenuItem.Text = "Повышение резкости";
            this.повышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.повышениеРезкостиToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // размытиеВДвиженииToolStripMenuItem
            // 
            this.размытиеВДвиженииToolStripMenuItem.Name = "размытиеВДвиженииToolStripMenuItem";
            this.размытиеВДвиженииToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.размытиеВДвиженииToolStripMenuItem.Text = "Размытие в движении";
            this.размытиеВДвиженииToolStripMenuItem.Click += new System.EventHandler(this.размытиеВДвиженииToolStripMenuItem_Click);
            // 
            // другоеПовышениеРезкостиToolStripMenuItem
            // 
            this.другоеПовышениеРезкостиToolStripMenuItem.Name = "другоеПовышениеРезкостиToolStripMenuItem";
            this.другоеПовышениеРезкостиToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.другоеПовышениеРезкостиToolStripMenuItem.Text = "Другое повышение резкости";
            this.другоеПовышениеРезкостиToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // операторЩарраToolStripMenuItem
            // 
            this.операторЩарраToolStripMenuItem.Name = "операторЩарраToolStripMenuItem";
            this.операторЩарраToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.операторЩарраToolStripMenuItem.Text = "Оператор Щарра";
            this.операторЩарраToolStripMenuItem.Click += new System.EventHandler(this.щарраToolStripMenuItem_Click);
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            this.операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            this.операторПрюиттаToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            this.операторПрюиттаToolStripMenuItem.Click += new System.EventHandler(this.прюиттаToolStripMenuItem_Click);
            // 
            // движениеToolStripMenuItem
            // 
            this.движениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.переносToolStripMenuItem, this.поворотНа90ToolStripMenuItem, this.поворотНа180ToolStripMenuItem, this.волны1ToolStripMenuItem, this.волны2ToolStripMenuItem, this.стеклоToolStripMenuItem });
            this.движениеToolStripMenuItem.Name = "движениеToolStripMenuItem";
            this.движениеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.движениеToolStripMenuItem.Text = "Движение";
            // 
            // переносToolStripMenuItem
            // 
            this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            this.переносToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.переносToolStripMenuItem.Text = "Перенос";
            this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click);
            // 
            // поворотНа90ToolStripMenuItem
            // 
            this.поворотНа90ToolStripMenuItem.Name = "поворотНа90ToolStripMenuItem";
            this.поворотНа90ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.поворотНа90ToolStripMenuItem.Text = "Поворот на 90";
            this.поворотНа90ToolStripMenuItem.Click += new System.EventHandler(this.поворотНа90ToolStripMenuItem_Click);
            // 
            // поворотНа180ToolStripMenuItem
            // 
            this.поворотНа180ToolStripMenuItem.Name = "поворотНа180ToolStripMenuItem";
            this.поворотНа180ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.поворотНа180ToolStripMenuItem.Text = "Поворот на 180";
            this.поворотНа180ToolStripMenuItem.Click += new System.EventHandler(this.поворотНа180ToolStripMenuItem_Click);
            // 
            // волны1ToolStripMenuItem
            // 
            this.волны1ToolStripMenuItem.Name = "волны1ToolStripMenuItem";
            this.волны1ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.волны1ToolStripMenuItem.Text = "Волны 1";
            this.волны1ToolStripMenuItem.Click += new System.EventHandler(this.волны1ToolStripMenuItem_Click);
            // 
            // волны2ToolStripMenuItem
            // 
            this.волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            this.волны2ToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.волны2ToolStripMenuItem.Text = "Волны 2";
            this.волны2ToolStripMenuItem.Click += new System.EventHandler(this.волны2ToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.стеклоToolStripMenuItem.Text = "\"Стекло\"";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 412);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(652, 26);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеВДвиженииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem другоеПовышениеРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторЩарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светящиесяКраяToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem повышенеиЯркостиToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem обычноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оттенкиСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повышениеРезкостиToolStripMenuItem;

        private System.Windows.Forms.ProgressBar progressBar1;

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;

        #endregion
    }
}