<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="Player_Registration_Form.userlogin" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <link href="Content/bootstrap.css" rel="stylesheet" />
      <title></title>
   </head>
   <body>
      <div class="container">
         <div class="row justify-content-center align-items-center" style="height:100vh">
            <div class="col-4">
               <div class="card">
                  <div class="card-body">
                     <form runat="server">
                        <div class="form-group">
                           <asp:Label ID="Label1" runat="server" Text="Admin Access"></asp:Label>
                        </div>
                        <div class="form-group">
                           <asp:Label ID="Label2" runat="server" Text="User Name :"></asp:Label>
                           <asp:TextBox ID="UserID_TextBox1" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Label ID="Label3" runat="server" Text="Password :"></asp:Label>
                           <asp:TextBox ID="password_TextBox2" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log In" class="btn btn-primary"/>
                           <asp:Label ID="Label4" runat="server"></asp:Label>
                        </div>
                     </form>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </body>
</html>