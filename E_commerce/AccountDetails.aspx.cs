using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_commerce
{
    
    public partial class AccountDetails : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Account_tab values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + Session["uid"] + "')";
            int i = ob.Fun_exenonquery(ins);
            if(i==1)
            {
                Label4.Visible = true;
                Label4.Text = "Success";
            }
        }
    }
}