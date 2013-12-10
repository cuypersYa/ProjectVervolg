<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateEvent.aspx.cs" Inherits="CreateEvent"MasterPageFile="~/MasterPage.master"%>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Create  Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <div class="floatLeft">
            <img src="Content/img/logoGym.png" class="logocreativity" />
        </div>
        <div class="floatLeft">
        <br />
        <asp:Label runat="server" Text="Maak een nieuw event aan"  CssClass="h1"></asp:Label>
        <br />
            </div>
     </div> 
    <div class="floatLeft">
    <h2><asp:Label ID="lblTitel" runat="server" AssociatedControlID="txtTitel" Text="Titel"></asp:Label></h2>
        <asp:TextBox ID="txtTitel" AutoPostBack="true" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTitel" runat="server" ControlToValidate="txtTitel" ErrorMessage="Gelieve dit in te vullen" ValidationGroup="MaakAan" CssClass="alert-danger"></asp:RequiredFieldValidator>
            <asp:Label ID="lblFeedbackNaam" runat="server" CssClass="alert-warning"></asp:Label>
        <br />
      <h2><asp:Label ID="lblInformatie" runat="server" AssociatedControlID="txtInformatie" Text="Informatie"></asp:Label></h2>
        
        <asp:TextBox id="txtInformatie" CssClass="textarea" AutoPostBack="true" runat="server" TextMode="MultiLine" Height="300" Width="300"></asp:TextBox>

        <asp:RequiredFieldValidator ID="rfvInformatie" runat="server" ControlToValidate="txtInformatie" ErrorMessage="Gelieve dit in te vullen" ValidationGroup="MaakAan" CssClass="alert-danger"></asp:RequiredFieldValidator>
        <br />
       <h2><asp:Label ID="lblSprekers" runat="server" AssociatedControlID="txtSpreker1" Text="Timetable"></asp:Label></h2>
       

     <asp:TextBox ID="txtBeginTijd1" runat="server" TextMode="Time">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd1" runat="server" TextMode="Time">01:00</asp:TextBox><asp:TextBox ID="txtSpreker1" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd2" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd2" runat="server" TextMode="Time" Visible="False" >01:00</asp:TextBox><asp:TextBox ID="txtSpreker2" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd3" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd3" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker3" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd4" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd4" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker4" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd5" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd5" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker5" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd6" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd6" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker6" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd7" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd7" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker7" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd8" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd8" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker8" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd9" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd9" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker9" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><br />
     <asp:TextBox ID="txtBeginTijd10" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><asp:TextBox ID="txtEindTijd10" runat="server" TextMode="Time" Visible="False">01:00</asp:TextBox><asp:TextBox ID="txtSpreker10" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox>
    <asp:Label ID="lblFeedbackTijd" runat="server" CssClass="alert-warning"></asp:Label>
    </div>
    
   <div class="floatLeft">
        <h2><asp:Label ID="lblDatum" runat="server" AssociatedControlID="clDatum" Text="Datum"></asp:Label></h2>
        <asp:Calendar ID="clDatum" runat="server" AutoPostBack="true" SelectedDate="10/30/2013 18:03:17" VisibleDate="" ></asp:Calendar>
        <br />
        <asp:Label ID="lblFeedbackDatum" runat="server" CssClass="alert-danger"></asp:Label>
        <br />
       <br />
       <asp:Button ID="btnMaak" runat="server" OnClick="btnMaak_Click" Text="Maak aan" CssClass="btn btn-primary btn-large" ValidationGroup="MaakAan" />
       <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Ga terug" CssClass="btn" />
   </div>
        <br />
        
        <p>&nbsp;</p>

</asp:Content>