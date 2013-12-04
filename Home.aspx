<%@ Page MasterPageFile="~/MasterPage.master" Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Created Events</title>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        
        <br />
        <asp:Label ID="lblWelkom" runat="server" Text="Label"  CssClass="h1"></asp:Label>
        <br />
     </div> 
        <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Repeater ID="rptEvents" runat="server">
            <HeaderTemplate>
                <table class="table table-striped">
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                     <asp:LinkButton ID="btnInfoEvent" OnClick="btnInfoEvent_Click" CommandArgument='<%# Eval("id") %>' runat="server" CssClass="h4">   <%# Eval("naam") %></asp:LinkButton>
                    </td>
                    <td>
                        <%# Eval("Datum", "{0:d}")%>
                    </td>
                    <td>
                        <%# Eval("visitors") %>
                    </td>
                    
                    


                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:ObjectDataSource ID="ObjdsEvents" runat="server" SelectMethod="SelectAllEvents" TypeName="BLLEvent"></asp:ObjectDataSource>
        
       
       <p class="floatRight">
            <asp:Button ID="btnMaakEvent" runat="server" OnClick="btnMaakEvent_Click" Text="Maak Event" CssClass="btn btn-primary btn-large"/>
        
            <asp:Button ID="btnAlleenAdmin" runat="server" Onclick="btnInfoEvent_Click" Text="Alleen Admin" CssClass="btn"/>
            
             <asp:Button ID="btnUitloggen" runat="server" CssClass="btn" OnClick="btnUitloggen_Click" Text="Uitloggen" />        
        </p>
       
       
        
       
</asp:Content>