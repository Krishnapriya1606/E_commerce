using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace E_commerce
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string s = "select * from Product_tab where Cat_Id=" + Session["Cat_Id"] + "";
                DataSet ds = ob.Fun_exeAdapter(s);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {

           Session["Product_Id"] = Convert.ToInt32(e.CommandArgument);


            Response.Redirect("ViewOne_Product.aspx");
        }
    }
}