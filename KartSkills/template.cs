using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class template : Form
    {
        public template()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void template_Load(object sender, EventArgs e)
        {
           

          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //Создаем новый экземпляр типа DateTime для хранения время начала события
            DateTime finishdate = new DateTime(2021, 10, 1, 9, 0, 0);
            //Вычисляем текущее время и время начала события
            TimeSpan result = finishdate - DateTime.Now;
            /*
              Проверяем условие, если finishade (врмя начало события) меньше или равно текущей дате и время (берется с компьютерем)
             */
            if (finishdate <= System.DateTime.Now)
            {
            // в элементе Label (индетификатором l_timer) в свойство Text добавляем  сообщение Событие уже началось
                l_timer.Text = "Событие уже началось";
            }
            else
            {
            // В элемент Label ((индетификатором l_timer) в свойство Text добавляем сообщение которое так же принимается переменную result для отображения даты и времени
                l_timer.Text = "До события осталось: " + result.Days + " дней " + result.Hours + " часов " + result.Minutes + " минут " + result.Seconds + " секунд ";
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
