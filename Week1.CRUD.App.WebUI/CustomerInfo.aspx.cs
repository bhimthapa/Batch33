using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Week1.CRUD.App.Data;

namespace Week1.CRUD.App.WebUI
{
    public partial class CustomerInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerDataAcess data = new CustomerDataAcess();
            GridView1.DataSource = data.GetCustomerData();
            GridView1.DataBind();
        }
    }
}