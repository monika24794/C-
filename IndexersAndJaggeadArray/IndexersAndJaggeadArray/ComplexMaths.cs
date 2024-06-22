using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersAndJaggeadArray
{
    public class ComplexMaths
    {

        int[] arr = new int[10];
        public int this[int index,bool squre]
        {
            get 
            { 
            
            if(squre)
                {
                    return arr[index]* arr[index]; 
                }
            else {
                    return arr[index];
                }
            }
            set
            {
                /* set the specified index to value here */
                if (squre)
                {
                    arr[index] = (int)Math.Sqrt(value);   
                }
                else
                {
                    arr[index]=value;
                }
            }
        }
    }
}
