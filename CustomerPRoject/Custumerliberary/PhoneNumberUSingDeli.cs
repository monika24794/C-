using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custumerliberary
{
    public class PhoneNumberUSingDeli
    {
        Dictionary<int, string> dictobj = new Dictionary<int, string>();

        public void populataeEntries()
        {
            dictobj.Add(123654, "monika");
            dictobj.Add(9875643, "chetana");
            dictobj.Add(478987, "aditya");
            dictobj.Add(485987, "ananya");
            dictobj.Add(423687, "bhina");

            foreach (var item in dictobj)
            {
                Console.WriteLine(item);
            }
            
        }
        public void AddData(int key, string value)
        {
            dictobj.Add(key, value);
        }
        public void Display()
        {

            foreach (var entry in dictobj)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
        public string Findname(int key)
        {
            string name = (string)dictobj[key];
            return name;

        }
    }
}
