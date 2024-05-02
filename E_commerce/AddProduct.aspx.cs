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
    public partial class AddProduct : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string sel = "select Cat_Id,Cat_Name from Category_tab";
                DataSet ds = ob.Fun_exeAdapter(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Cat_Name";
                DropDownList1.DataValueField = "Cat_Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-select-");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photos/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            string ins = "insert into Product_tab values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','" + TextBox3.Text + "'," + TextBox4.Text + ",'" + TextBox5.Text + "')";
            int i = ob.Fun_exenonquery(ins);
            if (i == 1)
            {
                Label8.Text = "Product Added successfully";
            }
        }
    }
}