<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Admin</title>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderId="ContentHeadCenter" runat="server">
   
    <div class="page-header">
        
        <br />
        <asp:Label ID="lblAdmin" runat="server" Text="Kies de User die je Admin wil maken."  CssClass="h1"></asp:Label>
        <br />
     </div> 
    <div>
    
        <asp:DropDownList ID="ddlGebruikers" runat="server">
        </asp:DropDownList>
    
    </div>
        <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="Maak admin" CssClass="btn" />
   
</asp:Content>

