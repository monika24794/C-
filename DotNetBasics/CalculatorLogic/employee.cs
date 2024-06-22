using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class employee
    {
        static int count;
         static employee() {
            count = 0;
        }
        public employee()
        {
            count = 1;
        }
        public employee(int id) { count++ ; }
    }
}
