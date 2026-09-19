using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webappmasterpage
{
    public partial class adminreg : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(regid) from logintab";
            string maxregid = obj.Fun_Scalar(sel);
            int reg_id = 0;
            if (maxregid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(maxregid);
                reg_id = newregid + 1;

            }

            string ins = "insert into adminreg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')";
            int i = obj.Fun_Nonquery(ins);
            if (i == 1)
            {
                string inslog = "insert into logintab values(" + reg_id + ",'" + TextBox4.Text + "','" + TextBox5.Text + "','admin')";
                int j = obj.Fun_Nonquery(inslog);
                if (i == 1&&j == 1)
                {
                    Label6.Text = "ins";

                }
                else
                {
                    Label6.Text = "invalid entry";
                }
            }

        }
    }
}