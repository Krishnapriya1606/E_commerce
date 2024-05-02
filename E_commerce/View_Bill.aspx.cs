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
    public partial class View_Bill : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select t1.*,t2.* from Product_tab t1 join Order_tab t2 on t1.Product_Id=t2.Product_Id where Order_Status='notpaid' and Reg_Id=" + Session["uid"] + "";
            DataSet ds = ob.Fun_exeAdapter(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();

            string st = "select * from Bill_tab where Reg_Id=" + Session["uid"] + " and Bill_Status='notpaid'";
            SqlDataReader dr = ob.fun_exeReader(st);
            while(dr.Read())
            {
                Label1.Text = dr["Bill_Id"].ToString();
                Label2.Text = dr["Bill_date"].ToString();
                Label3.Text = dr["Grand_Total"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string st = "select Grand_Total from Bill_tab where Reg_Id=" + Session["uid"] + "";
            string s = ob.Fun_exescalar(st);
            int gt = Convert.ToInt32(s);

            Balcheck1.ServiceClient obj = new Balcheck1.ServiceClient();
            string bal = obj.balancecheck(TextBox1.Text);
            int ba = Convert.ToInt32(bal);

            if(ba>gt)
            {
                string up = "update Order_tab set Order_Status='paid' where Reg_Id=" + Session["uid"] + "";
                int i = ob.Fun_exenonquery(up);

                string b = "update Bill_tab set Bill_Status='paid' where Reg_Id=" + Session["uid"] + "";
                int j = ob.Fun_exenonquery(b);

                string ac = "update Account_tab set Balance_Amount=" + (ba - gt) + " where Reg_Id=" + Session["uid"] + "";
                int k = ob.Fun_exenonquery(ac);

                Label4.Text = "Paid";
            }
            
        }
    }
}