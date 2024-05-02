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
    public partial class EditProduct : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                grid_Bind();
            }
        }
        public void grid_Bind()
        {
           
            string s = "select * from Product_tab";
            DataSet ds = ob.Fun_exeAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void LinkButton1_Command1(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string s = "select Product_Status from Product_tab where Product_Id=" + id + "";
            string s1 = ob.Fun_exescalar(s);
            if (s1 == "available")
            {
                string up = "update Product_tab set Product_Status='unavailable' where Product_Id=" + id + "";
                int i = ob.Fun_exenonquery(up);
                if (i == 1)
                {
                    Label1.Text = "blocked";
                }
            }
            else if (s1 == "unavailable")
            {
                string upd = "update Product_tab set Product_Status='available' where Product_Id=" + id + "";
                int i = ob.Fun_exenonquery(upd);
                if (i == 1)
                {
                    Label1.Text = "unblocked";
                }
            }
            grid_Bind();
        }

        protected void LinkButton2_Command(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            Session["Product_Id"] = Convert.ToInt32(e.CommandArgument);
            string sel = "select * from Product_tab where Product_Id='" + Session["Product_Id"] + "'";
            SqlDataReader dr = ob.fun_exeReader(sel);
            while (dr.Read())
            {
                Label7.Text = dr["Product_Name"].ToString();
                TextBox1.Text = dr["Product_Description"].ToString();
                TextBox2.Text = dr["Product_Price"].ToString();
                TextBox3.Text = dr["Product_Stock"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ph = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(ph));

            string s = "update Product_tab set Product_Description='" + TextBox1.Text + "',Product_Image='" + ph + "',Product_Price=" + TextBox2.Text + ",Product_Stock=" + TextBox3.Text + " where Product_Id='" + Session["Product_Id"] + "'";

            int i = ob.Fun_exenonquery(s);
            if (i == 1)
            {
                Label8.Visible = true;
                Label8.Text = "updated";
                grid_Bind();
            }
        }




        //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    GridView1.EditIndex = e.NewEditIndex;
        //    grid_Bind();
        //}

        //protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        //{
        //    GridView1.EditIndex = -1;
        //    grid_Bind();
        //}

        //protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    int i = e.RowIndex;
        //    int id = Convert.ToInt32(GridView1.DataKeys[i].Value);
        //    TextBox txtname = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
        //    TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[4].Controls[0];
        //    TextBox txtprice = (TextBox)GridView1.Rows[i].Cells[6].Controls[0];
        //    TextBox txtstock = (TextBox)GridView1.Rows[i].Cells[7].Controls[0];

        //    string str = "update Product_tab set Product_Name='" + txtname.Text + "',Product_Description='" + txtdesc.Text + "',Product_Price=" + txtprice.Text + ",Product_Stock='" + txtstock.Text + "' where Product_Id=" + id + "";
        //    int j = ob.Fun_exenonquery(str);
        //    GridView1.EditIndex = -1;
        //    grid_Bind();
        //}

        
    }
    }