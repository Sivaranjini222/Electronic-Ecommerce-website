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
    public partial class accountdetails : System.Web.UI.Page
    { 
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                int userid = Convert.ToInt32(Session["userid"]);

               
                
                long accno = Convert.ToInt64(TextBox1.Text);

                string accname = TextBox2.Text;
                long balance = Convert.ToInt64(TextBox3.Text);

                string ins = "insert into accounttab " +
             "(userid,accno,accname,accbal) " +
             "values(" + userid + "," +
             accno + ",'" +
             accname + "'," +
             balance + ")";

                int i = obj.Fun_Nonquery(ins);

                if (i > 0)
                {
                    Label1.Text = "Account Details Inserted Successfully";

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
                int userid = Convert.ToInt32(Session["userid"]);

                string srtsel = "select count(accid) from accounttab where accno='"
                    + TextBox1.Text + "' and userid=" + userid;
                string id = obj.Fun_Scalar(srtsel);


            int id1 = Convert.ToInt32(id);

                if(id1 >= 1)
                {
                Label2. Visible = true;
                Label2.Text = "account already existed ..please enter another account";
                }
            else
            {
                Label2.Visible = false;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Session["userid"]);
            string gt = "select sum(subtotal) from ordertab where userid=" + userid + "";
            object grandtot = obj.Fun_Scalar(gt);
            if (grandtot != null)
            {
                Label3.Text = grandtot.ToString();
            }
            else
            {
                Label3.Text = "0";
            }
            Panel1.Visible = false;
            Panel3.Visible = true;

            //WCF Calling for balance
            ServiceReference.Service1Client objs = new ServiceReference.Service1Client();
            string accq = "select accno from accounttab where UserId=" + userid + "";
            string accno = obj.Fun_Scalar(accq);

            string bal = objs.checkbal(accno);
            Label4.Text = bal;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                grandtot.Service1Client objs = new grandtot.Service1Client();
                int userid = Convert.ToInt32(Session["userid"]);
                string accq = "select accno from accounttab where userid=" + userid + "";
                string accno = obj.Fun_Scalar(accq);
                string grandtotal = Label3.Text;
                string result = objs.payment(accno, grandtotal);
                Label5.Text = result;

                //SELECTING THE ORDERS
                string ordering = "select proid from ordertab where userid=" + userid + " and orderstatus='order' ";
                SqlDataReader dr = obj.Fun_Reader(ordering);
                List<int> pdidlist = new List<int>();
                while (dr.Read())
                {
                    pdidlist.Add(Convert.ToInt32(dr["proid"]));
                }
                //From here
                foreach (int p in pdidlist)
                {
                    //UPDATE ORDERSTATUS
                    string upd = "update ordertab set orderstatus='paid'   where proid=" + p + " and userid=" + userid + "";
                    obj.Fun_Nonquery(upd);

                    //GET ORDERED QUANTITY
                    string qty = "select quantity from ordertab where proid=" + p + "and userid=" + userid + "";
                    int quantity = Convert.ToInt32(obj.Fun_Scalar(qty));

                    //GET STOCK
                    string stk = "select Prostock from prtab where proid=" + p + "";
                    int totalstock = Convert.ToInt32(obj.Fun_Scalar(stk));


                    int updatestock = totalstock - quantity;
                    //UPDATE STOCK
                    string updstock = "update prtab set prostock=" + updatestock + " where proid=" + p + "";
                }
            }
            catch (Exception ex)
            {
                Label5.Text = ex.Message;
            }
        }

       

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("feedback.aspx");
        }
    }
}
    
