<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Admin</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderId="ContentHeadCenter" runat="server">
   
    <div class="page-header">
        <div class="floatLeft">
            <img src="Content/img/logoGym.png" class="logocreativity" />
        </div>
        <div class="floatLeft">
        <br />
        <asp:Label runat="server" Text="Admins aanpassen"  CssClass="h1"></asp:Label>
        <br />
            </div>
     </div> 
    <div class="floatLeft">
    
        <asp:DropDownList ID="ddlGebruikers" runat="server">
        </asp:DropDownList>
    
    </div>
    <div class="clearfix"></div>
    <div class="floatLeft">
        <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="Maak admin" CssClass="btn btn-primary btn-large" />
        <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Ga terug" CssClass="btn" />
    </div>
        
   
</asp:Content>

