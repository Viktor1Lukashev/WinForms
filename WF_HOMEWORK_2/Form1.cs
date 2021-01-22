using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HOMEWORK_2
{
    public enum PriceEat
    {
        HamburgerPrice = 40,
        FriPrice = 40,
        ColaPrice = 45,
        HotDogPrice = 35
    }
    
    public partial class Form1 : Form
    {
        private Dictionary<string, double> _ColFuel;
        private int _SummCaffee; //переменная для подсчета суммы в мини-кафе
        private int _SumHotDog;//переменная для подсчета суммы хот-догов
        private int _SumHam;//переменная для подсчета суммы гамбургеров
        private int _SumFri;//переменная для подсчета суммы картохи-фри
        private int _SumCola;//переменная для подсчета суммы колы
        private double _CountMoneyOnFuel;
        private double _SumForDay; // переменная для посчета общей суммы за весь день(общая касса)
        private double _SumForFluent;// переменная для суммы за топливо
        private double _AllPriceFuel; // переменная для количества топлива(при заправке не от кол-ва топлива, а от суммы денег)
        private Timer _Timer; //Таймер, который будет выводить каждые 10 сек после обслуживания 1го клиента вопрос(появился ли след?)



        public Form1()
        {
            InitializeComponent();
            BaseValues(); // так как есть пункт, что нужно сбрасывать значения формы по -умолчанию
                            //я вынес все значения стандартные в отдельный метод и вызываю его в конструкторе
                            //потом можно будет вызвать его из кода.(ушел от дублирования)

        }

        /// <summary>
        /// Метод - обработчик Таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Timer_Tick(object sender, EventArgs e)
        {
            this.Enabled = false;
            _Timer.Stop();
            DialogResult result = MessageBox.Show("Появился новый клиент?", "Сообщение", MessageBoxButtons.YesNo);
            //DialogResult будет содержать ответ от пользователя
            if (result.ToString() == "Yes")
            {
                this.Enabled = true;

                _Timer.Stop();
                BaseValues();//если появился новый покупатель - сбрасываем значения всей формы
                return;
            }
            //иначе запускаем таймер опять
            this.Enabled = true;
            _Timer.Start();    
        }
        /// <summary>
        /// Инициализация данных при загрузке формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var i in _ColFuel)
            {
                this.Fluents.Items.Add(i.Key);
            }
            SectionCaffe.Text = "";
        }
        /// <summary>
        /// обработчик выбора поля "Количество"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Fluents.Text != "")
            {
                CountFuel.Enabled = true;
                texMoney.Enabled = false;
                SectionPay1.Text = "К оплате";
            }            
        }
        /// <summary>
        /// обработчик выбора поля "Сумма"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Fluents.Text!= "")
            {
                CountFuel.Text = "";
                FluentSumLabel.Text = "";
                texMoney.Enabled = true;
                CountFuel.Enabled = false;
                SectionPay1.Text = "К выдаче";
            }
            
        }
        /// <summary>
        /// Обработчик выбора конкретной марки топлива из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var i in _ColFuel)
            {
                if (i.Key == Fluents.Text)
                {

                    PriceFuel.Text = i.Value.ToString();

                }
                if (radioButton1.Checked)
                    CountFuel.Enabled = true;
                else if (radioButton2.Checked)
                    texMoney.Enabled = true;

            }
        }
        /// <summary>
        /// Обработчик ввода значения в поле "Количество"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountFuel_TextChanged(object sender, EventArgs e)
        {
        if (EnableDisableButton(sender))
            {
            _SumForFluent = double.Parse(CountFuel.Text) * double.Parse(PriceFuel.Text);
            _SumForFluent = Math.Round(_SumForFluent, 2);
            button1.Enabled = true;
            return;
            }
           

        }
        /// <summary>
        /// Метод - обработчик ввода значения в поле Количество в области "мини-кафе"
        /// </summary>
        /// <param name="box"></param>
        /// <param name="text"></param>
        /// <param name="sumProduct"></param>
        public void CheckEat(CheckBox box, TextBox text, TextBox sumProduct)
        {
            if (box.Checked == true)
            {

                text.Enabled = true;

                return;
            }

            text.Enabled = false;

            text.Text = "";
        }
        /// <summary>
        /// обработчик ввода количества Колы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            CheckEat(checkCola, CountCola, PrCola);
        }
        /// <summary>
        /// обработчик выбора checkbox хот-догов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckHotDog_CheckedChanged(object sender, EventArgs e)
        {
           
            CheckEat(CheckHotDog, CountHotDog, PrHotDog);
        }
        /// <summary>
        /// обработчик выбора checkbox гамбургеров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkHam_CheckedChanged(object sender, EventArgs e)
        {
            CheckEat(checkHam, CountHam, PrHam);
        }
        /// <summary>
        ///  обработчик выбора checkbox картохи-фри
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckFri_CheckedChanged(object sender, EventArgs e)
        {

            CheckEat(CheckFri, CountFri, PrFri);
        }
        /// <summary>
        /// делает поле ввода количества хот-догов доступным 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountHotDog_TextChanged(object sender, EventArgs e)
        {
            if (EnableDisableButton(sender))
                Work(ref _SumHotDog, PrHotDog, CountHotDog, CheckHotDog);

        }
        /// <summary>
        /// Метод обрабатывает итоговые результаты заказа в кафе
        /// </summary>
        /// <param name="sum"></param>
        /// <param name="t"></param>
        /// <param name="m"></param>
        /// <param name="b"></param>
        private void Work(ref int sum, TextBox t, TextBox m, CheckBox b)
        {
            if (b.Checked)
            {
                if (m.Text != "")
                {

                    sum = int.Parse(t.Text) * int.Parse(m.Text);

                    _SummCaffee = _SumHam + _SumFri + _SumCola + _SumHotDog;
                   
                    return;
                }
                _SummCaffee -= sum;
                
                sum = 0;
            }
            _SummCaffee -= sum;           
            sum = 0;
        }
        /// <summary>
        /// метод обработки покупки Гамбургеров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountHam_TextChanged(object sender, EventArgs e)
        {
            if(EnableDisableButton(sender))
            Work(ref _SumHam, PrHam, CountHam, checkHam);
        }
        /// <summary>
        /// При событии покупке картохи-фри
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountFri_TextChanged(object sender, EventArgs e)
        {
            if (EnableDisableButton(sender))
                Work(ref _SumFri, PrFri, CountFri, CheckFri);
        }
        /// <summary>
        /// При покупке колы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountCola_TextChanged(object sender, EventArgs e)
        {
            if (EnableDisableButton(sender))
                Work(ref _SumCola, PrCola, CountCola, checkCola);
        }
        /// <summary>
        /// Устанавливает все значения формы по - умолчанию
        /// </summary>
        private void BaseValues()
        {
           
            _Timer = new Timer();
            _ColFuel = new Dictionary<string, double>();
            Fluents.Text = "";
            PriceFuel.Text = "";
            CountFuel.Text = "";
            texMoney.Text = "";
            CountHotDog.Text = "";
            CountHam.Text = "";
            AllSum.Text = "";
            CountFri.Text = "";
            CountCola.Text = "";
            FluentSumLabel.Text = "";
            SectionCaffe.Text = "";
            button1.Enabled = false;
            CheckHotDog.Checked = false;
            checkCola.Checked = false;
            checkHam.Checked = false;
            CheckFri.Checked = false;
            PrHotDog.Enabled = false;
            _ColFuel.Add("АИ-92", 44.90);
            _ColFuel.Add("АИ-95", 52.40);
            PrHotDog.Text = "35";
            PrHam.Enabled = false;
            PrHam.Text = PriceEat.HamburgerPrice.ToString("d");
            PrFri.Enabled = false;
            PrFri.Text = PriceEat.FriPrice.ToString("d");
            PrCola.Enabled = false;
            PrCola.Text = PriceEat.ColaPrice.ToString("d"); ;
            CountFuel.Enabled = false;
            texMoney.Enabled = false;
            radioButton1.Checked = false;
            radioButton1.Checked = false;
            texMoney.Text = "";
            Fluents.Text = "";
            
            CountHotDog.Enabled = false;
            CountHam.Enabled = false;
            CountFri.Enabled = false;
            CountCola.Enabled = false;
            _CountMoneyOnFuel = 0;
            _Timer.Interval = 10000;
            _Timer.Tick += _Timer_Tick;

        }
        /// <summary>
        /// Метод обрабатывает событие "Рассчитать сумму"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FluentSumLabel.Text = _SumForFluent.ToString();
                AllSum.Text = $"{(_SumForFluent + Convert.ToDouble(_SummCaffee)).ToString()} рублей";
            }
            else if(radioButton2.Checked)
            {
                FluentSumLabel.Text = _AllPriceFuel.ToString();
                AllSum.Text = $"{(_SumForFluent + Convert.ToDouble(_SummCaffee)).ToString()} литра(ов)";
            }
                SectionCaffe.Text = _SummCaffee.ToString();
                _SumForDay += ( _SumForFluent+ Convert.ToDouble(_SummCaffee));
                this.Text = _SumForDay.ToString();
        }
        /// <summary>
        /// Метод обработки ввода Суммы при покупки топлива
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void texMoney_TextChanged(object sender, EventArgs e)
        {
            if (EnableDisableButton(sender))
            {
              
               _SumForFluent = double.Parse(texMoney.Text);

                _AllPriceFuel = Math.Round((double.Parse(texMoney.Text) / double.Parse(PriceFuel.Text)),2);
                button1.Enabled = true; //при введении суммы - становится активна кнопка "Всего к оплате"
                return;
            }
            

        }
        /// <summary>
        /// Метод запрещающий вводить все кроме цифр и Backspace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountFuel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// При выводе общей стоимости за все - запустить таймер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllSum_TextChanged(object sender, EventArgs e)
        {
            if (AllSum.Text != "")
            {
                _Timer.Start();
            }
        }
        /// <summary>
        /// Обработка кнопки "Закрыть смену"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            _Timer.Stop();
            BaseValues();
            MessageBox.Show($"за {DateTime.Now.ToShortDateString()} в кассе: {_SumForDay} рублей");
        }
        private bool EnableDisableButton(object sender)
        {
            TextBox box  = sender as TextBox;
            if(box.Text != "")
            {
                button1.Enabled = true;
                return true;
            }

            return false;
        }
    }
}

