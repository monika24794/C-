using Microsoft.Data.SqlClient;
using ShoppingBussinessLogicLibrary;
using ShoppingDBLibrary;


namespace HelperLibrery
{
    public class CustomerDbHelper
    {
        CustomerDataAccess custdal = new CustomerDataAccess();
        public List<CustomerBusinessLogic> getCustList()
        {
        
            List<CustomerBusinessLogic> custs = new List<CustomerBusinessLogic>();
            custs = custdal.ShowCustomerList();
            return custs;
        }
        public void InsertCustomer(CustomerBusinessLogic c)
        {
            custdal.InsertCustomer(c);
        }
        public CustomerBusinessLogic DeleteCustomer(int id)
        {
            CustomerBusinessLogic c=new CustomerBusinessLogic();
            c=custdal.DeleteCustomer(id);   
            return c;
        }
        public void UpdateCustomer(int id, CustomerBusinessLogic c)
        {
            Console.WriteLine("help");
            custdal.UpdateCustomer(id ,c);
        }
    }
}
