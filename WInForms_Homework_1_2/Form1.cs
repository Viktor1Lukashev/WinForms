using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInForms_Homework_1_2
{
    public partial class Form1 : Form
    {
        int _LastNumber;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            _LastNumber = rnd.Next(1, 2000);

        }
        private void play()
        {
            DialogResult r = MessageBox.Show($"Ваше число больше {_LastNumber}?", "Qust", MessageBoxButtons.YesNo);
            if (r.ToString() == "Yes")
            {
                rnd.Next(_LastNumber, 2000);

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult r =  MessageBox.Show($"Ваше число больше {_LastNumber}?","Qust",MessageBoxButtons.YesNo);
            if(r.ToString() == "Yes")
            {
                rnd.Next(_LastNumber, 2000);

            }
         
        }
    }
}
