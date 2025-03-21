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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            ApplyFontToControls(AppSettings.AppFont);

            // Устанавливаем текст с информацией
            labelInfo.Text = @"
Разработчик: Мельниченко Иван Александрович
Курс: 3
Группа: ИСИП - 1 - 22
Специальность: Информационные системы и прагроммирование
Тема курсового проекта: Медицинский справочник
Руководитель: Иванов Адель Эдуардович
Год разработки: 2025

Краткое описание проекта:
Медицинский справочник — это приложение, которое позволяет пользователю
искать информацию о болезнях, их симптомах и лечении. Также в приложении
реализован калькулятор индекса массы тела (ИМТ) и возможность изменения
шрифта интерфейса.
";
        }
        private void ApplyFontToControls(Font font)
        {
            // Применяем шрифт к ListBox
            labelInfo.Font = font;
            back.Font = font;
        }

           
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }
    }
}
