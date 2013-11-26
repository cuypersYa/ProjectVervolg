<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateEvent.aspx.cs" Inherits="CreateEvent"MasterPageFile="~/MasterPage.master"%>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Create  Events</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderId="ContentHeadCenter" runat="server">
    <div class="page-header">
        <asp:Label Text="Maak een nieuw event aan" runat="server"  CssClass="h1"></asp:Label>
    </div>
        <asp:Label ID="lblTitel" runat="server" AssociatedControlID="txtTitel" Text="Titel"></asp:Label>
        <asp:TextBox ID="txtTitel" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvTitel" runat="server" ControlToValidate="txtTitel" ErrorMessage="Gelieve dit in te vullen"></asp:RequiredFieldValidator>
            <asp:Label ID="lblFeedbackNaam" runat="server" ></asp:Label>
        <br />
        <asp:Label ID="lblInformatie" runat="server" AssociatedControlID="txtInformatie" Text="Informatie"></asp:Label>
        <br />
        <asp:TextBox id="txtInformatie" runat="server" TextMode="MultiLine" Height="300" Width="300"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvInformatie" runat="server" ControlToValidate="txtInformatie" ErrorMessage="Gelieve dit in te vullen"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lblSprekers" runat="server" AssociatedControlID="txtSpreker1" Text="Sprekers"></asp:Label>
        <br />

        <asp:TextBox ID="txtSpreker1" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged"></asp:TextBox><asp:TextBox ID="txtTijd1" runat="server" TextMode="Time">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker2" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd2" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker3" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd3" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker4" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd4" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker5" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd5" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker6" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd6" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker7" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd7" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker8" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd8" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker9" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd9" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
     <asp:TextBox ID="txtSpreker10" runat="server" AutoPostBack="true" OnTextChanged="txtSpreker1_TextChanged" Visible="False"></asp:TextBox><asp:TextBox ID="txtTijd10" runat="server" TextMode="Time" Visible="False">00:00</asp:TextBox><br />
    

        <br />
        <asp:Label ID="lblDatum" runat="server" AssociatedControlID="clDatum" Text="Datum"></asp:Label>
        <asp:Calendar ID="clDatum" runat="server" SelectedDate="10/30/2013 18:03:17" ></asp:Calendar>
        <asp:Label ID="lblFeedbackDatum" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnMaak" runat="server" OnClick="btnMaak_Click" Text="Maak aan" CssClass="btn btn-primary btn-large" />
        <p>
            &nbsp;</p>

</asp:Content>