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
    public partial class userhome : System.Web.UI.Page
    {
        conclass obj = new conclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDatalist();
            }
        }

        public void LoadDatalist()
        {
            try
            {
                string s = "select * from cattab where catstatus='available'";

                DataSet ds = obj.Fun_DataSet(s);

                DataList1.DataSource = ds;

                DataList1.DataBind();
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
            }
        }

        protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            try
            {


                int getid = Convert.ToInt32(e.CommandArgument);
                Session["catid"] = getid;
                string sel = "select catimage,catname,datdesc from cattab where catid=" + getid + "";
                string s = obj.Fun_Scalar(sel);
                Response.Redirect("viewallproducts.aspx");

            }
            catch(Exception ex)
            {
                Label4.Text = ex.Message;
            }
        }
    }
}

