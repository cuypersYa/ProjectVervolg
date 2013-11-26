using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        IList<int> Events = SelectAanwezig.SelectAllAanwezige(eventId);
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
            LijstSprekers.Add(Spreker.naam);
        }
        for (int i = 0; i < Sprekers.Count(); i++)
        {
            Spreker Spreker = Sprekers[i];
            LijstSprekers.Add(Spreker.begintijd + " " + Spreker.eindtijd);
        }
        
        rptSprekers.DataSource = LijstSprekers;
        rptSprekers.DataBind();

        rptTijd.DataSource = LijstTijd;
        rptTijd.DataBind();


    }
}