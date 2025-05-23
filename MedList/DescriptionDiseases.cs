﻿using MedList;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace MedicalReference
{
    public partial class DiseaseDetailsForm : AutoScaleForm
    {
        public DiseaseDetailsForm(string diseaseName)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;


            DesignSize = new Size(1280, 720);

            // Настройка полноэкранного режима
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Улучшаем производительность для сложных форм
            this.DoubleBuffered = true;

            

            // Запрет изменения размера
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Можно оставить кнопку "Свернуть"
            // Запрет изменения размера
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Можно оставить кнопку "Свернуть"

            this.Text = diseaseName;

            textBoxDiseaseInfo.ReadOnly = true;
            textBoxDiseaseInfo.HideSelection = true;

            //ApplyFontToControls(AppSettings.AppFont);
        }
        
        // Метод для установки данных о болезни
        public void SetDiseaseInfo(string aboutDisease, string symptoms, string treatment)
        {
            string diseaseInfo = "";

            // Добавляем описание, если оно не null
            if (!string.IsNullOrEmpty(aboutDisease))
            {
                diseaseInfo += $"Описание:{Environment.NewLine}{aboutDisease}{Environment.NewLine}{Environment.NewLine}";
            }

            // Добавляем симптомы, если они не null
            if (!string.IsNullOrEmpty(symptoms))
            {
                diseaseInfo += $"Симптомы:{Environment.NewLine}{symptoms}{Environment.NewLine}{Environment.NewLine}";
            }

            // Добавляем лечение, если оно не null
            if (!string.IsNullOrEmpty(treatment))
            {
                diseaseInfo += $"Лечение:{Environment.NewLine}{treatment}{Environment.NewLine}{Environment.NewLine}";
            }

            // Устанавливаем текст в TextBox
            textBoxDiseaseInfo.Text = diseaseInfo;
            textBoxDiseaseInfo.BackColor = SystemColors.Window;

            textBoxDiseaseInfo.SelectionStart = 0; // Устанавливаем курсор в начало
            textBoxDiseaseInfo.SelectionLength = 0; // Сбрасываем выделение
        }
    }
}