using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Rec
    {
        public static int Fibonachi(int n)
        {
            if (n > 2)
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
            else
            {
                return 1;
            }
        }
    }
}
