<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateUser.aspx.cs" Inherits="CreateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Created Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    
       
     <div class="page-header">
        <div class="floatLeft">
            <img src="Content/img/logoGym.png" class="logocreativity" />
        </div>
        <div class="floatLeft">
        <br />
        <asp:Label  runat="server" Text="Registreer u hier"  CssClass="h1"></asp:Label>
        <br />
            </div>
         </div>
     <div class="jumbotron">
    <div class="hero-unit">
        
        
    <table class="createUser">
    <tr>
        <td><asp:Label ID="lblNaam" runat="server" AssociatedControlID="txtNaam" Text="Naam"></asp:Label></td>
        <td><asp:TextBox ID="txtNaam" runat="server"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="rqvLeeg1" runat="server" ControlToValidate="txtNaam" ErrorMessage="Mag niet leeg blijven" ValidationGroup="create" CssClass="alert-danger"></asp:RequiredFieldValidator></td>
     </tr>
     <tr>
        <td><asp:Label ID="lblVoornaam" runat="server" AssociatedControlID="txtVoornaam" Text="Voornaam"></asp:Label></td>
        <td><asp:TextBox ID="txtVoornaam" runat="server"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="rqvLeeg2" runat="server" ControlToValidate="txtVoornaam" ErrorMessage="Mag niet leeg blijven" ValidationGroup="create" CssClass="alert-danger"></asp:RequiredFieldValidator></td>
      </tr>  
        <tr>
            <td><asp:Label ID="lblEmail" runat="server" AssociatedControlID="txtEmail" Text="E-mailadres"></asp:Label></td>
            <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            <td><asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Geen geldig e-mailadres" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="create" CssClass="alert-danger"></asp:RegularExpressionValidator></td>
        </tr>
      <tr>
        <td><asp:Label ID="lblGebruikersnaam" runat="server" AssociatedControlID="txtGebruikersnaam" Text="Gebruikersnaam"></asp:Label></td>
        <td><asp:TextBox ID="txtGebruikersnaam" runat="server"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="rfvLeeg3" runat="server" ControlToValidate="txtGebruikersnaam" ErrorMessage="Mag niet leeg blijven" ValidationGroup="create" CssClass="alert-danger"></asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td><asp:Label ID="lblWachtwoord" runat="server" AssociatedControlID="txtWachtwoord" Text="Wachtwoord"></asp:Label></td>
        <td><asp:TextBox ID="txtWachtwoord" runat="server" TextMode="Password"></asp:TextBox></td>
        <td><asp:RequiredFieldValidator ID="rfvLeeg4" runat="server" ControlToValidate="txtWachtwoord" ErrorMessage="Mag niet leeg blijven" ValidationGroup="create" CssClass="alert-danger"></asp:RequiredFieldValidator></td>
      </tr>
      <tr>
        <td><asp:Label ID="lblWachtwoord2" runat="server" AssociatedControlID="txtWachtwoord2" Text="Herhaal wachtwoord"></asp:Label></td>
        <td><asp:TextBox ID="txtWachtwoord2" runat="server" TextMode="Password"></asp:TextBox></td>
        <td><asp:CompareValidator ID="cvWachtwoord" runat="server" ControlToCompare="txtWachtwoord" ControlToValidate="txtWachtwoord2" ErrorMessage="Wachtwoord komt niet overeen" ValidationGroup="create" CssClass="alert-danger"></asp:CompareValidator></td>
       </tr>
    </table>
        <asp:Button ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Sign up" CssClass="btn btn-primary btn-large" ValidationGroup="create"/>
        <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Ga terug" CssClass="btn" />
    </div>
        <asp:Label ID="lblinorde" runat="server"></asp:Label>
        </div>
</asp:Content>