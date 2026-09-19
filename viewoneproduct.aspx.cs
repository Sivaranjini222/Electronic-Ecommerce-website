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
    public partial class viewoneproduct : System.Web.UI.Page
    {

        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProduct();
            }
        }

        public void LoadProduct()
        {
            try
            {
                // check session
                if (Session["proid"] == null)
                {
                    Label1.Text = "Session Empty";
                    return;
                }

                // get product id
                int proid = Convert.ToInt32(Session["proid"]);

                // select product
                string s = "select * from prtab where proid=" + proid;

                DataTable dt = obj.Fun_DataTable(s);

                // check rows
                if (dt.Rows.Count > 0)
                {
                    // image
                    Image1.ImageUrl = dt.Rows[0]["proimage"].ToString();

                    // product name
                    Label1.Text = dt.Rows[0]["proname"].ToString();

                    // price
                    Label2.Text = dt.Rows[0]["proprice"].ToString();

                    // description
                    Label3.Text = dt.Rows[0]["prodesc"].ToString();

                    // stock value
                    int stock = Convert.ToInt32(dt.Rows[0]["prostock"]);

                    // fill dropdownlist
                    DropDownList1.Items.Clear();

                    for (int i = 1; i <= stock; i++)
                    {
                        DropDownList1.Items.Add(i.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Label4.Text = ex.Message;
            }
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewcart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // product id
                int proid = Convert.ToInt32(Session["proid"]);

                // user id
                int userid = Convert.ToInt32(Session["userid"]);

                // quantity from dropdown
                int qty = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                // get product price
                string sel = "select proprice from prtab where proid=" + proid;

                string price = obj.Fun_Scalar(sel);

                int proprice = Convert.ToInt32(price);

                // subtotal
                int subtotal = proprice * qty;

                // insert query
                string ins = "insert into carttab values(" +
                             proid + "," +
                             userid + "," +
                             qty + ",'" +
                             subtotal + "','0')";

                int i = obj.Fun_Nonquery(ins);

                if (i == 1)
                {
                    Label1.Text = "Added To Cart";
                }
                else
                {
                    Label1.Text = "Insertion Failed";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}