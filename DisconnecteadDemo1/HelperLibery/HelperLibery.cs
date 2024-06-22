using BuinessLogic_Library;
using DataAccessLibrery;

namespace HelperLibery
{
    public class CustomerHelper
    {
        CustomerDAl dal = new CustomerDAl();
        public List<CustomerBAL> GetCustomers()
        {
            List<CustomerBAL> custlist = dal.GetCustomers();
            return custlist;
        }
        public void insertCustomer(CustomerBAL cust)
        {
            dal.insertCustomer(cust);
        }
        public void UpdateCustomer(CustomerBAL cust)
        {
            dal.updateCustomer(cust);
        }
        public void deleteCustomer(CustomerBAL cust)
        {
            dal.deleteCustomer(cust);
        }

        }
}
