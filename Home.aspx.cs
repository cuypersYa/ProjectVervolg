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
    BLLEvent BLLEvent = new BLLEvent();
    BLLAanwezig BLLAanwezig = new BLLAanwezig();
    BLLUser BLLUser = new BLLUser();
    Boolean Aanwezig = false;

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
            IList<User> test = BLLUser.selectgebruiker(gebruiker);
            User tester = test[0];
            lblTest.Text = "Welkom " + tester.voornaam;

           /* foreach (RepeaterItem row in rptEvents.Items)
            {
                LinkButton btnAanwezig = (LinkButton)(sender);
                int eventid = row.Id;
                List<int> PersoonAanwezig = BLLAanwezig.SelectEvent(eventid);

                foreach (int rij in PersoonAanwezig)
                {
                    List<User> TussenAanwezig = BLLUser.selectAanwezigen(rij);
                    User persoon = TussenAanwezig[0];
                    if (persoon.gebruikersnaam == tester.gebruikersnaam)
                    {
                        Aanwezig = true;
                        btnAanwezig.Text = "Afwezig";
                    }



                }
            } */

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
        Aanwezig = false;
        
        
        if (gebruiker == "")
        {
            btnAanwezig.Attributes["style"] = "visibility: hidden";
        }
        else
        {

        
            int id = Convert.ToInt16(btnAanwezig.CommandArgument);

            
            

            IList<User> test = BLLUser.selectgebruiker(gebruiker);
            User tester = test[0];

            IList<int> Events = BLLAanwezig.SelectEvent(id);
            
            foreach (int row in Events)
                {
                List<User> TussenAanwezig = BLLUser.selectAanwezigen(row);
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
                
                
                BLLAanwezig.insert(aanwezigmaak);
                BLLEvent.aanwezig(id);
                //tabel verversen
                rptEvents.DataBind();

            }
            else
            {
                btnAanwezig.Text = "Afwezig";
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

    protected void btnUitloggen_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/SignIn.aspx");
    }
}