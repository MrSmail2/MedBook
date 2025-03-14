﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Lifetime;
using System.Windows.Forms;
using MedList;
using Newtonsoft.Json;

namespace MedicalReference
{
    public partial class MainForm : Form
    {
        private List<Disease> diseases;

        public MainForm()
        {
            InitializeComponent();
            LoadDiseases();
        }

        private void LoadDiseases()
        {
            try
            {
                string path = Path.Combine("Zabolevania", "zabolevania.json");

                // Проверяем, существует ли файл
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл diseases.json не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Читаем файл
                string json = File.ReadAllText(path);
                diseases = JsonConvert.DeserializeObject<List<Disease>>(json);
               

                foreach (var disease in diseases)
                {
                    listBoxDiseases.Items.Add(disease.FirstHeader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        private void listBoxDiseases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDiseases.SelectedIndex != -1)
            {
                var selectedDisease = diseases[listBoxDiseases.SelectedIndex];

                // Создаем новую форму и передаем данные о болезни
                DiseaseDetailsForm detailsForm = new DiseaseDetailsForm(selectedDisease.FirstHeader);
                detailsForm.SetDiseaseInfo(
                    selectedDisease.DiseaseData.AboutDisease,
                    selectedDisease.DiseaseData.Symptoms,
                    selectedDisease.DiseaseData.Treatment
                );

                // Открываем новую форму
                detailsForm.ShowDialog();
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Получаем введенные симптомы
            string searchText = textBoxSearchSymptoms.Text.ToLower(); // Приводим к нижнему регистру для удобства поиска

            // Очищаем ListBox перед поиском
            listBoxDiseases.Items.Clear();

            // Ищем болезни, у которых симптомы содержат введенный текст
            foreach (var disease in diseases)
            {
                if (disease.DiseaseData.Symptoms != null && disease.DiseaseData.Symptoms.ToLower().Contains(searchText))
                {
                    listBoxDiseases.Items.Add(disease.DiseaseName);
                }
            }

            // Если ничего не найдено, выводим сообщение
            if (listBoxDiseases.Items.Count == 0)
            {
                MessageBox.Show("Болезни с такими симптомами не найдены.", "Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchSymptoms_Click(object sender, EventArgs e)
        {
            if (textBoxSearchSymptoms.Text == "Поиск по симптомам")
            {
                textBoxSearchSymptoms.Text = "";
                textBoxSearchSymptoms.ForeColor = SystemColors.WindowText;
            }
        }
        private void UpdateDiseasesListBox()
        {
            // Очищаем ListBox
            listBoxDiseases.Items.Clear();

            // Добавляем болезни в ListBox
            foreach (var disease in diseases)
            {
                listBoxDiseases.Items.Add(disease.FirstHeader);
            }
        }

        private void SortDiseasesAZ()
        {
            // Сортируем список болезней по названию (от А до Я)
            diseases.Sort((d1, d2) => string.Compare(d1.FirstHeader, d2.FirstHeader, StringComparison.OrdinalIgnoreCase));

            // Обновляем ListBox
            UpdateDiseasesListBox();
        }

        private void SortDiseasesZA()
        {
            // Сортируем список болезней по названию (от Я до А)
            diseases.Sort((d1, d2) => string.Compare(d2.FirstHeader, d1.FirstHeader, StringComparison.OrdinalIgnoreCase));

            // Обновляем ListBox
            UpdateDiseasesListBox();
        }

        private void buttonSortAZ_Click(object sender, EventArgs e)
        {
            SortDiseasesAZ();
        }

        private void buttonSortZA_Click(object sender, EventArgs e)
        {
            SortDiseasesZA();
        }
        private void buttonBMICalculator_Click(object sender, EventArgs e)
        {
            // Создаем и открываем форму калькулятора ИМТ
            BMICalculatorForm bmiForm = new BMICalculatorForm();
            bmiForm.ShowDialog();
        }
    }

}
    
    public class DiseaseData
    {
        public string AboutDisease { get; set; }
        public string Symptoms { get; set; }
        public string Treatment { get; set; }
    }

    public class Disease
    {
        public string FirstHeader { get; set; }
        public string DiseaseName { get; set; }
        public DiseaseData DiseaseData { get; set; }
    }
