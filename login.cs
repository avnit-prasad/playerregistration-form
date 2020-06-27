using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Threading.Tasks;

namespace Player_Registration_Form
{
    public class login
    {
        protected string userName;
        protected string password;

        public bool Verifylogin(string userName, string password)
        {
            string connectionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("retrieveAdminlogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            int result = (int)(cmd.ExecuteScalar());
            if (result ==1)
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}