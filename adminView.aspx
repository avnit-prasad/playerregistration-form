<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminView.aspx.cs" Inherits="Player_Registration_Form.adminView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
          <link href="Content/bootstrap.css" rel="stylesheet" />

    <title></title>
</head>
<body>
    <div class ="container">
    <form id="form1" runat="server">
        <asp:GridView ID="GridView2" runat="server" ShowFooter ="True" DataKeyNames ="memberID" AutoGenerateColumns="False" ShowHeaderWhenEmpty ="True" 
            OnRowCommand ="GridView2_RowCommand" OnRowEditing ="GridView2_RowEditing" OnRowCancelingEdit ="GridView2_RowCancelingEdit" OnRowUpdating ="GridView2_RowUpdating" 
         CssClass="table table-condensed table-hover table-responsive"
            >
        
        <Columns>
            <asp:TemplateField HeaderText ="First Name">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strfirstName") %>' runat ="server"/>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtFirstName" Text='<%# Eval("strfirstName") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="firstNameFooter" runat ="server" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText ="Last Name">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strlastName") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtLastName" Text='<%# Eval("strlastName") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="lastNameFooter" runat ="server" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText ="Email">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strEmail") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtEmail" Text='<%# Eval("strEmail")%>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="EmailFooter" runat ="server" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText ="Address">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strAddress") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtAddress" Text='<%# Eval("strAddress") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="AddressFooter" runat ="server" />
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText ="Postal Code">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strPostalcode") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtPostalCode" Text='<%# Eval("strPostalcode") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="PostalCodeFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText ="City">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strCity") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtCity" Text='<%# Eval("strCity") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="CityFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText ="Mobile">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strMobile") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtMobile" Text='<%# Eval("strMobile") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="MobileFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText ="Playing Level">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strPlayingLevel") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtPlayingLevel" Text='<%# Eval("strPlayinglevel") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="PlayingLevelFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText ="Existing Member">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strMember") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtMember" Text='<%# Eval("strMember") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="memberFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText ="Gender">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strGender") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtGender" Text='<%# Eval("strGender") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="genderFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText ="Date of Birth">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("strDOB") %>' runat ="server" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Textbox ID ="txtDOB" Text='<%# Eval("strDOB") %>' runat ="server" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID ="DOBFooter" runat ="server" />
                </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                     <FooterTemplate>  
                    <asp:Button ID="ButtonAdd" runat="server" Text="Add Row" CommandName ="AddNew"/> 
                     </FooterTemplate> 
                </asp:TemplateField> 
        </Columns>
        </asp:GridView>
        <br />
        <asp:label ID ="lblSuccessMessage" Text ="" runat ="server" ForeColor ="Green" />
        <br />
        <asp:label ID ="lblErrorMessage" Text ="" runat ="server" ForeColor ="Red" />

    </form>
         </div>
    </body>
</html>
