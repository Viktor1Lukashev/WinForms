using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHomework_1_3
{
    public partial class Form1 : Form
    {
        private int _RectangleSize = 10;
        private bool _FlagCtrl;
        public Form1()
        {
            InitializeComponent();
            _FlagCtrl = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CheckControl()
        {
            if(_FlagCtrl)
            {
                this.Close();
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {

                case MouseButtons.Left:
                   if (Control.ModifierKeys == Keys.Control)
                    {
                        this.Close();
                    }
                   else if(e.X<this.ClientRectangle.X + _RectangleSize||e.X >this.ClientRectangle.Width - _RectangleSize||
                        e.Y<this.ClientRectangle.Y+_RectangleSize||e.Y>this.ClientRectangle.Height - _RectangleSize)
                    {
                        this.Text = "клик за пределами прямоугольника";
                    }
                    else if(e.X == this.ClientRectangle.X + _RectangleSize || e.X == this.ClientRectangle.Width - _RectangleSize ||
                        e.Y == this.ClientRectangle.Y + _RectangleSize || e.Y == this.ClientRectangle.Height - _RectangleSize)
                    {
                        this.Text = "клик за пределами прямоугольника";
                    }
                    else
                    {
                        this.Text = "клик внутри прямоугольника";
                    }
                    break;
                case MouseButtons.Right:
                    this.Text = $"Ширина клиентской части {ClientRectangle.Width}, высота клиестской части:{ClientRectangle.Height}";
                    break;
                default:
                    MessageBox.Show("Такой клавиши не предусмотрено!");
                    break;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Координаты курсора: Ш:{e.X.ToString()}В:{e.Y.ToString()}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                _FlagCtrl = true;
            }
             
        }
    }
}
