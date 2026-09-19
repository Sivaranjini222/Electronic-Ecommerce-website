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
    public partial class viewcart : System.Web.UI.Page
    {
        conclass obj = new conclass();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        public void LoadCart()
        {
            try
            {
                int userid = Convert.ToInt32(Session["userid"]);

                string s = "select carttab.cartid," +
                           "prtab.proname," +
                           "prtab.proimage," +
                           "prtab.proprice," +
                           "carttab.quantity," +
                           "carttab.subtotal " +
                           "from carttab inner join prtab " +
                           "on carttab.proid=prtab.proid " +
                           "where carttab.userid=" + userid +
                           " and cartstatus='0'";

                DataTable dt = obj.Fun_DataTable(s);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            try
            {
                int cartid = Convert.ToInt32(e.CommandArgument);

                Button btn = (Button)sender;

                GridViewRow row = (GridViewRow)btn.NamingContainer;

                TextBox txtqty = (TextBox)row.FindControl("TextBox1");

                int qty = Convert.ToInt32(txtqty.Text);

                // get price
                string sel = "select prtab.proprice from prtab " +
                             "inner join carttab on prtab.proid=carttab.proid " +
                             "where cartid=" + cartid;

                int price = Convert.ToInt32(obj.Fun_Scalar(sel));

                int subtotal = qty * price;

                string upd = "update carttab set quantity=" + qty +
                             ", subtotal='" + subtotal +
                             "' where cartid=" + cartid;

                obj.Fun_Nonquery(upd);

                LoadCart();

                Label1.Text = "Cart Updated";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
       

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int userid = Convert.ToInt32(Session["userid"]);

                // get cart items
                string s = "select * from carttab where userid=" +
                           userid + " and cartstatus='0'";

                DataTable dt = obj.Fun_DataTable(s);

                long grandtotal = 0;

                // insert into order table
                foreach (DataRow dr in dt.Rows)
                {
                    string ins = "insert into ordertab " +
                                 "(proid,userid,quantity,subtotal,order_date,orderstatus) " +
                                 "values(" +
                                 dr["proid"] + "," +
                                 dr["userid"] + "," +
                                 dr["quantity"] + "," +
                                 dr["subtotal"] + ",'" +
                                 DateTime.Now.ToString("yyyy-MM-dd") +
                                 "','1')";

                    obj.Fun_Nonquery(ins);

                    // add subtotal to grand total
                    grandtotal += Convert.ToInt64(dr["subtotal"]);
                }

                // insert into bill table
                string bill = "insert into billtab(userid,date,grandtotal) values(" +
                              userid + ",'" +
                              DateTime.Now.ToString("yyyy-MM-dd") +
                              "'," + grandtotal + ")";

                obj.Fun_Nonquery(bill);

                // update cart status
                string upd = "update carttab set cartstatus='1' " +
                             "where userid=" + userid;

                obj.Fun_Nonquery(upd);

                Label1.Text = "Order Confirmed Successfully";
            }

            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbill.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("accountdetails.aspx");

        }
    }
}