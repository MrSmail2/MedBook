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

           // ApplyFontToControls(AppSettings.AppFont);

            

            // Запрет изменения размера
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true; // Можно оставить кнопку "Свернуть"



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
