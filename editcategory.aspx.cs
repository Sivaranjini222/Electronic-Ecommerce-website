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
    public partial class editcategory : System.Web.UI.Page
    {
        conclass obj = new conclass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }
        public void LoadGrid()
        {
            try
            {
                string s = "select * from cattab";

                DataSet ds = obj.Fun_DataSet(s);

                GridView1.DataSource = ds;

                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    LoadGrid();
        //}

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;

            LoadGrid();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;

            LoadGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                int i = e.RowIndex;

                int getid = Convert.ToInt32(GridView1.DataKeys[i].Value);

                TextBox txtname =
                (TextBox)GridView1.Rows[i].Cells[1].Controls[0];

                FileUpload fu =
               (FileUpload)GridView1.Rows[i].Cells[2].FindControl("FileUpload1");

                TextBox txtdesc =
                (TextBox)GridView1.Rows[i].Cells[3].Controls[0];

                TextBox txtstatus =
                (TextBox)GridView1.Rows[i].Cells[4].Controls[0];

               

                string path = "";

                if (fu.HasFile)
                {
                    path = "~/catphoto/" + fu.FileName;

                    fu.SaveAs(Server.MapPath(path));
                }

                string up = "update cattab set catname='" + txtname.Text + "', catimage='" + path + "',datdesc='" + txtdesc.Text + "', catstatus='" + txtstatus.Text + "' where catid=" + getid+"";

                int x = obj.Fun_Nonquery(up);

                GridView1.EditIndex = -1;

                LoadGrid();

                Label1.Text = "Updated Successfully";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}