﻿namespace MedicalReference
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxDiseases = new System.Windows.Forms.ListBox();
            this.textBoxSearchSymptoms = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторИМТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяПоискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBackToDiseases = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.listBoxSearchHistory = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDiseases
            // 
            this.listBoxDiseases.FormattingEnabled = true;
            this.listBoxDiseases.Location = new System.Drawing.Point(0, 77);
            this.listBoxDiseases.Name = "listBoxDiseases";
            this.listBoxDiseases.Size = new System.Drawing.Size(662, 303);
            this.listBoxDiseases.TabIndex = 0;
            this.listBoxDiseases.SelectedIndexChanged += new System.EventHandler(this.listBoxDiseases_SelectedIndexChanged);
            // 
            // textBoxSearchSymptoms
            // 
            this.textBoxSearchSymptoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearchSymptoms.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSearchSymptoms.Location = new System.Drawing.Point(0, 36);
            this.textBoxSearchSymptoms.Multiline = true;
            this.textBoxSearchSymptoms.Name = "textBoxSearchSymptoms";
            this.textBoxSearchSymptoms.Size = new System.Drawing.Size(230, 31);
            this.textBoxSearchSymptoms.TabIndex = 1;
            this.textBoxSearchSymptoms.Text = "Поиск по симптомам";
            this.textBoxSearchSymptoms.Click += new System.EventHandler(this.textBoxSearchSymptoms_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(256, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.калькуляторИМТToolStripMenuItem,
            this.историяПоискаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.аЯToolStripMenuItem.Text = "От большего к меньшему";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(306, 30);
            this.яАToolStripMenuItem.Text = "От меньшего к большему";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.buttonSortZA_Click);
            // 
            // калькуляторИМТToolStripMenuItem
            // 
            this.калькуляторИМТToolStripMenuItem.Name = "калькуляторИМТToolStripMenuItem";
            this.калькуляторИМТToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.калькуляторИМТToolStripMenuItem.Text = "Калькулятор ИМТ";
            this.калькуляторИМТToolStripMenuItem.Click += new System.EventHandler(this.buttonBMICalculator_Click);
            // 
            // историяПоискаToolStripMenuItem
            // 
            this.историяПоискаToolStripMenuItem.Name = "историяПоискаToolStripMenuItem";
            this.историяПоискаToolStripMenuItem.Size = new System.Drawing.Size(164, 29);
            this.историяПоискаToolStripMenuItem.Text = "История поиска";
            this.историяПоискаToolStripMenuItem.Click += new System.EventHandler(this.buttonShowHistory_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonBackToDiseases
            // 
            this.buttonBackToDiseases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToDiseases.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBackToDiseases.Location = new System.Drawing.Point(519, 313);
            this.buttonBackToDiseases.Name = "buttonBackToDiseases";
            this.buttonBackToDiseases.Size = new System.Drawing.Size(135, 28);
            this.buttonBackToDiseases.TabIndex = 5;
            this.buttonBackToDiseases.Text = "Назад";
            this.buttonBackToDiseases.UseVisualStyleBackColor = true;
            this.buttonBackToDiseases.Click += new System.EventHandler(this.buttonBackToDiseases_Click);
            // 
            // listBoxSearchHistory
            // 
            this.listBoxSearchHistory.FormattingEnabled = true;
            this.listBoxSearchHistory.Location = new System.Drawing.Point(0, 77);
            this.listBoxSearchHistory.Name = "listBoxSearchHistory";
            this.listBoxSearchHistory.Size = new System.Drawing.Size(662, 303);
            this.listBoxSearchHistory.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1097, 586);
            this.Controls.Add(this.textBoxSearchSymptoms);
            this.Controls.Add(this.buttonBackToDiseases);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxDiseases);
            this.Controls.Add(this.listBoxSearchHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Список болезней";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDiseases;
        private System.Windows.Forms.TextBox textBoxSearchSymptoms;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторИМТToolStripMenuItem;
        private System.Windows.Forms.Button buttonBackToDiseases;
        private System.Windows.Forms.ToolStripMenuItem историяПоискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListBox listBoxSearchHistory;
    }
}

