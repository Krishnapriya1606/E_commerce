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
 
    public partial class AdminReg : System.Web.UI.Page
    {
        Concls ob = new Concls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Login_tab";
            string regid = ob.Fun_exescalar(sel);
            int reg_id = 0;
            if (regid =="")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into AdminRegtab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "'," + TextBox3.Text + ")";
            int i = ob.Fun_exenonquery(ins);
            if (i != 0)
            {
                string inslog = "insert into Login_tab values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin','active')";
                int j = ob.Fun_exenonquery(inslog);
               
            }
            Label7.Text = "Inserted";
        }
    }
}