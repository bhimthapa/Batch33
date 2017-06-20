using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.CRUD.App.Data.Models
{
    public abstract class CustomerBase
    {
        public string ConnectionString()
        {
            return @"Data Source=LAPTOP-0HHH4U7K;Initial Catalog=Batch3322;Integrated Security=True";
        }
    }
}
