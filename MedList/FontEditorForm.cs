using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedList
{
    public partial class FontEditorForm : Form
    {
        public FontEditorForm()
        {
            InitializeComponent();

            // Заполняем ComboBox шрифтами
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                comboBoxFont.Items.Add(fontFamily.Name);
            }
            comboBoxFont.SelectedIndex = 0; // Выбираем первый шрифт по умолчанию

            // Заполняем ComboBox размерами шрифта
            for (int i = 8; i <= 24; i += 2)
            {
                comboBoxSize.Items.Add(i);
            }
            comboBoxSize.SelectedIndex = 2; // Выбираем размер 12 по умолчанию
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранный шрифт и размер
                string fontName = comboBoxFont.SelectedItem.ToString();
                float fontSize = float.Parse(comboBoxSize.SelectedItem.ToString());

                // Определяем стиль шрифта
                FontStyle fontStyle = FontStyle.Regular;
                if (checkBoxBold.Checked) fontStyle |= FontStyle.Bold;
                if (checkBoxItalic.Checked) fontStyle |= FontStyle.Italic;

                // Создаем шрифт и сохраняем его в статическом классе
                AppSettings.AppFont = new Font(fontName, fontSize, fontStyle);

                // Закрываем форму с результатом DialogResult.OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выборе шрифта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public static class AppSettings
    {
        public static Font AppFont { get; set; } = new Font("Segoe UI", 8); // Шрифт по умолчанию
    }
}
