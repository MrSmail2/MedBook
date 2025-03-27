using System;
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
        private List<SearchHistoryItem> searchHistory = new List<SearchHistoryItem>(); // История поиска

        public MainForm()
        {
            InitializeComponent();
            LoadDiseases();
            ApplyFontToControls(AppSettings.AppFont);
            listBoxSearchHistory.Visible = false;
            buttonBackToDiseases.Visible = false;

            // Запрет изменения размера
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Можно оставить кнопку "Свернуть"

        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Создаем и открываем форму "Справка"
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
        private void buttonFontEditor_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = AppSettings.AppFont; // Или Properties.Settings.Default.AppFont

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Сохраняем выбранный шрифт
                AppSettings.AppFont = fontDialog1.Font; // Вариант 1
                                                        // ИЛИ:
                                                        // Properties.Settings.Default.AppFont = fontDialog1.Font; // Вариант 2
                                                        // Properties.Settings.Default.Save(); // Сохраняем настройки

                // Применяем шрифт ко всем открытым формам
                ApplyFontToAllForms(fontDialog1.Font);
            }
        }
        // Метод для применения шрифта ко всем формам
        private void ApplyFontToAllForms(Font newFont)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Font = newFont;
                // Если нужно обновить шрифт вложенных элементов:
                UpdateControlsFont(form.Controls, newFont);
            }
        }

        // Рекурсивное обновление шрифта у всех элементов управления
        private void UpdateControlsFont(Control.ControlCollection controls, Font newFont)
        {
            foreach (Control control in controls)
            {
                control.Font = newFont;
                if (control.HasChildren)
                {
                    UpdateControlsFont(control.Controls, newFont);
                }
            }
        }
        private void ApplyFontToControls(Font font)
        {
            // Применяем шрифт к ListBox
            listBoxDiseases.Font = font;

            // Применяем шрифт к TextBox (если есть)
            textBoxSearchSymptoms.Font = font;

        }
        private void LoadDiseases()
        {
            try
            {
                string path = Path.Combine("Zabolevania", "zabolevania_space.json");

                // Проверяем, существует ли файл
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл diseases.json не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Читаем файл
                string json = File.ReadAllText(path);
                diseases = JsonConvert.DeserializeObject<List<Disease>>(json);
                
                LoadSearchHistory();

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
            
            if (string.IsNullOrWhiteSpace(searchText) || searchText == "поиск по симптомам")
            {
                UpdateDiseasesListBox(); // Обновляем ListBox с полным списком заболеваний
                return;
            }

            // Добавляем запись в историю поиска
            searchHistory.Add(new SearchHistoryItem(searchText, DateTime.Now));
            SaveSearchHistory();
            // Очищаем ListBox перед поиском
            listBoxDiseases.Items.Clear();

            // Ищем болезни, у которых симптомы или название содержат введенный текст
            foreach (var disease in diseases)
            {
                bool matchesName = disease.DiseaseName.ToLower().Contains(searchText); // Поиск по названию
                bool matchesSymptoms = disease.DiseaseData.Symptoms != null &&
                                       disease.DiseaseData.Symptoms.ToLower().Contains(searchText); // Поиск по симптомам

                if (matchesName || matchesSymptoms)
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
        public class SearchHistoryItem
        {
            public string Symptoms { get; set; } // Симптомы
            public DateTime SearchTime { get; set; } // Время поиска

            public SearchHistoryItem(string symptoms, DateTime searchTime)
            {
                Symptoms = symptoms;
                SearchTime = searchTime;
            }

            // Переопределяем ToString для удобного вывода
            public override string ToString()
            {
                return $"{SearchTime:yyyy-MM-dd HH:mm:ss}: {Symptoms}";
            }
        }
        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            // Скрываем основной ListBox
            listBoxDiseases.Visible = false;

            // Показываем ListBox с историей поиска
            listBoxSearchHistory.Visible = true;

            // Показываем кнопку "Вернуться к списку болезней"
            buttonBackToDiseases.Visible = true;

            // Очищаем ListBox с историей поиска
            listBoxSearchHistory.Items.Clear();

            // Добавляем историю поиска в ListBox
            foreach (var item in searchHistory)
            {
                listBoxSearchHistory.Items.Add(item.ToString());
            }
        }

        private void buttonBackToDiseases_Click(object sender, EventArgs e)
        {
            // Скрываем ListBox с историей поиска
            listBoxSearchHistory.Visible = false;

            // Показываем основной ListBox
            listBoxDiseases.Visible = true;

            // Скрываем кнопку "Вернуться к списку болезней"
            buttonBackToDiseases.Visible = false;
        }
        private void LoadSearchHistory()
        {
            try
            {
                // Путь к файлу с историей поиска
                string path = Path.Combine("Zabolevania", "searchHistory.json");

                // Проверяем, существует ли файл
                if (!File.Exists(path))
                {
                    return; // Файл не существует, пропускаем загрузку
                }

                // Читаем JSON из файла
                string json = File.ReadAllText(path);

                // Десериализуем JSON в список истории поиска
                searchHistory = JsonConvert.DeserializeObject<List<SearchHistoryItem>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке истории поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveSearchHistory()
        {
            try
            {
                // Путь к файлу с историей поиска
                string path = Path.Combine("Zabolevania", "searchHistory.json");

                // Сериализуем историю поиска в JSON
                string json = JsonConvert.SerializeObject(searchHistory, Formatting.Indented);

                // Сохраняем JSON в файл
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении истории поиска: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
