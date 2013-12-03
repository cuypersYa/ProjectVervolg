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
using ASPSnippets.TwitterAPI;


public partial class InfoEvent : System.Web.UI.Page
{
    //string gebruiker = "";
    int gebruikerid = 0;
    int eventId = 0;
    BLLEvent BLLEvent = new BLLEvent();
    BLLAanwezig BLLAanwezig = new BLLAanwezig();
    BLLUser BLLUser = new BLLUser();
    BLLSpreker BLLSpreker = new BLLSpreker();

    protected void Page_Load(object sender, EventArgs e)
    {
        gebruikerid = (int)(Session["gebruikersid"]);
        IList<User> userLijst = BLLUser.selectgebruiker(gebruikerid);
        User user = userLijst[0];
        lblgebruiker.Text = user.voornaam;

        eventId = (int)(Session["eventid"]);
        List<Event> ActiefEventLijst = BLLEvent.SelectEvent(eventId);
        Event ActiefEvent = ActiefEventLijst[0];
        lblEvent.Text = ActiefEvent.naam;
        lblEventInformation.Text = ActiefEvent.informatie;

        lblEventid.Text = Convert.ToString(eventId);
        IList<int> Events = BLLAanwezig.SelectEvent(eventId);
        var Aanwezigen = new List<string>();

        if (user.Id == ActiefEvent.eigenaar)
        {
            btnEdit.Visible = true;
            btnVerwijder.Visible = true;
        }
        else
        {
            btnEdit.Visible = false;
            btnVerwijder.Visible = false;
        }


        foreach (int row in Events)
        {
            int id = row;
            List<User> TussenAanwezig = BLLUser.selectgebruiker(id);
            User persoon = TussenAanwezig[0];
            Aanwezigen.Add(persoon.voornaam + " " + persoon.naam);
        }


        rptAanwezig.DataSource = Aanwezigen;
        rptAanwezig.DataBind();


        List<Spreker> Sprekers = BLLSpreker.selectAll(eventId);
        List<string> LijstSprekers = new List<string>();
        List<string> LijstTijd = new List<string>();

        for (int i = 0; i < Sprekers.Count(); i++)
        {
            Spreker Spreker = Sprekers[i];
            LijstSprekers.Add(Spreker.naam + " " + Spreker.begintijd + " " + Spreker.eindtijd);
        }

        
        rptSprekers.DataSource = LijstSprekers;
        rptSprekers.DataBind();


        List<Aanwezig> LijstAanwezigen = new List<Aanwezig>();
        LijstAanwezigen = BLLAanwezig.SelectAlleAanwezige(eventId);
        List<System.Drawing.Image> LijstQR = new List<System.Drawing.Image>();

        eventId = (int)(Session["eventid"]);
        List<User> AanwezigeLijst = BLLUser.selectgebruiker(user.Id);
        User Aanwezige = AanwezigeLijst[0];

        foreach (Aanwezig row in LijstAanwezigen)
        {
            if (row.PersoonId == Aanwezige.Id)
            {
                btnAfwezig.Text = "Afwezig";
                for (int i = 0; i < LijstAanwezigen.Count(); i++)
                {
                    Aanwezig Aanwezigenqr = LijstAanwezigen[i];
                    QRCodeEncoder encoder = new QRCodeEncoder();
                    Bitmap img = encoder.Encode(Aanwezigenqr.qrcode);
                    img.Save("C:\\Users\\yannickcuypers01\\Documents\\Visual Studio 2012\\Projects\\ProjectVervolg\\img.jpg", ImageFormat.Jpeg);
                    imgQrCode.ImageUrl = "img.jpg";
                }
            }
            else
            {
                imgQrCode.Visible = false;
            }
        }

        Session["timeout"] = ActiefEvent.datum;
    }
    protected void btnAfwezig_Click(object sender, EventArgs e)
    {
        eventId = (int)(Session["eventid"]);
        gebruikerid = (int)(Session["gebruikersid"]);
        IList<User> userLijst = BLLUser.selectgebruiker(gebruikerid);
        User user = userLijst[0];
        if (btnAfwezig.Text == "Afwezig")
        {
            List<Aanwezig> LijstAanwezigen = new List<Aanwezig>();
            LijstAanwezigen = BLLAanwezig.SelectAlleAanwezige(eventId);


            List<User> AanwezigeLijst = BLLUser.selectgebruiker(user.Id);
            User Aanwezige = AanwezigeLijst[0];

            foreach (Aanwezig row in LijstAanwezigen)
            {
                if (row.PersoonId == Aanwezige.Id)
                {
                    BLLAanwezig.deletePersoon(Aanwezige.Id);
                    BLLEvent.afwezig(eventId);
                    btnAfwezig.Text = "Aanwezig";
                    Response.Redirect("~/Home.aspx");

                }
            }

        }
        else
        {

            IList<User> gebruikerlijst = BLLUser.selectgebruiker(user.Id);
            User gebruikers = gebruikerlijst[0];

            IList<int> Events = BLLAanwezig.SelectEvent(eventId);
            Aanwezig aanwezigmaak = new Aanwezig();
            aanwezigmaak.EventId = eventId;
            aanwezigmaak.PersoonId = gebruikers.Id;
            aanwezigmaak.qrcode = gebruikers.Id + gebruikers.naam + eventId;

            BLLAanwezig.insert(aanwezigmaak);
            BLLEvent.aanwezig(eventId);
            btnAfwezig.Text = "Afwezig";
            Response.Redirect("~/Home.aspx");
        }


    }

    protected void Timer(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now,
        DateTime.Parse(Session["timeout"].ToString())))
        {
            lblTimer.Text = "Time left: " +
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Days).ToString() + " days " +
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Hours).ToString() + " hours " +
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Minutes).ToString() + " mintues " +
            ((Int32)DateTime.Parse(Session["timeout"].ToString()).Subtract(DateTime.Now).Seconds).ToString() + " seconds ";
        }
    }
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        eventId = (int)(Session["eventid"]);
        List<Event> ActiefEventLijst = BLLEvent.SelectEvent(eventId);
        Event ActiefEvent = ActiefEventLijst[0];
        Session.Add("Event", ActiefEvent.Id);
        Response.Redirect("~/CreateEvent.aspx");
    }
    protected void btnVerwijder_Click(object sender, EventArgs e)
    {
        eventId = (int)(Session["eventid"]);
        BLLEvent.delete(eventId);
        Response.Redirect("~/Home.aspx");
    }
}