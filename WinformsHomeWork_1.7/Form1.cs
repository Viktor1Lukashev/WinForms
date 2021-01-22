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

namespace WinformsHomeWork_1._7
{
    public partial class Form1 : Form
    {
        private Regex _DateCorrect;
        private RadioButton _MyButton; 
       
        public Form1()
        {
            InitializeComponent();
             //регулярным выражением я проверял строку на правильное количество символов
            _DateCorrect = new Regex(@"^\d{2}.\d{2}.\d{4}");
            _MyButton = null;
        }
        /// <summary>
        /// При вызове метода - рассчет и вывод результатов в Label
        /// </summary>
        /// <param name="d"></param>
        public void GetTime(DateTime d)
        {
            if (_MyButton.Name == "OnDay")
            {
                label1.Text = $"Осталось ждать: {(d - DateTime.Now).Days.ToString()} дня(ей)";
            }
            else  if (_MyButton.Name == "OnMinutes")
            {
                label1.Text = $"Осталось ждать: {(d - DateTime.Now).TotalMinutes.ToString()} минут";
            }
            else if (_MyButton.Name == "OnHours")
            {
                label1.Text = $"Осталось ждать: {(d - DateTime.Now).Hours.ToString()} часов";
            }
            else if (_MyButton.Name == "OnMonth")
            {                
            label1.Text = $"Осталось ждать: {(d.Month - DateTime.Now.Month).ToString()} месяцев";
            }
         }
        /// <summary>
        /// проверка введеной даты на корректность
        /// </summary>
        /// <param name="d"></param>
        /// <param name="MyButton"></param>
       private void ChekDate(DateTime d,RadioButton MyButton)
        {
            if(d < DateTime.Now )
            {
                MessageBox.Show("Ваша дата должна быть больше текущей!");
                return;
            }
           else if(MyButton == null)
            {
                MessageBox.Show("Для рассчета вы должны выбрать метод рассчета(в днях, минутах или секундах рассчитывать)");
                return;
            }
            GetTime(d);
        }
        /// <summary>
        /// обработка нажатия кнопки "рассчитать время"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string InputString = textBox1.Text.ToString();
            if (_DateCorrect.IsMatch(InputString))
            {
               
                    ChekDate(DateTime.Parse(InputString),_MyButton);
                    return;
               
            }
            MessageBox.Show("Ошибка! Формат даты должен быть: ДД.ММ.ГГГГ", "Error", MessageBoxButtons.OK);
            textBox1.Text = "";
        }

        /// <summary>
        /// обработака выбора RadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _MyButton = sender as RadioButton;
            if(!_MyButton.Checked) {
                _MyButton = null;


            }
        }
    }
}
