using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomework_1_5
{
    
    public partial class Form1 : Form
    {
        private Random _r = new Random();
        public Form1()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// обработка приближения курсора к кнопке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Left = _r.Next(0, this.ClientSize.Width - button1.Width);
            button1.Top = _r.Next(0, this.ClientSize.Height - button1.Height);
           
        }
    }
}
