using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Week1.CRUD.App.Data.Models;
using Week1.CRUD.App.Data.Interface;
//Step 1 : Import data access libraries


namespace Week1.CRUD.App.Data.Models
{
    public class DataAcess : CustomerBase,ICRUD
    {
      
     public SqlDataReader ReadAll()
        {

            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection(base.ConnectionString());
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("GetCustomers", conn);

            conn.Open();
            //Step 5: Read database table data
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

        public void Add(Customer obj)
        {
            SqlConnection conn = new SqlConnection(base.ConnectionString());
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("AddNewCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = obj.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = obj.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = obj.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 12).Value = obj.Phone;

            cmd.ExecuteNonQuery();
        }

        public void Delete(Customer obj)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection(base.ConnectionString());
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("DeleteCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;

            cmd.ExecuteNonQuery();
        }

        public void Upadate(Customer obj)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection(base.ConnectionString());
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("UpdateNewCustomer", conn);

            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = obj.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = obj.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = obj.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 12).Value = obj.Phone;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;

            cmd.ExecuteNonQuery();
        }

        public Customer Find(Customer obj)
        {
            // Step  3: Configure connection string
            SqlConnection conn = new SqlConnection(base.ConnectionString());
            //Step 4: Invoke storedprocedure
            SqlCommand cmd = new SqlCommand("FIndCustomerByID", conn);
             conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
            //Step 5: Read database table data
            SqlDataReader rd = cmd.ExecuteReader();
            Customer objCus = new Models.Customer();
            while(rd.Read())
            {
                objCus.FirstName = rd.GetString(1);
                objCus.LastName = rd.GetString(2);
                objCus.Email = rd.GetString(3);
                objCus.Phone = rd.GetString(4);
            }
            return objCus;
        }
    }
}
