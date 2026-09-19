using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webappmasterpage
{
    public partial class userreg : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
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
                string ins = "insert into userreg values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','active')";
                int i = obj.Fun_Nonquery(ins);
                if (i == 1)
                {
                    string inslog = "insert into logintab values(" + reg_id + ",'" + TextBox6.Text + "','" + TextBox7.Text + "','user')";
                    int j = obj.Fun_Nonquery(inslog);
                    if (i == 1 && j == 1)
                    {
                        Label8.Text = "successfully registered";

                    }
                    else
                    {
                        Label8.Text = "invalid entry";
                    }

                }
            }

            catch (Exception ex)
            {
                Label8.Text = "error:" + ex.Message;
            }
        }
    
        
        }
    }
    
