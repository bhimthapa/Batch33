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
            
            Console.WriteLine("1 for Display All");
            Console.WriteLine("2 for Add New Record");
            Console.WriteLine("3 for Update");
            Console.WriteLine("4 for Delete");
            Console.WriteLine("5 for Display By Id");
            Console.WriteLine("6 for Exit");
            Console.WriteLine("Enter your Choice....");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":

                    CustomerDataAcess cusData = new CustomerDataAcess();
                    SqlDataReader rd = cusData.GetCustomerData();
                    while(rd.Read())
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
                    Console.WriteLine("Case 2 selected");
                    break;
                case "3":
                    Console.WriteLine("Case 3 selected");
                    break;
                case "4":
                    Console.WriteLine("Case 4 selected");
                    break;
                case "5":
                    Console.WriteLine("Case 5 selected");
                    break;
                case "6":
                    Console.WriteLine("Case 6 selected");
                    break;
            }

            Console.Read();

        }
    }
}
