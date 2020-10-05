<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UI.Web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
<<<<<<< Updated upstream
=======
    
      <div id="LoginBox">
          <h1>Bienvenido</h1>
          <div class="textbox1">
              <i class="fas fa-user"></i>
              <input  type="text" placeholder="Usuario" name="Usuario" value="" />
             <%-- <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
          </div>
          <div class="textbox1">
              <i class="fas fa-lock"></i>
              <input  type="password" placeholder="Contraseña" name="Pass" value="" />
          </div>
          <asp:LinkButton ID="ingresarLinkButton" runat="server" Width="50" OnClick="ingresarLinkButton_Click">Ingresar</asp:LinkButton>
         
          
      </div>
>>>>>>> Stashed changes
</asp:Content>
