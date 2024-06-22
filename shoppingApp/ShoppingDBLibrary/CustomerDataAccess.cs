using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using ShoppingBussinessLogicLibrary;

namespace ShoppingDBLibrary
{
    public class CustomerDataAccess
    {
        //connection String to establish connection between shoppingDBlibrery and SqlExpress Server database
        String cnString = "Data Source=.\\sqlexpress;Initial Catalog=Shopping;Persist Security Info=True;User ID=sa;Password=123456;Encrypt=True;Trust Server Certificate=True";
        public void InsertCustomer(CustomerBusinessLogic c)
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("[dbo].sp_NewCustomer", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@p_Custid", c.CustomerId);
            cmd.Parameters.AddWithValue("@p_CustName", c.CustName);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
         
        }
        public void UpdateCustomer( int id , CustomerBusinessLogic c)
        {
            Console.WriteLine(c.CustName );
            Console.WriteLine(id);
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("[dbo].UpdateCustomer", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.Parameters.AddWithValue("@p_Custid", id);
            cmd.Parameters.AddWithValue("@p_CustName", c.CustName);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();

        }
        public CustomerBusinessLogic DeleteCustomer(int id)
        {
            CustomerBusinessLogic c = new CustomerBusinessLogic();
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand cmd = new SqlCommand("select * from  db_CustomerTable where CustomerId=" + id, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                c.CustomerId = Convert.ToInt32(dr[0]);
                c.CustName = dr[1].ToString();
                cn.Close();
                cn.Dispose();
                cmd.Dispose();
                Console.WriteLine("sure you want to delete it");
                char ans = Convert.ToChar(Console.ReadLine());
                if (ans == 'y' || ans == 'Y')
                {
                    cn = new SqlConnection(cnString);
                    cmd = new SqlCommand("[dbo].sp_DeleteCustomer", cn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cn.Open();
                    cmd.Parameters.AddWithValue("@p_Custid", id);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cn.Dispose();
                }
            }
            return c;
        }
        public List<CustomerBusinessLogic> ShowCustomerList() 
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlCommand  cmd=new SqlCommand("select * from  db_CustomerTable",cn );
            cn.Open();
            SqlDataReader dr=cmd.ExecuteReader();
            List<CustomerBusinessLogic> custlist = new List<CustomerBusinessLogic>();
            while (dr.Read())
            {
                CustomerBusinessLogic cust = new CustomerBusinessLogic();
                for (int i = 0; i < 2; i++) 
                {
                    cust.CustomerId = Convert.ToInt32(dr[0].ToString());
                    cust.CustName = dr[1].ToString();
                }
                custlist.Add(cust);
            }
            cmd.Dispose();
            cn.Close();
            cn.Dispose();
            return custlist;
        }
        public CustomerBusinessLogic FindCustomer(int id )
        {
            return null;
        }
         

    }
}
