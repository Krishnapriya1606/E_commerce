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
    public partial class UserReg : System.Web.UI.Page
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
            string ins = "insert into User_Reg_tab values(" + reg_id + ",'" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"',"+TextBox8.Text+",'"+TextBox9.Text+"',"+TextBox10.Text+")";
            int i = ob.Fun_exenonquery(ins);
           if(i==1)
            {
                Label14.Text = "Inserted";
            }
            
                string inslog = "insert into Login_tab values(" + reg_id + ",'" + TextBox11.Text + "','" + TextBox12.Text + "','user','active')";
                int j = ob.Fun_exenonquery(inslog);

            
        }

        
    }
}