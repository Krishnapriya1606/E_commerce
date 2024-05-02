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
    public partial class AddCategory : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            
            string ins = "insert into Category_tab values('" + TextBox1.Text + "','"+p+"','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = ob.Fun_exenonquery(ins);
            if (i == 1)
            {
                Label5.Text = "Added successfully";
            }
        }
    }
}