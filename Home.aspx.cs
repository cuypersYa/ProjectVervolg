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
        lblWelkom.Text = "Welkom " + user.voornaam;
        lblFeedback.Text = (string)(Session["feedback"]);

        if (user.rol == "gewoon")
        {
            btnAdmin.Visible = true;
        }
        else
        {
            btnAdmin.Visible = false;
        }
        List<Event> AllEvents = BLLEvent.SelectAllEvents();
        rptEvents.DataSource = AllEvents.OrderBy(x => x.datum);
        rptEvents.DataBind();
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
        Session.Add("feedbacklogin", "Je bent uitgelogd");
        Response.Redirect("~/SignIn.aspx");
    }
    protected void btnAdmin_Click(object sender, EventArgs e)
    {
        Session.Add("gebruikersid", gebruikerid);
        Response.Redirect("~/Admin.aspx");
    }
}