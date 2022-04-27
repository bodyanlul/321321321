namespace tf9ik
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повторитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.текстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постановкаЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грамматикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классификацияГраматикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диагностикаИНейтрализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестовыйПримерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛитературыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исходныйКодПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сканерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultWindow = new System.Windows.Forms.RichTextBox();
            this.CreateFileBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.UndoBtn = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.CutBtn = new System.Windows.Forms.Button();
            this.PasteBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Valid = new System.Windows.Forms.Button();
            this.automat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.текстToolStripMenuItem,
            this.пускToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.СоздатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.СохранитьКакToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.повторитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // повторитьToolStripMenuItem
            // 
            this.повторитьToolStripMenuItem.Name = "повторитьToolStripMenuItem";
            this.повторитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.повторитьToolStripMenuItem.Text = "Повторить";
            this.повторитьToolStripMenuItem.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.CutBtn_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.ВыделитьВсеToolStripMenuItem_Click);
            // 
            // текстToolStripMenuItem
            // 
            this.текстToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автоматToolStripMenuItem,
            this.постановкаЗадачиToolStripMenuItem,
            this.грамматикаToolStripMenuItem,
            this.классификацияГраматикиToolStripMenuItem,
            this.методАнализаToolStripMenuItem,
            this.диагностикаИНейтрализацияToolStripMenuItem,
            this.тестовыйПримерToolStripMenuItem,
            this.списокЛитературыToolStripMenuItem,
            this.исходныйКодПрограммыToolStripMenuItem});
            this.текстToolStripMenuItem.Name = "текстToolStripMenuItem";
            this.текстToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.текстToolStripMenuItem.Text = "Текст";
            // 
            // автоматToolStripMenuItem
            // 
            this.автоматToolStripMenuItem.Name = "автоматToolStripMenuItem";
            this.автоматToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.автоматToolStripMenuItem.Text = "Автомат";
            this.автоматToolStripMenuItem.Click += new System.EventHandler(this.АвтоматToolStripMenuItem_Click);
            // 
            // постановкаЗадачиToolStripMenuItem
            // 
            this.постановкаЗадачиToolStripMenuItem.Name = "постановкаЗадачиToolStripMenuItem";
            this.постановкаЗадачиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.постановкаЗадачиToolStripMenuItem.Text = "Постановка задачи";
            // 
            // грамматикаToolStripMenuItem
            // 
            this.грамматикаToolStripMenuItem.Name = "грамматикаToolStripMenuItem";
            this.грамматикаToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.грамматикаToolStripMenuItem.Text = "Грамматика";
            this.грамматикаToolStripMenuItem.Click += new System.EventHandler(this.грамматикаToolStripMenuItem_Click);
            // 
            // классификацияГраматикиToolStripMenuItem
            // 
            this.классификацияГраматикиToolStripMenuItem.Name = "классификацияГраматикиToolStripMenuItem";
            this.классификацияГраматикиToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.классификацияГраматикиToolStripMenuItem.Text = "Классификация граматики";
            // 
            // методАнализаToolStripMenuItem
            // 
            this.методАнализаToolStripMenuItem.Name = "методАнализаToolStripMenuItem";
            this.методАнализаToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.методАнализаToolStripMenuItem.Text = "Метод анализа";
            // 
            // диагностикаИНейтрализацияToolStripMenuItem
            // 
            this.диагностикаИНейтрализацияToolStripMenuItem.Name = "диагностикаИНейтрализацияToolStripMenuItem";
            this.диагностикаИНейтрализацияToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.диагностикаИНейтрализацияToolStripMenuItem.Text = "Диагностика и нейтрализация";
            // 
            // тестовыйПримерToolStripMenuItem
            // 
            this.тестовыйПримерToolStripMenuItem.Name = "тестовыйПримерToolStripMenuItem";
            this.тестовыйПримерToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.тестовыйПримерToolStripMenuItem.Text = "Тестовый пример";
            // 
            // списокЛитературыToolStripMenuItem
            // 
            this.списокЛитературыToolStripMenuItem.Name = "списокЛитературыToolStripMenuItem";
            this.списокЛитературыToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.списокЛитературыToolStripMenuItem.Text = "Список литературы";
            // 
            // исходныйКодПрограммыToolStripMenuItem
            // 
            this.исходныйКодПрограммыToolStripMenuItem.Name = "исходныйКодПрограммыToolStripMenuItem";
            this.исходныйКодПрограммыToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.исходныйКодПрограммыToolStripMenuItem.Text = "Исходный код программы";
            // 
            // пускToolStripMenuItem
            // 
            this.пускToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сканерToolStripMenuItem});
            this.пускToolStripMenuItem.Name = "пускToolStripMenuItem";
            this.пускToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.пускToolStripMenuItem.Text = "Пуск";
            // 
            // сканерToolStripMenuItem
            // 
            this.сканерToolStripMenuItem.Name = "сканерToolStripMenuItem";
            this.сканерToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.сканерToolStripMenuItem.Text = "Сканер";
            this.сканерToolStripMenuItem.Click += new System.EventHandler(this.сканерToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вызовСправкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // вызовСправкиToolStripMenuItem
            // 
            this.вызовСправкиToolStripMenuItem.Name = "вызовСправкиToolStripMenuItem";
            this.вызовСправкиToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.вызовСправкиToolStripMenuItem.Text = "Вызов справки";
            this.вызовСправкиToolStripMenuItem.Click += new System.EventHandler(this.ВызовСправкиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // ResultWindow
            // 
            this.ResultWindow.Location = new System.Drawing.Point(16, 439);
            this.ResultWindow.Margin = new System.Windows.Forms.Padding(4);
            this.ResultWindow.Name = "ResultWindow";
            this.ResultWindow.ReadOnly = true;
            this.ResultWindow.Size = new System.Drawing.Size(972, 260);
            this.ResultWindow.TabIndex = 2;
            this.ResultWindow.Text = "";
            // 
            // CreateFileBtn
            // 
            this.CreateFileBtn.Location = new System.Drawing.Point(16, 44);
            this.CreateFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateFileBtn.Name = "CreateFileBtn";
            this.CreateFileBtn.Size = new System.Drawing.Size(80, 74);
            this.CreateFileBtn.TabIndex = 3;
            this.CreateFileBtn.Text = "Создать";
            this.CreateFileBtn.UseVisualStyleBackColor = true;
            this.CreateFileBtn.Click += new System.EventHandler(this.СоздатьToolStripMenuItem_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(104, 44);
            this.OpenFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(80, 74);
            this.OpenFileBtn.TabIndex = 4;
            this.OpenFileBtn.Text = "Открыть";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Location = new System.Drawing.Point(192, 44);
            this.SaveFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(80, 74);
            this.SaveFileBtn.TabIndex = 5;
            this.SaveFileBtn.Text = "Сохранить";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Location = new System.Drawing.Point(339, 44);
            this.UndoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(80, 74);
            this.UndoBtn.TabIndex = 6;
            this.UndoBtn.Text = "Отменить";
            this.UndoBtn.UseVisualStyleBackColor = true;
            this.UndoBtn.Click += new System.EventHandler(this.UndoBtn_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Location = new System.Drawing.Point(427, 44);
            this.ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(80, 74);
            this.ReturnBtn.TabIndex = 7;
            this.ReturnBtn.Text = "Повторить";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(515, 44);
            this.CopyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(80, 74);
            this.CopyBtn.TabIndex = 8;
            this.CopyBtn.Text = "Копировать";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // CutBtn
            // 
            this.CutBtn.Location = new System.Drawing.Point(603, 44);
            this.CutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CutBtn.Name = "CutBtn";
            this.CutBtn.Size = new System.Drawing.Size(80, 74);
            this.CutBtn.TabIndex = 9;
            this.CutBtn.Text = "Вырезать";
            this.CutBtn.UseVisualStyleBackColor = true;
            this.CutBtn.Click += new System.EventHandler(this.CutBtn_Click);
            // 
            // PasteBtn
            // 
            this.PasteBtn.Location = new System.Drawing.Point(691, 44);
            this.PasteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PasteBtn.Name = "PasteBtn";
            this.PasteBtn.Size = new System.Drawing.Size(80, 74);
            this.PasteBtn.TabIndex = 10;
            this.PasteBtn.Text = "Вставить";
            this.PasteBtn.UseVisualStyleBackColor = true;
            this.PasteBtn.Click += new System.EventHandler(this.PasteBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(16, 137);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 278);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // Valid
            // 
            this.Valid.Location = new System.Drawing.Point(779, 44);
            this.Valid.Margin = new System.Windows.Forms.Padding(4);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(80, 74);
            this.Valid.TabIndex = 12;
            this.Valid.Text = "Пуск";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // automat
            // 
            this.automat.Location = new System.Drawing.Point(867, 44);
            this.automat.Name = "automat";
            this.automat.Size = new System.Drawing.Size(75, 74);
            this.automat.TabIndex = 13;
            this.automat.Text = "Автомат";
            this.automat.UseVisualStyleBackColor = true;
            this.automat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1005, 715);
            this.Controls.Add(this.automat);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.PasteBtn);
            this.Controls.Add(this.CutBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.UndoBtn);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.CreateFileBtn);
            this.Controls.Add(this.ResultWindow);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повторитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem текстToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постановкаЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грамматикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классификацияГраматикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диагностикаИНейтрализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестовыйПримерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛитературыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исходныйКодПрограммыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пускToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вызовСправкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ResultWindow;
        private System.Windows.Forms.Button CreateFileBtn;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Button SaveFileBtn;
        private System.Windows.Forms.Button UndoBtn;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button CutBtn;
        private System.Windows.Forms.Button PasteBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button automat;
        private System.Windows.Forms.ToolStripMenuItem автоматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сканерToolStripMenuItem;
    }
}

