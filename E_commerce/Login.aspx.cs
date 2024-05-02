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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(Reg_Id) from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = ob.Fun_exescalar(str);
            int cid1 = Convert.ToInt32(cid);
            if(cid1==1)
            {
                string str1= "select Reg_Id from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string id = ob.Fun_exescalar(str1);
                Session["uid"] = id;
                string str2 = "select Log_Type from Login_tab where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtype = ob.Fun_exescalar(str2);
                if(logtype=="admin")
                {
                    Response.Redirect("Admin_home.aspx");
                    //Label3.Text = "Admin";
                }
                else if(logtype=="user")
                {
                    Response.Redirect("User_home.aspx");
                    //Label3.Text = "User";
                }

            }

            

        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("UserReg.aspx");
        }
    }
}