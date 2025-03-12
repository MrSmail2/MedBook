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
            this.listBoxDiseases = new System.Windows.Forms.ListBox();
            this.textBoxSearchSymptoms = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDiseases
            // 
            this.listBoxDiseases.FormattingEnabled = true;
            this.listBoxDiseases.Location = new System.Drawing.Point(-1, 36);
            this.listBoxDiseases.Name = "listBoxDiseases";
            this.listBoxDiseases.Size = new System.Drawing.Size(928, 498);
            this.listBoxDiseases.TabIndex = 0;
            this.listBoxDiseases.SelectedIndexChanged += new System.EventHandler(this.listBoxDiseases_SelectedIndexChanged);
            // 
            // textBoxSearchSymptoms
            // 
            this.textBoxSearchSymptoms.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSearchSymptoms.Location = new System.Drawing.Point(12, 10);
            this.textBoxSearchSymptoms.Name = "textBoxSearchSymptoms";
            this.textBoxSearchSymptoms.Size = new System.Drawing.Size(221, 20);
            this.textBoxSearchSymptoms.TabIndex = 1;
            this.textBoxSearchSymptoms.Text = "Поиск по симптомам";
            this.textBoxSearchSymptoms.Click += new System.EventHandler(this.textBoxSearchSymptoms_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(343, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(213, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.аЯToolStripMenuItem.Text = "А-Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.buttonSortAZ_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.яАToolStripMenuItem.Text = "Я-А";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.buttonSortZA_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearchSymptoms);
            this.Controls.Add(this.listBoxDiseases);
            this.Controls.Add(this.menuStrip1);
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
    }
}

