<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Player_Registration_Form.register" Async ="true" %> 
<!DOCTYPE html>
<html>
   <head runat="server">
      <link href="Content/bootstrap.css" rel="stylesheet" />
      <title></title>
   </head>
   <body>
      <div class="container">
         <form runat="server">
            <div class="form-row">
               <div class="form-group col-md-6">
                  <label for ="fname">First Name: </label>
                  <asp:Textbox runat ="server" ID ="fname" class="form-control"></asp:Textbox>
               </div>
               <div class="form-group col-md-6">
                  <label for ="lname">Last Name: </label>
                  <asp:Textbox runat ="server" ID ="lname" class="form-control"></asp:Textbox>
               </div>
            </div>
            <div class="form-row">
               <div class="form-group col-md-6">
                  <label for ="mobNumber">Mobile Number: </label>
                  <asp:Textbox runat ="server" ID ="mobNumber" class="form-control"></asp:Textbox>
               </div>
               <div class="form-group col-md-6">
                  <label for ="email">Email: </label>
                  <asp:Textbox runat ="server" ID ="email" class="form-control" placeholder ="example@gmail.com"></asp:Textbox>
                  <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
               </div>
            </div>
            <div class="form-group">
               <label for ="address1">Address: </label>
               <asp:Textbox runat ="server" ID ="Textbox_add" class="form-control" placeholder="1234 Main St"></asp:Textbox>
            </div>
            <div class="form-row">
               <div class="form-group col-md-6">
                  <label for ="city1">City: </label>
                  <asp:Textbox runat ="server" ID ="Textbox_city" class="form-control"></asp:Textbox>
               </div>
               <div class="form-group col-md-6">
                  <label for ="postcode">Postal Code: </label>
                  <asp:Textbox runat ="server" ID ="Textbox_postcode" class="form-control"></asp:Textbox>
               </div>
            </div>
            <div class="form-row">
               <div class="form-group col-md-6">
                  <label for="birthday">Date of Birth:</label>
                  <asp:TextBox ID="TxtDob" runat="server" Text='<%# Bind("DateofBirth") %>' TextMode="Date" class="form-control"></asp:TextBox>
               </div>
               <div class="form-group col-md-6">
                  <label>Gender:</label>
                  <asp:DropDownList ID="genderList" runat="server" class="form-control">
                     <asp:ListItem Enabled="true" Text="Select" Value="Not Selected"></asp:ListItem>
                     <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                     <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                     <asp:ListItem Text="Gender Diverse" Value="Gender Diverse"></asp:ListItem>
                  </asp:DropDownList>
               </div>
            </div>
            <div class="form-row">
               <div class="form-group col-md-6">
                  <asp:DropDownList ID="cricketClub" runat="server" class="form-control">
                     <asp:ListItem Enabled="true" Text="Select Club" Value="Not Selected"></asp:ListItem>
                     <asp:ListItem Text="Papatoetoe Cricket Club" Value="Papatoetoe Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Parnell Cricket Club" Value="Parnell Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Howick Pakuranga Cricket Club" Value="Howick Pakuranga Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Suburbs New Lynn Cricket Club" Value="Suburbs New Lynn Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Cornwall Cricket Club" Value="Cornwall Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Takapuna Cricket Club" Value="Takapuna Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="Auckland University Cricket Club" Value="Auckland University Cricket Club"></asp:ListItem>
                     <asp:ListItem Text="North Shore Cricket Club" Value="North Shore Cricket Club"></asp:ListItem>
                  </asp:DropDownList>
               </div>
               <div class="form-group col-md-6">
                  <asp:DropDownList ID="member_type" runat="server" class="form-control">
                     <asp:ListItem Enabled="true" Text="New Member" Value="Not selected"></asp:ListItem>
                     <asp:ListItem Text="Yes" Value="Yes"></asp:ListItem>
                     <asp:ListItem Text="No" Value="No"></asp:ListItem>
                  </asp:DropDownList>
               </div>
            </div>
            <asp:Button id ="Button1" runat ="server" Text ="Save" OnClick="Save_btn" class="btn btn-primary"/>
            <asp:Button id ="Button2" runat ="server" Text ="Cancel" class="btn btn-danger"/>
         </form>
      </div>
   </body>
</html>