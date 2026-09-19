using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webappmasterpage
{
    public partial class login : System.Web.UI.Page
    {
        conclass obj =new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(regid) from logintab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            string cid = obj.Fun_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if (cid1 == 1)
            {
                string str1 = "select regid from logintab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string reg_id = obj.Fun_Scalar(str1);
                Session["userid"] = reg_id;
                string str2 = "select logtype from logintab where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                string logtype = obj.Fun_Scalar(str2);
                if (logtype == "admin")
                {
                    Response.Redirect("adminhome.aspx");
                }
                else if (logtype == "user")
                {
                    Response.Redirect("userhome.aspx");
                }
            }
            else
            {
                Label3.Text = cid;
            }

        }
    }
}