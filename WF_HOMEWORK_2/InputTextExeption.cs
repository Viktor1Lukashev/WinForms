using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_HOMEWORK_2
{
   public class InputTextExeption:Exception
    {
        public InputTextExeption():base("предупреждение!Сумма за топливо не учитана! Введите кол-во или сумму")
        {
            
        }
    }
}
