<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Created Events</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <asp:Label ID="lblUser" runat="server" Text="User"></asp:Label>
        <br />
        <asp:Label ID="lblTest" runat="server" Text="Label"  CssClass="h1"></asp:Label>
        <br />
     </div> 
        <br />
        <br />
        <asp:Repeater ID="rptEvents" runat="server" DataSourceID="ObjdsEvents">
            <HeaderTemplate>
                <table class="table table-striped">
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                     <asp:LinkButton ID="btnInfoEvent" OnClick="btnInfoEvent_Click" CommandArgument='<%# Eval("id") %>' runat="server" CssClass="h4">   <%# Eval("naam") %></asp:LinkButton>
                    </td>
                    <td>
                        <%# Eval("visitors") %>
                    </td>
                    <td id="verwijder">
                        <asp:LinkButton ID="btnAanwezig" OnClick="btnAanwezig_Click" CommandArgument='<%# Eval("id") %>' runat="server" Text="aanwezig"></asp:LinkButton>
                    </td>

                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource ID="ObjdsEvents" runat="server" SelectMethod="SelectAllEvents" TypeName="BLLEvent"></asp:ObjectDataSource>
        
       
        <p>
            <asp:Button ID="btnMaakEvent" runat="server" OnClick="btnMaakEvent_Click" Text="Maak Event" CssClass="btn btn-primary btn-large"/>
        </p>
         <p>
            <asp:Button ID="btnAlleenAdmin" runat="server" Onclick="btnInfoEvent_Click" Text="Alleen Admin" CssClass="btn"/>
        </p>
       
       
        
       
</asp:Content>