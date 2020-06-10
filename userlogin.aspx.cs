using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Player_Registration_Form
{
    public partial class userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var isResult = false ;
            string userName = UserID_TextBox1.Text;
            string password = password_TextBox2.Text;
            string connectionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("adminresult", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@result", isResult).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            isResult = Convert.ToBoolean(cmd.Parameters["@result"].Value);

            if (isResult)
            {
                Response.Redirect("adminView.aspx");
                
            }

            else
            {
                Response.Write("<script language=javascript>alert('Incorrect Username or Password.')</script>");
            }

        }
    }
}