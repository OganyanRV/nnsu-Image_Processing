namespace laba1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оттенокСерогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличениеЯркостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрСоболяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрРезкостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матморфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расширениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сужениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закртыиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motionBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.волны2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеклоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейноеРастяжениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотНа45ГрадусовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(812, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.матморфологияToolStripMenuItem,
            this.медианныйФильтрToolStripMenuItem,
            this.выделениеГраницToolStripMenuItem,
            this.motionBlurToolStripMenuItem,
            this.волныToolStripMenuItem,
            this.волны2ToolStripMenuItem,
            this.стеклоToolStripMenuItem,
            this.линейноеРастяжениеToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.поворотНа45ГрадусовToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.оттенокСерогоToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.увеличениеЯркостиToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // оттенокСерогоToolStripMenuItem
            // 
            this.оттенокСерогоToolStripMenuItem.Name = "оттенокСерогоToolStripMenuItem";
            this.оттенокСерогоToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.оттенокСерогоToolStripMenuItem.Text = "Оттенок серого";
            this.оттенокСерогоToolStripMenuItem.Click += new System.EventHandler(this.оттенокСерогоToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // увеличениеЯркостиToolStripMenuItem
            // 
            this.увеличениеЯркостиToolStripMenuItem.Name = "увеличениеЯркостиToolStripMenuItem";
            this.увеличениеЯркостиToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.увеличениеЯркостиToolStripMenuItem.Text = "Увеличение яркости";
            this.увеличениеЯркостиToolStripMenuItem.Click += new System.EventHandler(this.увеличениеЯркостиToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem,
            this.фильтрСоболяToolStripMenuItem,
            this.фильтрРезкостиToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.размытиеToolStripMenuItem.Text = "Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.фильтрГауссаToolStripMenuItem.Text = "Фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // фильтрСоболяToolStripMenuItem
            // 
            this.фильтрСоболяToolStripMenuItem.Name = "фильтрСоболяToolStripMenuItem";
            this.фильтрСоболяToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.фильтрСоболяToolStripMenuItem.Text = "Фильтр Соболя";
            this.фильтрСоболяToolStripMenuItem.Click += new System.EventHandler(this.фильтрСоболяToolStripMenuItem_Click);
            // 
            // фильтрРезкостиToolStripMenuItem
            // 
            this.фильтрРезкостиToolStripMenuItem.Name = "фильтрРезкостиToolStripMenuItem";
            this.фильтрРезкостиToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.фильтрРезкостиToolStripMenuItem.Text = "Фильтр резкости";
            this.фильтрРезкостиToolStripMenuItem.Click += new System.EventHandler(this.фильтрРезкостиToolStripMenuItem_Click);
            // 
            // матморфологияToolStripMenuItem
            // 
            this.матморфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расширениеToolStripMenuItem,
            this.сужениеToolStripMenuItem,
            this.открытиеToolStripMenuItem,
            this.закртыиеToolStripMenuItem,
            this.topHatToolStripMenuItem});
            this.матморфологияToolStripMenuItem.Name = "матморфологияToolStripMenuItem";
            this.матморфологияToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.матморфологияToolStripMenuItem.Text = "Матморфология";
            // 
            // расширениеToolStripMenuItem
            // 
            this.расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            this.расширениеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.расширениеToolStripMenuItem.Text = "Расширение";
            this.расширениеToolStripMenuItem.Click += new System.EventHandler(this.расширениеToolStripMenuItem_Click);
            // 
            // сужениеToolStripMenuItem
            // 
            this.сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            this.сужениеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.сужениеToolStripMenuItem.Text = "Сужение";
            this.сужениеToolStripMenuItem.Click += new System.EventHandler(this.сужениеToolStripMenuItem_Click);
            // 
            // открытиеToolStripMenuItem
            // 
            this.открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            this.открытиеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.открытиеToolStripMenuItem.Text = "Открытие";
            this.открытиеToolStripMenuItem.Click += new System.EventHandler(this.открытиеToolStripMenuItem_Click);
            // 
            // закртыиеToolStripMenuItem
            // 
            this.закртыиеToolStripMenuItem.Name = "закртыиеToolStripMenuItem";
            this.закртыиеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.закртыиеToolStripMenuItem.Text = "Замыкание";
            this.закртыиеToolStripMenuItem.Click += new System.EventHandler(this.закртыиеToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.topHatToolStripMenuItem.Text = "Top hat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            this.медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            this.медианныйФильтрToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            this.медианныйФильтрToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрToolStripMenuItem_Click);
            // 
            // выделениеГраницToolStripMenuItem
            // 
            this.выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            this.выделениеГраницToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            this.выделениеГраницToolStripMenuItem.Click += new System.EventHandler(this.выделениеГраницToolStripMenuItem_Click);
            // 
            // motionBlurToolStripMenuItem
            // 
            this.motionBlurToolStripMenuItem.Name = "motionBlurToolStripMenuItem";
            this.motionBlurToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.motionBlurToolStripMenuItem.Text = "Motion Blur";
            this.motionBlurToolStripMenuItem.Click += new System.EventHandler(this.motionBlurToolStripMenuItem_Click);
            // 
            // волныToolStripMenuItem
            // 
            this.волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            this.волныToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.волныToolStripMenuItem.Text = "Волны 1";
            this.волныToolStripMenuItem.Click += new System.EventHandler(this.волныToolStripMenuItem_Click);
            // 
            // волны2ToolStripMenuItem
            // 
            this.волны2ToolStripMenuItem.Name = "волны2ToolStripMenuItem";
            this.волны2ToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.волны2ToolStripMenuItem.Text = "Волны 2";
            this.волны2ToolStripMenuItem.Click += new System.EventHandler(this.волны2ToolStripMenuItem_Click);
            // 
            // стеклоToolStripMenuItem
            // 
            this.стеклоToolStripMenuItem.Name = "стеклоToolStripMenuItem";
            this.стеклоToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.стеклоToolStripMenuItem.Text = "Стекло";
            this.стеклоToolStripMenuItem.Click += new System.EventHandler(this.стеклоToolStripMenuItem_Click);
            // 
            // линейноеРастяжениеToolStripMenuItem
            // 
            this.линейноеРастяжениеToolStripMenuItem.Name = "линейноеРастяжениеToolStripMenuItem";
            this.линейноеРастяжениеToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.линейноеРастяжениеToolStripMenuItem.Text = "Линейное растяжение";
            this.линейноеРастяжениеToolStripMenuItem.Click += new System.EventHandler(this.линейноеРастяжениеToolStripMenuItem_Click);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click);
            // 
            // поворотНа45ГрадусовToolStripMenuItem
            // 
            this.поворотНа45ГрадусовToolStripMenuItem.Name = "поворотНа45ГрадусовToolStripMenuItem";
            this.поворотНа45ГрадусовToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.поворотНа45ГрадусовToolStripMenuItem.Text = "Поворот на 45 градусов";
            this.поворотНа45ГрадусовToolStripMenuItem.Click += new System.EventHandler(this.поворотНа45ГрадусовToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(2, 10);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.MaximumSize = new System.Drawing.Size(0, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(641, 30);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена изменений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.35416F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.64583F));
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 393);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 51);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрСоболяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрРезкостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оттенокСерогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличениеЯркостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеклоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem волны2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейноеРастяжениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матморфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расширениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сужениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закртыиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотНа45ГрадусовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

