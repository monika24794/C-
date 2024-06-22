

namespace ExceptionProjectLibrary
{
    public class Customer
    {
        int _custid;
        string _custname;
        string _custcity;
        public int CustId 
        {
            get { 
                return _custid;
            } 
            set { 
              if(value > 0 && value < 2000)
                {
                    _custid = value;
                }
              else if(value > 2000)
                {
                    throw new CustomerNotFoundException("this customer not found");
                }
              else
                {
                    throw new ArgumentNullException("customerId must be a positive number");
                }
                   
            } 
        }
        public string CustName
        {
            get { 
                return _custname; 
            } 
            set { 
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("customername can not be Empty");
                }
                else
                {
                    _custname = value;
                }
               
            }
        }
        public string City 
        { 
            get { 
                return _custcity; 
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("customer city can not be Empty");
                }
                else
                {
                    _custcity = value;
                }
             
            }
        }

       


    }
}
