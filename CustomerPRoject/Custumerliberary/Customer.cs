using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custumerliberary
{
    public class Customer
    {

        private int CustomerId { get; set; }
        private string CustomerName { get; set; }
        private string City { get; set; }

        public Customer()
        {

        }
        public Customer(int _id, string _name, string _city)
        {
            this.CustomerId = _id;
            this.CustomerName = _name;
            this.City = _city;
        }
    }
}
