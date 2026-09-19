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
    public partial class viewallproducts : System.Web.UI.Page
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
                if (Session["catid"] == null)
                {
                    Label4.Text = "Session empty";
                    return;
                }

                int getid = Convert.ToInt32(Session["catid"]);

                Label4.Text = "Category Id = " + getid;

                string s = "select * from prtab where catid=" + getid;

                DataTable ds = obj.Fun_DataTable(s);

                Label4.Text += " Rows = " + ds.Rows.Count;

                DataList1.DataSource = ds;
                DataList1.DataBind();

            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
            }
            
                
            

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            try
            {
                int proid = Convert.ToInt32(e.CommandArgument);

                Session["proid"] = proid;

                Response.Redirect("viewoneproduct.aspx");
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
            }

        }
    }
    
}