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
    public partial class ViewOne_Product : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select * from Product_tab where Product_Id=" + Session["Product_Id"] + "";
            SqlDataReader dr = ob.fun_exeReader(s);

            while(dr.Read())
            {
                Label1.Text = dr["Product_Name"].ToString();
                Label2.Text = dr["Product_Description"].ToString();
                Label3.Text = dr["Product_Price"].ToString();
                Image1.ImageUrl = dr["Product_Image"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "select max(Cart_Id) from Cart_tab";
            string cartid = ob.Fun_exescalar(s);
            int Cart_Id = 0;
            if (cartid == "")
            {
                Cart_Id = 1;
            }
            else
            {
                int newcartid = Convert.ToInt32(cartid);
                Cart_Id = newcartid + 1;
            }

            string p = "select Product_Price from Product_tab where Product_Id=" + Session["Product_Id"] + "";
            string price = ob.Fun_exescalar(p);

            int t = Convert.ToInt32(TextBox1.Text);
            int pr = Convert.ToInt32(price);
            int tp = t * pr;

            string ins = "insert into Cart_tab values(" + Cart_Id + "," + Session["Product_Id"] + "," + Session["uid"] + "," + TextBox1.Text + "," + tp + ",'available')";
            int i = ob.Fun_exenonquery(ins);
            if(i==1)
            {
                Label4.Visible = true;
                Label4.Text = "Added to Cart";
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_home.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Cart.aspx");
        }
    }
}