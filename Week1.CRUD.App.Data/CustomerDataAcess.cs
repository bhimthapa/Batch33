using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
//Step 1 : Import data access libraries


namespace Week1.CRUD.App.Data
{
    public class CustomerDataAcess
    {
        //Step 2 : Create a method to get the data from database table
        public SqlDataReader GetCustomerData()
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Batch33;Integrated Security=True");
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("GetCustomers", conn);

            conn.Open();
            //Step 5: Read database table data
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;

        }

    }
}
