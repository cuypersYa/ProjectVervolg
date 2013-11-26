<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InfoEvent.aspx.cs" Inherits="InfoEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Info Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <asp:Label ID="lblEvent" runat="server" CssClass="h1"> HIER KOMT DE NAAM VAN HET EVENT</asp:Label>
    </div>
        <asp:Label ID="lblgebruiker" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="lblEventid" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="lblEventInformation" runat="server" ReadOnly="True" Height="300" Width="300" Wrap="True" TextMode="MultiLine"></asp:TextBox>

        <br />
        <br />
        <asp:Repeater ID="rptAanwezig" runat="server" DataSourceID="">
            <HeaderTemplate>
                <table class="table table-striped">
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <%# Container.DataItem %>
                    </td>
                    
                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

     <asp:Repeater ID="rptSprekers" runat="server" DataSourceID="">
            <HeaderTemplate>
                <table class="table table-striped">
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td>
                        <%# Container.DataItem %>
                    </td>
                    
                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    <asp:Image ID="imgQrCode" runat="server" />
    

    </asp:Content>