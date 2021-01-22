using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsHomeWork_1._7
{
   public class LowDateException:Exception
    {
        public LowDateException(string s): base(s)
        {

        }
    }
}
