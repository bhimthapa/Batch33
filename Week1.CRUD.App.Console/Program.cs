using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Week1.CRUD.App.Data;

namespace Week1.CRUD.App.Console_App

{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("1 for Display All");
                Console.WriteLine("2 for Add New Record");
                Console.WriteLine("3 for Update");
                Console.WriteLine("4 for Delete");
                Console.WriteLine("5 for Display By Id");
                Console.WriteLine("6 for Exit");
                Console.WriteLine("Enter your Choice....");
                string choice = Console.ReadLine();
                CustomerDataAcess cusData = new CustomerDataAcess();
                switch (choice)
                {
                    case "1":


                        SqlDataReader rd = cusData.GetCustomerData();
                        while (rd.Read())
                        {
                            Console.WriteLine("**********************************************");
                            Console.WriteLine("Id :{0}", rd.GetInt32(0));
                            Console.WriteLine("First Name :{0}", rd.GetString(1));
                            Console.WriteLine("Last Name :{0}", rd.GetString(2));
                            Console.WriteLine("Email :{0}", rd.GetString(3));
                            Console.WriteLine("Phone Number :{0}", rd.GetString(4));
                            Console.WriteLine("**********************************************");
                        }


                        break;

                    case "2":
                        Console.WriteLine("Enter First Name");
                        string fn = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string ln = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string em = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number");
                        string ph = Console.ReadLine();
                        cusData.AddNewCustomer(fn, ln, em, ph);
                        break;
                    case "3":
                        Console.WriteLine("Enter Id to Update");
                        string id = Console.ReadLine();
                        Console.WriteLine("Enter First Name");
                        string ufn = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        string uln = Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string uem = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number");
                        string uph = Console.ReadLine();
                        cusData.UpdateNewCustomer(ufn, uln, uem, uph, Convert.ToInt32(id));
                        break;
                    case "4":
                        Console.WriteLine("Enter Id to Delete");
                        string did = Console.ReadLine();
                        cusData.DeleteCustomer(Convert.ToInt32(did));
                        break;
                    case "5":
                        Console.WriteLine("Case 5 selected");
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                }

                     }
        }
    }
}
