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
    public partial class viewbill : System.Web.UI.Page
    {
        conclass obj = new conclass();

        protected void Page_Load(object sender, EventArgs e)
        {
           

            
                if (!IsPostBack)
                {
                    LoadBill();
                }
            }

            public void LoadBill()
            {
                try
                {
                    int userid = Convert.ToInt32(Session["userid"]);

                    // USER DETAILS
                    string user = "select * from userreg where userid=" + userid;

                    DataTable dtuser = obj.Fun_DataTable(user);

                    if (dtuser.Rows.Count > 0)
                    {
                        Label1.Text = dtuser.Rows[0]["name"].ToString();

                        Label2.Text = dtuser.Rows[0]["address"].ToString();

                        Label3.Text = dtuser.Rows[0]["phone"].ToString();
                    }

                    // BILL DETAILS
                    string bill = "select top 1 * from billtab " +
                                  "where userid=" + userid +
                                  " order by paymentid desc";

                    DataTable dtbill = obj.Fun_DataTable(bill);

                    if (dtbill.Rows.Count > 0)
                    {
                        Label4.Text = dtbill.Rows[0]["date"].ToString();

                        Label5.Text = dtbill.Rows[0]["grandtotal"].ToString();
                    }

                    // ORDER + PRODUCT DETAILS
                    string s = "select prtab.proname," +
                               "prtab.proimage," +
                               "prtab.proprice," +
                               "ordertab.quantity," +
                               "ordertab.subtotal " +
                               "from ordertab inner join prtab " +
                               "on ordertab.proid=prtab.proid " +
                               "where ordertab.userid=" + userid +
                               " and orderstatus='1'";

                    DataTable dt = obj.Fun_DataTable(s);

                    GridView1.DataSource = dt;

                    GridView1.DataBind();
                }
                catch (Exception ex)
                {
                    Label1.Text = ex.Message;
                }
            }
    }

}
    
 