using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Homework1
{
    public partial class Form1 : Form
    {
        private string? _Name;
        private int? _Age;
        private string? _Profession;
        private int _Count;


        public Form1()
        {
            InitializeComponent();
            _Count = 0;
        }

        
        /// <summary>
        /// кнопка "сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (Check(this.textBox1.Text, this.textBox2.Text, this.textBox3.Text))
                {
                    _Age = int.Parse(this.textBox3.Text);
                    _Name = this.textBox1.Text;
                    _Profession = this.textBox2.Text;
                    _Count = _Age.ToString().Length + _Profession.Length + _Name.Length;
                    MessageBox.Show("Данные успешно сохранены! Для просмотра готового резюме нажмите 'показать резюме'");
                }
                else
                    MessageBox.Show("Вы не заполнили все данные. сохранить не удалось!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// кнопка "показать резюме"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(_Name, _Profession, _Age.ToString()))
            {
                MessageBox.Show($"Имя: { _Name}");
                MessageBox.Show($"возраст - {_Age} лет ");
                MessageBox.Show($"специальность- {_Profession} ", (_Count / 3).ToString());
                
            }
            else
            {
                MessageBox.Show("Анкета пуста! заполните все поля и нажмите клавишу 'сохранить'");
            }
        }
        /// <summary>
        /// метод проверки вводимых данных перед сохранением
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Profession"></param>
        /// <param name="Age"></param>
        /// <returns></returns>
        private bool Check(string? Name, string? Profession, string? Age)
        {
            if (Name == null || Profession == null || Age == null)
                return false;
            else if (!Name.Any() || !Age.Any() || !Profession.Any())
                return false;
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
