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
    public partial class adminView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                populateGridview();
                GridView2.HeaderRow.TableSection = TableRowSection.TableHeader;
            }
            
        }

        protected void populateGridview()
        {
            SqlConnection cnn;
            string connetionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
            cnn = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("retrievePlayers", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@clubName", "Papatoetoe Cricket Club");
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                GridView2.DataSource = dataTable;
                GridView2.DataBind();
            }
            else
            {
                dataTable.Rows.Add(dataTable.NewRow());
                GridView2.DataSource = dataTable;
                GridView2.DataBind();
                GridView2.Rows[0].Cells.Clear();
                GridView2.Rows[0].Cells.Add(new TableCell());
                GridView2.Rows[0].Cells[0].ColumnSpan = dataTable.Columns.Count;
                GridView2.Rows[0].Cells[0].Text = "No Players Registered";
            }
            cnn.Close();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("AddNew"))
                {
                    SqlConnection cnn;
                    string connetionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    string insertRowQ = "INSERT INTO RegisterDB.dbo.Player(strfirstName, strlastName, strEmail, strAddress, strPostalcode, strCity, strMobile, strPlayinglevel, strMember, strGender, strDOB) VALUES (@strfirstName, @strlastName, @strEmail, @strAddress, @strPostalcode, @strCity, @strMobile, @strPlayinglevel, @strMember, @strGender, @strDOB)";
                    SqlCommand cmd = new SqlCommand(insertRowQ, cnn);
                    string textboxFirstName = ((TextBox)(GridView2.FooterRow.FindControl("firstNameFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strfirstName", textboxFirstName);
                    string textboxLastName = ((TextBox)(GridView2.FooterRow.FindControl("lastNameFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strlastName", textboxLastName);
                    string textBoxEmail = ((TextBox)(GridView2.FooterRow.FindControl("EmailFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strEmail", textBoxEmail);
                    string textBoxAddress = ((TextBox)(GridView2.FooterRow.FindControl("AddressFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strAddress", textBoxAddress);
                    string textBoxPostalCode = ((TextBox)(GridView2.FooterRow.FindControl("PostalCodeFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strPostalcode", textBoxPostalCode);
                    string textBoxCity = ((TextBox)(GridView2.FooterRow.FindControl("CityFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strCity", textBoxCity);
                    string textBoxMobile = ((TextBox)(GridView2.FooterRow.FindControl("MobileFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strMobile", textBoxMobile);
                    string textBoxPlayingLevel = ((TextBox)(GridView2.FooterRow.FindControl("PlayingLevelFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strPlayinglevel", textBoxPlayingLevel);
                    string textBoxMember = ((TextBox)(GridView2.FooterRow.FindControl("memberFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strMember", textBoxMember);
                    string textBoxGender = ((TextBox)(GridView2.FooterRow.FindControl("genderFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strGender", textBoxGender);
                    string textBoxDOB = ((TextBox)(GridView2.FooterRow.FindControl("DOBFooter"))).Text.Trim();
                    cmd.Parameters.AddWithValue("@strDOB", textBoxDOB);
                    cmd.ExecuteNonQuery();
                    populateGridview();
                    lblSuccessMessage.Text = "New Player has been Registered";
                    lblErrorMessage.Text = "";

                }
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            populateGridview();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            populateGridview();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try {
                SqlConnection cnn;
                string connetionString = @"Data Source=LAPTOP-47C81TH4\SQLEXPRESS;Initial Catalog=RegisterDB ;Integrated Security=SSPI";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                string updateRowQ = "UPDATE RegisterDB.dbo.Player SET strfirstName = @strfirstName, strlastName = @strlastName, strEmail = @strEmail , strAddress = @strAddress, strPostalcode = @strPostalcode, strCity = @strCity, strMobile = @strMobile, strPlayinglevel = @strPlayinglevel, strMember = @strMember, strGender = @strGender, strDOB = @strDOB WHERE memberID = @memberID";
                SqlCommand cmd = new SqlCommand(updateRowQ, cnn);
                string textboxFirstName = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtFirstName"))).Text;
                cmd.Parameters.AddWithValue("@strfirstName", textboxFirstName);
                string textboxLastName = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtLastName"))).Text;
                cmd.Parameters.AddWithValue("@strlastName", textboxLastName);
                string textBoxEmail = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtEmail"))).Text;
                cmd.Parameters.AddWithValue("@strEmail", textBoxEmail);
                string textBoxAddress = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtAddress"))).Text;
                cmd.Parameters.AddWithValue("@strAddress", textBoxAddress);
                string textBoxPostalCode = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtPostalCode"))).Text;
                cmd.Parameters.AddWithValue("@strPostalcode", textBoxPostalCode);
                string textBoxCity = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtCity"))).Text;
                cmd.Parameters.AddWithValue("@strCity", textBoxCity);
                string textBoxMobile = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtMobile"))).Text;
                cmd.Parameters.AddWithValue("@strMobile", textBoxMobile);
                string textBoxPlayingLevel = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtPlayingLevel"))).Text;
                cmd.Parameters.AddWithValue("@strPlayinglevel", textBoxPlayingLevel);
                string textBoxMember = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtMember"))).Text;
                cmd.Parameters.AddWithValue("@strMember", textBoxMember);
                string textBoxGender = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtGender"))).Text;
                cmd.Parameters.AddWithValue("@strGender", textBoxGender);
                string textBoxDOB = ((TextBox)(GridView2.Rows[e.RowIndex].FindControl("txtDOB"))).Text;
                cmd.Parameters.AddWithValue("@strDOB", textBoxDOB);
                cmd.Parameters.AddWithValue("@memberID", Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString()));
                cmd.ExecuteNonQuery();
                GridView2.EditIndex = -1;
                populateGridview();
                lblSuccessMessage.Text = "Player has been Updated";
                lblErrorMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblSuccessMessage.Text = "";
                lblErrorMessage.Text = ex.Message;
            }

        }

    }
}