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

        public void AddNewCustomer(string fn,string ln,string email, string phone)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Batch33;Integrated Security=True");
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("AddNewCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = fn;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = ln;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 12).Value = phone;

            cmd.ExecuteNonQuery();
 


        }

        public void UpdateNewCustomer(string fn, string ln, string email, string phone, int id)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Batch33;Integrated Security=True");
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("UpdateNewCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = fn;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = ln;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 12).Value = phone;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();



        }


        public void DeleteCustomer(int id)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Batch33;Integrated Security=True");
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            cmd.ExecuteNonQuery();



        }




    }
}
