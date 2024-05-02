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
    public partial class EditCategory : System.Web.UI.Page
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
            string s = "select * from Category_tab";
            DataSet ds = ob.Fun_exeAdapter(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            string s = "select Cat_Status from Category_tab where Cat_Id=" + id + "";
            string c = ob.Fun_exescalar(s);
            if (c == "available")
            {
                string up = "update Category_tab set Cat_Status='unavailable' where Cat_Id=" + id + "";
                int i = ob.Fun_exenonquery(up);
                if (i == 1)
                {
                    Label1.Text = "blocked";
                }
            }
            else if (c == "unavailable")
            {
                string upd = "update Category_tab set Cat_Status='available' where Cat_Id=" + id + "";
                int i = ob.Fun_exenonquery(upd);
                if (i == 1)
                {
                    Label1.Text = "unblocked";
                }
            }
            grid_Bind();
        }

        protected void LinkButton2_Command1(object sender, CommandEventArgs e)
        {
            Panel1.Visible = true;
            Session["Cat_Id"] = Convert.ToInt32(e.CommandArgument);
            string s = "select * from Category_tab where Cat_Id='" + Session["Cat_Id"] + "'";
            SqlDataReader dr = ob.fun_exeReader(s);
            while (dr.Read())
            {
                TextBox1.Text = dr["Cat_Description"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ph = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(ph));

            string s = "update Category_tab set Cat_Image='" + ph + "',Cat_Description='" + TextBox1.Text + "' where Cat_Id='" + Session["Cat_Id"] + "'";
            int i = ob.Fun_exenonquery(s);
            if (i == 1)
            {
                Label4.Visible = true;
                Label4.Text = "updated";
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
        //    TextBox txtname = (TextBox)GridView1.Rows[i].Cells[2].Controls[0];
        //    TextBox txtdesc = (TextBox)GridView1.Rows[i].Cells[3].Controls[0];
        //    FileUpload fup = (FileUpload)GridView1.Rows[i].Cells[4].Controls[0];

        //    string str = "update Category_tab set Cat_Name='" + txtname + "',Cat_Description='" + txtdesc + "' where Cat_Id=" + id + "";
        //    int j = ob.Fun_exenonquery(str);
        //    GridView1.EditIndex = -1;
        //    grid_Bind();
        //}


       
    }
}