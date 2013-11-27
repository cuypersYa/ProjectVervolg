using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{

    string gebruiker = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       
        BLLEvent BLLEvents = new BLLEvent();
        List<Event> Events = BLLEvents.SelectAllEvents();
        foreach (Event row in Events)
        {
            if (row.datum < DateTime.Now)
            {
                BLLEvents.delete(row.Id);
            }
        }
        
        
        
        gebruiker = (string)(Session["gebruikersnaam"]);
        if (gebruiker == "")
        {
            btnAlleenAdmin.Visible = false;
            btnMaakEvent.Visible = false;
            lblTest.Text = "Welkom";
            
        }
        else
        {
            CreativityEventDataContext dc = new CreativityEventDataContext();
            
            lblUser.Text = gebruiker;
            BLLUser inladen = new BLLUser();
            IList<User> test = inladen.selectgebruiker(gebruiker);
            User tester = test[0];
            lblTest.Text = "Welkom " + tester.voornaam;


            if (tester.rol == "gewoon")
            {
                btnAlleenAdmin.Visible = true;
            }
            else
            {
                btnAlleenAdmin.Visible = false;
            }
        }
    }



    protected void btnAanwezig_Click(object sender, EventArgs e)
    {
        gebruiker = (string)(Session["gebruikersnaam"]);
        LinkButton btnAanwezig = (LinkButton)(sender);
        BLLUser inladen = new BLLUser();
        Boolean Aanwezig = false;
        
        if (gebruiker == "")
        {
            btnAanwezig.Attributes["style"] = "visibility: hidden";
        }
        else
        {

        
            int id = Convert.ToInt16(btnAanwezig.CommandArgument);

            BLLEvent BLLEvent = new BLLEvent();
            BLLAanwezig SelectAanwezig = new BLLAanwezig();
            

            IList<User> test = inladen.selectgebruiker(gebruiker);
            User tester = test[0];

            IList<int> Events = SelectAanwezig.SelectEvent(id);
            
            foreach (int row in Events)
                {
                List<User> TussenAanwezig = inladen.selectAanwezigen(row);
                User persoon = TussenAanwezig[0];
                if (persoon.gebruikersnaam == tester.gebruikersnaam){
                Aanwezig = true;
                }
            }
            if (Aanwezig == false)
            {
                             
                Aanwezig aanwezigmaak = new Aanwezig();
                aanwezigmaak.EventId = id;
                aanwezigmaak.PersoonId = tester.Id;
                aanwezigmaak.qrcode = tester.Id + tester.naam + id;
                
                BLLAanwezig aanwezigmaken = new BLLAanwezig();
                aanwezigmaken.insert(aanwezigmaak);
                BLLEvent.aanwezig(id);
                //tabel verversen
                rptEvents.DataBind();

            }
            else
            {
                btnAanwezig.Attributes["style"] = "visibility: hidden";
            }
        }
    }

    protected void btnInfoEvent_Click(object sender, EventArgs e)
    {

        LinkButton btnInfoEvent = (LinkButton)(sender);
        int id = Convert.ToInt16(btnInfoEvent.CommandArgument);
        Session.Add("gebruikersnaam", gebruiker);
        Session.Add("eventid", id);
        Response.Redirect("~/InfoEvent.aspx");


    }


    protected void btnMaakEvent_Click(object sender, EventArgs e)
    {
        Session.Add("gebruikersnaam", gebruiker);
        Response.Redirect("~/CreateEvent.aspx");
        
    }
 
}