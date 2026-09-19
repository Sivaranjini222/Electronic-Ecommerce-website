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
    public partial class feedback : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string selgrid= "SELECT dbo.prtab.proid, dbo.ordertab.orderid, dbo.prtab.proname,dbo.prtab.proimage FROM   dbo.prtab CROSS JOIN dbo.ordertab";
            DataSet da = obj.Fun_DataSet(selgrid);
            GridView1.DataSource = da;
            GridView1.DataBind();



        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
            string ins = "insert into feedbacktab values ('" + Session["userid"] + "','" + Session["proid"] + "',)";


        }
    }
}