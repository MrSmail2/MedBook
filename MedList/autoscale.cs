using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedList
{
    public class AutoScaleForm : Form
    {
        // Исходный размер формы, на котором делался дизайн (установите свой)
        protected Size DesignSize = new Size(1280, 720);

        // Сохраняем исходные размеры и позиции всех элементов
        private Dictionary<Control, Rectangle> originalLayout = new Dictionary<Control, Rectangle>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SaveOriginalLayout();
            ScaleToScreen();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (WindowState != FormWindowState.Minimized)
                ScaleToScreen();
        }

        private void SaveOriginalLayout()
        {
            originalLayout.Clear();
            foreach (Control control in GetAllControls(this))
            {
                originalLayout[control] = new Rectangle(control.Location, control.Size);
            }
            originalLayout[this] = new Rectangle(Point.Empty, Size);
        }

        private void ScaleToScreen()
        {
            this.SuspendLayout();

            // Вычисляем коэффициенты масштабирования
            float scaleX = (float)Width / DesignSize.Width;
            float scaleY = (float)Height / DesignSize.Height;
            float minScale = Math.Min(scaleX, scaleY);

            // Масштабируем все элементы
            foreach (var item in originalLayout)
            {
                Control control = item.Key;
                Rectangle original = item.Value;

                if (control != this)
                {
                    // Позиция и размер
                    control.Left = (int)(original.X * scaleX);
                    control.Top = (int)(original.Y * scaleY);
                    control.Width = (int)(original.Width * scaleX);
                    control.Height = (int)(original.Height * scaleY);

                    // Масштабируем шрифт (с ограничением минимального/максимального размера)
                    if (control.Font != null)
                    {
                        float newSize = original.Height * minScale / 3.5f;
                        newSize = Math.Max(8, Math.Min(newSize, 24)); // Ограничиваем размер шрифта
                        control.Font = new Font(control.Font.FontFamily, newSize, control.Font.Style);
                    }
                }
            }

            this.ResumeLayout();
        }

        private IEnumerable<Control> GetAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control child in GetAllControls(control))
                    yield return child;
            }
        }
    }
}
