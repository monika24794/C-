using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndJaggeadArray
{ 
    internal class Products
    {
        public String[] productNames = new string[5] { "tea", "coffe", "biscuits", "water", "milk" };

        public String this[int index]
        {
            get 
            {
                return productNames[index];
            }
            set
            {
                productNames[index] = value;
            }
        }

    }
}
