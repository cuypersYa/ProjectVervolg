<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InfoEvent.aspx.cs" Inherits="InfoEvent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Info Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <div class="floatLeft">
            <img src="Content/img/logoGym.png" class="logocreativity" />
        </div>
        <div class="floatLeft">
        <br />
        <asp:Label ID="lblEvent" runat="server" Text="Label"  CssClass="h1"></asp:Label>
        <br />
            </div>
     </div> 
      
     
   
    <div class="floatLeft">
        <!--<h2>Event id: <asp:Label ID="lblEventid" runat="server" Text="Label"></asp:Label></h2>-->
        <h2>Informatie Event</h2>
        <br />
        <asp:TextBox ID="lblEventInformation" runat="server" CssClass="textarea" ReadOnly="True" Height="100" Width="300" Wrap="True" TextMode="MultiLine"></asp:TextBox>

        <br />
        <br />
    
        <h2>Timetable</h2>
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
        
    <br />
   
        <h2>Aanwezige(n)</h2>
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
        <br />
    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
    <br />

    <br />
    <asp:Button ID="btnAfwezig" runat="server" Text="Aanwezig" CssClass="btn" OnClick="btnAfwezig_Click" />

    <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary btn-large" OnClick="btnEdit_Click" Text="Edit" />

    <asp:Button ID="btnVerwijder" runat="server" CssClass="btn btn-primary btn-large" OnClick="btnVerwijder_Click" Text="Verwijder" Visible="False" />

    <asp:Button iD="btnHome" Text="Ga terug" runat="server" CssClass="btn" OnClick="btnGaTerug_Click" />

   
    <div class="clearfix">
    </div>
 
    </div>
    <div class="floatQr">
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
        <h2>QR code</h2>
        <asp:Image ID="imgQrCode" runat="server" />
    </div>
    <div class="clearfix"></div>
    
    <div class="floatLeft">
        <h2>Comments</h2>
<<<<<<< HEAD
        <asp:Label ID="lblComment" runat="server" Text="Er zijn nog geen comments geplaatst"></asp:Label>
    <asp:Repeater ID="rptComments" runat="server" DataSourceID="">
=======
         <asp:Label ID="lblComment" runat="server" Text="Er zijn nog geen comments geplaatst"></asp:Label>
     <asp:Repeater ID="rptComments" runat="server" DataSourceID="">
>>>>>>> 5d381bc9a72244ee0e84710dca95ee835c1575c8
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

    <asp:TextBox ID="CommentBox" runat="server" CssClass="textarea" ReadOnly="False" Height="100" Width="500" Wrap="True" TextMode="MultiLine"></asp:TextBox>
    <br />
        <asp:RequiredFieldValidator ID="rqfCheck" runat="server" ControlToValidate="CommentBox" ErrorMessage="U kan geen lege comment plaatsen" ValidationGroup="leeg" CssClass="alert-danger"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnComment" runat="server" CssClass="btn" OnClick="btnComment_Click" Text="Post" ValidationGroup="leeg" />
    </div>
    <br />
  <div class="clearfix"></div>
</asp:Content>