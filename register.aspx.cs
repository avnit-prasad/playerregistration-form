using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace Player_Registration_Form
{
    public partial class register : System.Web.UI.Page
    {
        public bool validatedPostcode = false;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected async void Save_btn(object sender, EventArgs e)
        {
            string firstName = fname.Text;
            string lastName = lname.Text;
            string mobileNumber = mobNumber.Text;
            string emailAdd = email.Text;
            string city = Textbox_city.Text;
            string address = Textbox_add.Text;
            string postalCode = Textbox_postcode.Text;
            string memberType = member_type.Text;
            string gender = genderList.Text;
            string dob = TxtDob.Text;
            string club = cricketClub.Text;
            string playingType;
            var isValidPostalCode = await postalCodevalidator(postalCode, city);
            //var isValidDOB = dateValidator(dob);

            if (isValidPostalCode)
            {
                string connetionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
                SqlConnection cnn = new SqlConnection(connetionString);
                cnn.Open();
                string sql = "Insert into RegisterDB.dbo.Player(strfirstName,strlastName,strEmail, strAddress, strPostalcode, strCity,strMobile, strMember, strGender, strClub, strDOB) Values (@strfirstName, @strlastName, @strEmail, @strAddress, @strPostalcode, @strCity, @strMobile, @strMember, @strGender, @strClub, @strDOB)";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@strfirstName", firstName);
                command.Parameters.AddWithValue("@strlastName", lastName);
                command.Parameters.AddWithValue("@strEmail", emailAdd);
                command.Parameters.AddWithValue("@strAddress", address);
                command.Parameters.AddWithValue("@strPostalcode", postalCode);
                command.Parameters.AddWithValue("@strCity", city);
                command.Parameters.AddWithValue("@strMobile", mobileNumber);
                command.Parameters.AddWithValue("@strMember", memberType);
                command.Parameters.AddWithValue("@strGender", gender);
                command.Parameters.AddWithValue("@strClub", club);
                command.Parameters.AddWithValue("@strDOB", dob);
                command.ExecuteNonQuery();

                Response.Write("Connection MAde");
                cnn.Close();
            }
        }
        protected async Task<bool> postalCodevalidator(string postalCode, string city)
        {
            string Url = string.Format("https://api.addy.co.nz/postcode?key={0}&s={1}",
                "d892a3c02a294a3d910d3fd324fa5ad3", city);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(Url);
            

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.Contains(postalCode))
                {
                    return true;
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Invalid Post Code Please enter correct code.')</script>");
                    return false;
                }
            }
            else
            {
                Response.Write("<script language=javascript>alert('Unable to validate Postal Code.')</script>");
                return false;
            }
        }
    }
}