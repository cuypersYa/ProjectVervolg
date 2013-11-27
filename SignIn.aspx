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
       <asp:Button ID="btnNietlog" runat="server" OnClick="btnNietlog_Click" Text="Log niet in" CssClass="btn btn-default" />
       <asp:Button ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Sign up" CssClass="btn btn-default" />
        
<hr />





<table runat="server" id="tblTwitter" visible="false">
    <tr>
        <td colspan="2">
            <u>Logged in Twitter User's Profile</u>
        </td>
    </tr>
    <tr>
        <td style="width: 100px">
            Profile Image
        </td>
        <td>
            <asp:Image ID="imgProfile" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Name
        </td>
        <td>
            <asp:Label ID="lblName" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Twitter Id
        </td>
        <td>
            <asp:Label ID="lblTwitterId" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Screen Name
        </td>
        <td>
            <asp:Label ID="lblScreenName" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Description
        </td>
        <td>
            <asp:Label ID="lblDescription" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Tweets
        </td>
        <td>
            <asp:Label ID="lblTweets" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Followers
        </td>
        <td>
            <asp:Label ID="lblFollowers" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Friends
        </td>
        <td>
            <asp:Label ID="lblFriends" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Favorites
        </td>
        <td>
            <asp:Label ID="lblFavorites" runat="server" />
        </td>
    </tr>
    <tr>
        <td>
            Location
        </td>
        <td>
            <asp:Label ID="lblLocation" runat="server" />
        </td>
    </tr>
</table>

       
    </div>
    </div>
    
</asp:Content>
