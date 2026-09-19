using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webappmasterpage
{
    public partial class category : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {


                string p = "~/catphoto/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(p));
                string str = "INSERT INTO cattab  VALUES('" + TextBox1.Text + "','" + p + "','" + TextBox2.Text + "','available')";
                int i = obj.Fun_Nonquery(str);
                if (i == 1)
                {
                    Label4.Text = "Inserted";
                }
            }
            catch (Exception ex)
            {
                Label4.Text = "error:" + ex.Message;
            }
        }

        }
    }
