using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace webappmasterpage
{
    public class conclass
    {
    
    SqlConnection con;
    SqlCommand cmd;

        public conclass()
        {
            con = new SqlConnection(@"server=DESKTOP-BMGB2T4\SQLEXPRESS;database=ecommerce;Integrated Security=true");
        }
            public int Fun_Nonquery(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }

            public string Fun_Scalar(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                string s = cmd.ExecuteScalar().ToString();
                con.Close();
                return s;
            //if (obj == null)
            //{
            //    return "";
            //}
            //else
            //{


            //    return obj.ToString();
            //}
            }
    
            public SqlDataReader Fun_Reader(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmd = new SqlCommand(sqlquery, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                return dr;
            }
            public DataSet Fun_DataSet(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery,con);
                con.Open();
                DataSet ds = new DataSet();
                 da.Fill(ds);
                 return ds;


            }
            public DataTable Fun_DataTable(string sqlquery)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

    }



    
}
