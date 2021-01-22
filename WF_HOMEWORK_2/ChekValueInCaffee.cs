using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HOMEWORK_2
{
  public  class ChekValueInCaffee
    {
        
      public static void method(CheckBox box, TextBox text, int sum)
        {
            if (box.Checked == true)
            {
                
                text.Enabled = true;
                
                return;
            }
            
            text.Enabled = false;
            text.Text = "";
        }
    }
    }

