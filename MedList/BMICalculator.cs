using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedList
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();

            ApplyFontToControls(AppSettings.AppFont);

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false; // Скрыть заголовки столбцов
            dataGridView1.BorderStyle = BorderStyle.None; // Убрать границу таблицы
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Добавление столбцов
            dataGridView1.Columns.Add("Column1", "Индекс массы тела");
            dataGridView1.Columns.Add("Column2", "Соответствие между массой человека и его ростом");

            // Добавление столбцов
            dataGridView1.Rows.Add("16 и менее", "Выраженный дефицит массы тела");
            dataGridView1.Rows.Add("16-18,5", "Недостаточная (дефицит) масса тела");
            dataGridView1.Rows.Add("18,5-25", "Норма");
            dataGridView1.Rows.Add("25-30", "Избыточная масса тела (предожирение)");
            dataGridView1.Rows.Add("30-35", "Ожирение первой степени");
            dataGridView1.Rows.Add("35-40", "Ожирение второй степени");
            dataGridView1.Rows.Add("40 и более", "Ожирение третьей степени (морбидное)");



        }
        private void ApplyFontToControls(Font font)
        {
            // Применяем шрифт к TextBox
            textBoxWeight.Font = font;
            textBoxHeight.Font = font;

            // Применяем шрифт к Label
          
            labelResult.Font = font;

            // Применяем шрифт к Button
            buttonCalculate.Font = font;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем вес и рост из TextBox
                double weight = double.Parse(textBoxWeight.Text);
                double height = double.Parse(textBoxHeight.Text) / 100; // Переводим рост в метры

                // Рассчитываем ИМТ
                double bmi = weight / (height * height);

                // Отображаем результат
                labelResult.Text = ($"Ваш ИМТ: {bmi:F2}"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода данных. Убедитесь, что вес и рост введены корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxWeight_Click(object sender, EventArgs e)
        {
            if (textBoxWeight.Text == "Вес (кг)")
            {
                textBoxWeight.Text = "";
                textBoxWeight.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBoxHeight_Click(object sender, EventArgs e)
        {
            if (textBoxHeight.Text == "Рост (см)")
            {
                textBoxHeight.Text = "";
                textBoxHeight.ForeColor = SystemColors.WindowText;
            }
        }

      
    }
}
