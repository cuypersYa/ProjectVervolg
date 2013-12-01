<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="SignIn.aspx.cs" Inherits="SignIn" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Sign In</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="jumbotron">
        <br />
      <div class="container">
        <asp:Label ID="lblGebruikersnaam" runat="server" AssociatedControlID="txtGebruikersnaam" Text="Gebruikersnaam"></asp:Label>
        <asp:TextBox ID="txtGebruikersnaam" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvGebruiker" ValidationGroup="normalLogin" runat ="server" ControlToValidate="txtGebruikersnaam" ErrorMessage="Dit mag niet leeg blijven" CssClass="alert-danger"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblWachtwoord" runat="server" AssociatedControlID="txtWachtwoord" Text="Wachtwoord"></asp:Label>
        <asp:TextBox ID="txtWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvWachtwoord" ValidationGroup="normalLogin" runat="server" ControlToValidate="txtWachtwoord" ErrorMessage="Dit mag niet leeg blijven" CssClass="alert-danger"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="btnLogin" runat="server" ValidationGroup="normalLogin" OnClick="btnLogin_Click" Text="Log in"  CssClass="btn btn-primary btn-large" />
        
        <asp:Label ID="lblwerkt" runat="server" Text=""></asp:Label>

       <asp:Button ID="btnFacebook" runat="server" Text="Login with FaceBook" OnClick="LoginFacebook" CssClass="btn btn-default" />
       <asp:Button ID="btnTwitter" runat="server" Text="Login with Twitter" OnClick="LoginTwitter" CssClass="btn btn-default"/>
       <asp:Button ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Sign up" CssClass="btn btn-default" />
 

        </div>
    </div>
    
</asp:Content>
