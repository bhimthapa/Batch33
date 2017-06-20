using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Week1.CRUD.App.Data;
using Week1.CRUD.App.Data.Interface;
using Week1.CRUD.App.Data.Models;

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
               // CustomerDataAcess cusData = new CustomerDataAcess();
                ICRUD dataaccess = new DataAcess();
                Customer cusOBj = new Customer();
                switch (choice)
                {
                    case "1":


                        SqlDataReader rd = dataaccess.ReadAll();
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
                     
                        cusOBj.FirstName = fn;
                        cusOBj.LastName = ln;
                        cusOBj.Email = em;
                        cusOBj.Phone = ph;
                        dataaccess.Add(cusOBj);
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
                       // Customer cusOBj = new Customer();
                        cusOBj.FirstName = ufn;
                        cusOBj.LastName = uln;
                        cusOBj.Email = uem;
                        cusOBj.Phone = uph;
                        cusOBj.Id = Convert.ToInt32(id);
                        dataaccess.Upadate(cusOBj);

                        
                        break;
                    case "4":
                        Console.WriteLine("Enter Id to Delete");
                        string did = Console.ReadLine();
                        cusOBj.Id = Convert.ToInt32(did);
                        dataaccess.Delete(cusOBj);
                        break;
                    case "5":
                        Console.WriteLine("Enter Id to Find");
                        string did1 = Console.ReadLine();
                        cusOBj.Id = Convert.ToInt32(did1);
                       Customer obj= dataaccess.Find(cusOBj);
                        Console.WriteLine("**********************************************");
                        //Console.WriteLine("Id :{0}", obj.Id);
                        Console.WriteLine("First Name :{0}", obj.FirstName);
                        Console.WriteLine("Last Name :{0}", obj.LastName);
                        Console.WriteLine("Email :{0}", obj.Email);
                        Console.WriteLine("Phone Number :{0}", obj.Phone);
                        Console.WriteLine("**********************************************");
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                }

                     }
        }
    }
}
