using ExceptionProjectLibrary;
namespace Exceptionhandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Customer c = new Customer();	
			try
			{
                Console.WriteLine("enter Customer,id ,name ,city");
                c.CustId = Convert.ToInt32(Console.ReadLine());
                c.CustName = Console.ReadLine();
                c.City = Console.ReadLine();

            }
            catch(CustomerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException a)
            {
                Console.WriteLine(a.Source);
            }
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
            finally
            { 
                Console.WriteLine("Finally blocks is callead");
            }
        }
    }
}
