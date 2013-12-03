using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    int gebruikerid = 0;
    //string gebruiker = "";
    BLLEvent BLLEvent = new BLLEvent();
    BLLAanwezig BLLAanwezig = new BLLAanwezig();
    BLLUser BLLUser = new BLLUser();

    protected void Page_Load(object sender, EventArgs e)
    {

        List<Event> Events = BLLEvent.SelectAllEvents();
        foreach (Event row in Events)
        {
            if (row.datum < DateTime.Now)
            {
                BLLEvent.delete(row.Id);

            }
        }
        gebruikerid = (int)(Session["gebruikersid"]);
        CreativityEventDataContext dc = new CreativityEventDataContext();
        
        IList<User> userLijst = BLLUser.selectgebruiker(gebruikerid);
        User user = userLijst[0];
        lblUser.Text = user.gebruikersnaam;
        lblTest.Text = "Welkom " + user.voornaam;

        if (user.rol == "gewoon")
        {
            btnAlleenAdmin.Visible = true;
        }
        else
        {
            btnAlleenAdmin.Visible = false;
        }
        List<Event> AllEvents = BLLEvent.SelectAllEvents();
        rptEvents.DataSource = AllEvents;

       }
 
    protected void btnInfoEvent_Click(object sender, EventArgs e)
    {
        LinkButton btnInfoEvent = (LinkButton)(sender);
        int id = Convert.ToInt16(btnInfoEvent.CommandArgument);
        Session.Add("gebruikersid", gebruikerid);
        Session.Add("eventid", id);
        Response.Redirect("~/InfoEvent.aspx");
    }


    protected void btnMaakEvent_Click(object sender, EventArgs e)
    {
        Session.Add("gebruikersid", gebruikerid);
        Session.Add("eventid", 0);
        Response.Redirect("~/CreateEvent.aspx");
        
    }

    protected void btnUitloggen_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SignIn.aspx");
    }
}