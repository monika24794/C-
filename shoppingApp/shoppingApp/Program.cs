using System.Net.Http.Headers;
using HelperLibrery;
using ShoppingBussinessLogicLibrary;
namespace shoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDbHelper helper = new CustomerDbHelper();
            while (true)
            {
                Console.WriteLine("1..Show all customer \n2.insert \n3.Delete \n4.update 7.exit");
                Console.WriteLine("enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:

                        List<CustomerBusinessLogic> custlist = helper.getCustList();
                        foreach (var cust in custlist)
                        {
                            Console.WriteLine(cust.CustomerId);
                            Console.WriteLine(cust.CustName);
                        }
                        break;
                    case 2:
                        CustomerBusinessLogic c = new CustomerBusinessLogic();
                        Console.WriteLine("enter custmerid");
                        c.CustomerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter name");
                        c.CustName = Console.ReadLine();
                        helper.InsertCustomer(c);
                        break;
                    case 3:
                        Console.WriteLine("enter custmerid");
                        int id = Convert.ToInt32(Console.ReadLine());
                        CustomerBusinessLogic c1 = helper.DeleteCustomer(id);
                        Console.WriteLine(c1.CustomerId);
                        Console.WriteLine(c1.CustName);
                        break;
                    case 4:
                        CustomerBusinessLogic c2 = new CustomerBusinessLogic();
                        Console.WriteLine("enter custmerid");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        c2.CustomerId = id2;
                        Console.WriteLine("enter custmername");
                        c2.CustName = Console.ReadLine();
                        helper.UpdateCustomer(id2, c2);

                        break;

                }
            }
        }
    }
}
