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
            labelAuthorInfo.Text = @"
Сведения об авторе:
Автор: Мельниченко Иван Александрович, студент 3 курса 1 группы.
Специальность: 09.02.07 'Информационные системы и программирование'.
ЧПОУ 'Анапский индустриальный техникум' филиал в г. Темрюке.
";
            labelProjectInfo.Text = @"
Описание Курсового проекта:
Руководитель: Иванов А. Э.
Тема: Разработка приложения 'Медицинский справочник'
Краткое описание: Медицинский справочник — это приложение, которое позволяет пользователю
искать информацию о болезнях, их симптомах и лечении. Также в приложении
реализован калькулятор индекса массы тела (ИМТ) и возможность изменения
шрифта интерфейса.

2025 г.
";
        }
        private void ApplyFontToControls(Font font)
        {
            // Применяем шрифт к ListBox
            labelAuthorInfo.Font = font;
            labelProjectInfo.Font = font;
            back.Font = font;
        }

           
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Закрываем форму
            this.Close();
        }
    }
}
