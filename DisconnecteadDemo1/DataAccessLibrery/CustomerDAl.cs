using System.Data;
using BuinessLogic_Library;
using Microsoft.Data.SqlClient;

namespace DataAccessLibrery
{
    public class CustomerDAl

    {
        static String cnString = "Data Source=.\\sqlexpress;Initial Catalog=Shopping;User ID=sa;Password=123456;Encrypt=True;Trust Server Certificate=True";

        public CustomerDAl() 
        {
        }
        DataSet ds = null;
       public List<CustomerBAL> GetCustomers()
        {
            DataSet ds = ConnectAndGetData();
           DataTable dt= ds.Tables["dt_customer"];
            List<CustomerBAL> custlist = new List<CustomerBAL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CustomerBAL cust = new CustomerBAL();
                cust.CustomerId = Convert.ToInt32(dt.Rows[i]["CustomerId"]);
                cust.CustName = dt.Rows[i]["CustomerName"].ToString();
                custlist.Add(cust);
                
            }
            return custlist;
        }
        public void insertCustomer(CustomerBAL cust)
        {
            DataSet ds = ConnectAndGetData();
            DataRow drow = ds.Tables["dt_customer"].NewRow();
            drow["CustomerId"] = cust.CustomerId;
            drow["CustomerName"] = cust.CustName;
            ds.Tables["dt_customer"].Rows.Add(drow);

            ConnectandUpdateServer(ds);

        }
        public void updateCustomer(CustomerBAL cust)
        {
            DataSet ds = ConnectAndGetData();
            DataRow drow = ds.Tables["dt_customer"].Rows.Find(cust.CustomerId);
            drow["CustomerId"] = cust.CustomerId;
            drow["CustomerName"] = cust.CustName;
            ConnectandUpdateServer(ds);
        }
       

        public void deleteCustomer(CustomerBAL cust)
        {
           DataSet ds =ConnectAndGetData();
           DataRow drow= ds.Tables["dt_customer"].Rows.Find(cust.CustomerId);
          drow.Delete();
          ConnectandUpdateServer(ds);
        }


        private static void ConnectandUpdateServer(DataSet ds)
        {
            SqlConnection cn = new SqlConnection(cnString);
            SqlDataAdapter da = new SqlDataAdapter("select * from db_CustomerTable", cn);
            SqlCommandBuilder bldr = new SqlCommandBuilder(da);
            da.Update(ds.Tables["dt_customer"]);
        }
        private static DataSet ConnectAndGetData()
        {
            
            SqlConnection cn = new SqlConnection(cnString);
            // sqladapter connection
            SqlDataAdapter da = new SqlDataAdapter("select * from db_CustomerTable", cn);
            // to bring the primary with data to say to dataadpter
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            // given name to data set and query
            DataSet ds =new DataSet();
            da.Fill(ds, "dt_customer");
            return ds;
        }
    }
}
