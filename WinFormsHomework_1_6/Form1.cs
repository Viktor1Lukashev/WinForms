using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomework_1_6
{
  
    public partial class Form1 : Form
    {
       private Regex _Rx;
        public Form1()
        {
            InitializeComponent();
            _Rx = new Regex(@"^\d{2}.\d{2}.\d{4}");
        }
        public void meth1(DayOfWeek d) 
        {
            switch((int)d)
            {
                case (int)Days.DaysW.Понедельник:
                    label2.Text = Days.DaysW.Понедельник.ToString();
                    break;
                case (int)Days.DaysW.Вторник:
                    label2.Text = Days.DaysW.Вторник.ToString();
                    break;
                case (int)Days.DaysW.Среда:
                    label2.Text = Days.DaysW.Среда.ToString();
                    break;
                case (int)Days.DaysW.Четверг:
                    label2.Text = Days.DaysW.Четверг.ToString();
                    break;
                case (int)Days.DaysW.пятница:
                    label2.Text = Days.DaysW.пятница.ToString();
                    break;
                case (int)Days.DaysW.Суббота:
                    label2.Text = Days.DaysW.Суббота.ToString();
                    break;
                case (int)Days.DaysW.Воскресенье:
                    label2.Text = Days.DaysW.Воскресенье.ToString();
                    break;
                default:
                    MessageBox.Show("Проверьте корректность даты");
                    break;
            }
            
                
        }
        private void check()
        {
            string str = textBox1.Text.ToString();
            if (_Rx.IsMatch(str))
            {
                try
                {
                    meth1(DateTime.Parse(str).DayOfWeek);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте корректность даты");
                    return;
                }
            }
            MessageBox.Show("Ошибка! Формат даты должен быть: ДД.ММ.ГГГГ", "Error", MessageBoxButtons.OK);
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();

        }
    }
}
