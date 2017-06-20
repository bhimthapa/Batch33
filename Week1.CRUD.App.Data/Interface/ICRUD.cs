using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.CRUD.App.Data.Models;

namespace Week1.CRUD.App.Data.Interface
{
   public interface ICRUD
    {
        SqlDataReader ReadAll();
        void Add(Customer obj);
        void Delete(Customer obj);
        void Upadate(Customer obj);
        Customer Find(Customer obj);

    }
}
