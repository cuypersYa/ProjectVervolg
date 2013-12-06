<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InfoEvent.aspx.cs" Inherits="InfoEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Info Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <asp:Label ID="lblEvent" runat="server" CssClass="h1"> HIER KOMT DE NAAM VAN HET EVENT</asp:Label>
    </div>
   
     
    <div class="floatLeft">
        <h1>Gebruiker: <asp:Label ID="lblgebruiker" runat="server" Text="Label" ></asp:Label></h1>
   </div>
        <div class="clearfix"></div>
    <div class="floatLeft">
        <!--<h2>Event id: <asp:Label ID="lblEventid" runat="server" Text="Label"></asp:Label></h2>-->
        <h2>Informatie Event</h2>
        <br />
        <asp:TextBox ID="lblEventInformation" runat="server" ReadOnly="True" Height="100" Width="300" Wrap="True" TextMode="MultiLine"></asp:TextBox>

        <br />
        <br />
    </div>
    <div class="floatLeft">
        <h2>De sprekers</h2>
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
        <h2>QR code</h2>
    <asp:Image ID="imgQrCode" runat="server" />
    <br />
    </div>
    <div class="floatLeft">
        <h2>Aanwezige</h2>
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
<<<<<<< HEAD
    </div>
    <div class="clearfix"></div>
      <div class="floatLeft">
=======
    <br />
    <asp:TextBox ID="CommentBox" runat="server" ReadOnly="False" Height="300" Width="300" Wrap="True" TextMode="MultiLine" MaxLength="400"></asp:TextBox>
    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="btnComment" runat="server" CssClass="btn" OnClick="btnComment_Click" Text="Post" />

    <br />
>>>>>>> 1961e742b5e1193d6fc41a4bbd2d93a5c18c4a52
    <asp:Button ID="btnAfwezig" runat="server" Text="Aanwezig" CssClass="btn" OnClick="btnAfwezig_Click" />

    <asp:Button ID="btnEdit" runat="server" CssClass="btn" OnClick="btnEdit_Click" Text="Edit" />

    <asp:Button ID="btnVerwijder" runat="server" CssClass="btn" OnClick="btnVerwijder_Click" Text="Verwijder" Visible="False" />

    <div class="color">
        <asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="timer" runat="server" Interval="1000" OnTick="Timer"></asp:Timer>
    </div>

    <div class="color">
        <asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Label ID="lblTimer" runat="server"></asp:Label>
    </ContentTemplate>

    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="timer" EventName ="tick" />
    </Triggers>
   
</asp:UpdatePanel>
        </div>
</div>
   
    

    
    <div class="floatLeft">
        <h2>Comments</h2>
    <asp:Repeater ID="rptComments" runat="server" DataSourceID="">
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
    </div>
    <div class="clearfix"></div>
    <div class="floatLeft">
        <h2>Post een comment</h2>
    <asp:TextBox ID="CommentBox" runat="server" ReadOnly="False" Height="100" Width="500" Wrap="True" TextMode="MultiLine"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnComment" runat="server" CssClass="btn" OnClick="btnComment_Click" Text="Post" />
    </div>
    <br />
  <div class="clearfix"></div>
</asp:Content>