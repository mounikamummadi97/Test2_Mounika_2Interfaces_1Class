using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Mounika_2Interfaces_1Class
{
    public class Calculate: Interface2, Interface1 
    {
        public int AddNumber(int x, int y)
        {
            return x + y;
        }
         public int SubtractNumber(int x, int y)
        {
            return x - y + 2;
        }
    }
}
