using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace webappmasterpage
{
    public partial class addproduct : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categorybind();
            }
        }
        public void categorybind()
        {
            string s = "select catid,catname from cattab";
            //DataTable dt = obj.Fun_DataTable(s);
            DropDownList1.DataSource = obj.Fun_DataTable(s);
            DropDownList1.DataTextField = "catname";
            DropDownList1.DataValueField = "catid";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "--select--");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string p = "~/prophotos/" + FileUpload1.FileName;

                FileUpload1.SaveAs(MapPath(p));

                string qry = "insert into prtab values('" +
                             DropDownList1.SelectedValue + "','" +
                             TextBox1.Text + "','" +
                             TextBox2.Text + "','" +
                             TextBox3.Text + "','" +
                             p + "','" +
                             TextBox4.Text + "','available')";


                int i = obj.Fun_Nonquery(qry);

                if (i == 1)
                {
                    Label6.Text = "Inserted Successfully";
                }
            }
            catch (Exception ex)
            {
                Label6.Text = "Error : " + ex.Message;
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}