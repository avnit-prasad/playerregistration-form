using System;


namespace Player_Registration_Form
{
    public partial class userlogin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            login userLogin = new login();
             bool isResult = userLogin.Verifylogin(UserID_TextBox1.Text, password_TextBox2.Text);
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