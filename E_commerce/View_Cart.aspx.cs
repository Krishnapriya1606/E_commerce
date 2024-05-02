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
    public partial class View_Cart : System.Web.UI.Page
    {
        Concls ob = new Concls();
        int cid;
        int cqu;
        int cto;
        string cst;
        int pid;
        int usid;
        int Gt = 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid_bind();
            }
        }
        public void grid_bind()
        {
            string s = "select P1.*,C2.* from Product_tab P1 join Cart_tab C2 on C2.Product_Id=P1.Product_Id where Reg_Id=" + Session["uid"] + "";
            DataSet ds = ob.Fun_exeAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            Session["Cart_Id"] = Convert.ToInt32(e.CommandArgument);
            Panel1.Visible = true;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string t = "select P1.Product_Price from Product_tab P1 join Cart_tab C2 on P1.Product_Id=C2.Product_Id where C2.Cart_Id=" + Session["Cart_Id"] + "";
            string str = ob.Fun_exescalar(t);
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(str);
            int tot_price = a * b;
            string str2 = "update Cart_tab set Quantity=" + TextBox1.Text + ",Total_Price='" + tot_price + "' where Cart_Id=" + Session["Cart_Id"] + "";
            int i = ob.Fun_exenonquery(str2);
            if (i == 1)
            {
                grid_bind();
                Label2.Visible = true;
                Label2.Text = "Updated";
            }
        }
        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Panel2.Visible = true;

            int id = Convert.ToInt32(e.CommandArgument);

            string del = "delete from Cart_tab where Cart_Id=" + id + "";
            int i = ob.Fun_exenonquery(del);
            if (i == 1)
            {
                grid_bind();
                Label3.Text = "Deleted";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_home.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string sel = "select max(Cart_Id) from Cart_tab";
            string s = ob.Fun_exescalar(sel);
            int n = Convert.ToInt32(s);
            
            for (int i = 1; i <= n; i++)
            {
                string rid = "select Reg_Id from Cart_tab where Cart_Id=" + i + "";
                string st = ob.Fun_exescalar(rid);
                if(st!="")
                {
                int a = Convert.ToInt32(st);
                
                
                int ids = Convert.ToInt32(Session["uid"]);
                    if (a == ids)
                    {
                        string ct = "select * from Cart_tab where Cart_Id=" + i + "";
                        SqlDataReader dr = ob.fun_exeReader(ct);

                        while (dr.Read())
                        {
                            cid = Convert.ToInt32(dr["Cart_Id"].ToString());
                            cqu = Convert.ToInt32(dr["Quantity"].ToString());
                            cto = Convert.ToInt32(dr["Total_Price"].ToString());
                            cst = dr["Cart_Status"].ToString();
                            pid = Convert.ToInt32(dr["Product_Id"].ToString());
                            usid = Convert.ToInt32(dr["Reg_Id"].ToString());
                        }
                        Gt = Gt + cto;



                        string ins = "insert into Order_tab values(" + cid + "," + pid + "," + usid + "," + cqu + "," + cto + ",'notpaid')";
                        int b = ob.Fun_exenonquery(ins);
                    }
                }
            }
            string bil = "insert into Bill_tab values('" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + usid + "," + Gt + ",'notpaid')";
            int c = ob.Fun_exenonquery(bil);

            if(c!=0)
            {
                string del = "delete from Cart_tab where Reg_Id=" + Session["uid"] + "";
                int d = ob.Fun_exenonquery(del);
            }
            Response.Redirect("View_Bill.aspx");
        }
    }
}