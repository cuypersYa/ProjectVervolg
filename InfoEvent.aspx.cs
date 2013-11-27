using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;


public partial class InfoEvent : System.Web.UI.Page
{
    string gebruiker = "";
    int eventId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        gebruiker = (string)(Session["gebruikersnaam"]);
        lblgebruiker.Text = gebruiker;

        eventId = (int)(Session["eventid"]);
        BLLEvent BLLEvents = new BLLEvent();
        List<Event> ActiefEventLijst = BLLEvents.SelectEvent(eventId);
        Event ActiefEvent = ActiefEventLijst[0];
        lblEvent.Text = ActiefEvent.naam;
        lblEventInformation.Text = ActiefEvent.informatie;

        lblEventid.Text = Convert.ToString(eventId);
        BLLAanwezig SelectAanwezig = new BLLAanwezig();
        BLLUser SelectUser = new BLLUser();
        IList<int> Events = SelectAanwezig.SelectEvent(eventId);
        var Aanwezigen = new List<string>();
        

        foreach (int row in Events)
        {
            int id = row;
            List<User> TussenAanwezig = SelectUser.selectAanwezigen(id);
            User persoon = TussenAanwezig[0];
            Aanwezigen.Add(persoon.voornaam + " " + persoon.naam);
        } 


        rptAanwezig.DataSource = Aanwezigen;
        rptAanwezig.DataBind();

        BLLSpreker SelectSpreker = new BLLSpreker();
        List<Spreker> Sprekers = SelectSpreker.selectAll(eventId);
        List<string> LijstSprekers = new List<string>();
        List<string> LijstTijd = new List<string>();

        for (int i = 0; i < Sprekers.Count(); i++)
        {
            Spreker Spreker = Sprekers[i];
            LijstSprekers.Add(Spreker.naam + " " + Spreker.begintijd + " " + Spreker.eindtijd);
        }

        rptSprekers.DataSource = LijstSprekers;
        rptSprekers.DataBind();

        BLLAanwezig BllAanwezige = new BLLAanwezig();
        List<Aanwezig> LijstAanwezigen = new List<Aanwezig>();
        LijstAanwezigen = BllAanwezige.SelectAlleAanwezige(eventId);
        List<System.Drawing.Image> LijstQR = new List<System.Drawing.Image>();


        for (int i = 0; i < LijstAanwezigen.Count(); i++)
        {
            Aanwezig Aanwezigenqr = LijstAanwezigen[i];
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap img = encoder.Encode(Aanwezigenqr.qrcode);
            img.Save("C:\\Users\\Veerle\\Documents\\GitHub\\ProjectVervolg\\img.jpg", ImageFormat.Jpeg);
            imgQrCode.ImageUrl = "img.jpg";
        }
       
    }
    protected void btnAfwezig_Click(object sender, EventArgs e)
    {
        BLLAanwezig BllAanwezige = new BLLAanwezig();
        BLLUser BllUser = new BLLUser();
        BLLEvent BllEvent = new BLLEvent();
        List<Aanwezig> LijstAanwezigen = new List<Aanwezig>();
        LijstAanwezigen = BllAanwezige.SelectAlleAanwezige(eventId);

        eventId = (int)(Session["eventid"]);
        gebruiker = (string)(Session["gebruikersnaam"]);
        List <User> AanwezigeLijst = BllUser.selectgebruiker(gebruiker);
        User Aanwezige = AanwezigeLijst[0];

        foreach (Aanwezig row in LijstAanwezigen)
        {
            if (row.PersoonId == Aanwezige.Id)
            {
                BllAanwezige.deletePersoon(Aanwezige.Id);
                BllEvent.afwezig(eventId);
                Response.Redirect("~/Home.aspx");

            }
        }

    
    }
}