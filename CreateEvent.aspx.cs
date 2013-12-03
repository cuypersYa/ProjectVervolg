using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CreateEvent : System.Web.UI.Page
{
    int gebruikerid = 0;
    int eventid = 0;
    List<string> Sprekernaam = new List<string>();
    List<string> Sprekerbegintijd = new List<string>();
    List<string> Sprekereindtijd = new List<string>();
    BLLSpreker BLLSpreker = new BLLSpreker();
    BLLUser BLLUser = new BLLUser();
    BLLEvent BLLEvent = new BLLEvent();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        gebruikerid = (int)(Session["gebruikersid"]);
        eventid = (int)(Session["eventid"]);
        if (eventid > 0)
        {
            if (!IsPostBack)
            {
                List<Event> lijstEvent = BLLEvent.SelectEvent(eventid);
                Event ActiefEvent = lijstEvent[0];
                txtTitel.Text = ActiefEvent.naam;
                txtInformatie.Text = ActiefEvent.informatie;
                clDatum.SelectedDate = ActiefEvent.datum;
                btnMaak.Text = "Pas aan";
                txtSpreker1.Visible = false;
                txtBeginTijd1.Visible = false;
                txtEindTijd1.Visible = false;
            }
        }
        else
        {
            btnMaak.Text = "Maak aan";
        }
    }

    public void txtSpreker1_TextChanged(object sender, EventArgs e)
    {

        int spreker;

        if (txtSpreker2.Visible == false)
        {
            Session.Add("sprekergetal", 1);
            Sprekernaam.Add(txtSpreker1.Text);
            if (Convert.ToDateTime(txtBeginTijd1.Text) < Convert.ToDateTime(txtEindTijd1.Text))
            {
                lblFeedbackTijd.Text = "";
                Sprekerbegintijd.Add(txtBeginTijd1.Text);
                Sprekereindtijd.Add(txtEindTijd1.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijstbegintijd", Sprekerbegintijd);
                Session.Add("lijsteindtijd", Sprekereindtijd);
            }
            else
            {
                lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
            }
        }
        Sprekernaam = (List<string>)Session["lijstsprekers"];
        Sprekerbegintijd = (List<string>)Session["lijstbegintijd"];
        Sprekereindtijd = (List<string>)Session["lijsteindtijd"];
        spreker = (int)Session["sprekergetal"];
        spreker++;
        switch (spreker)
        {

            case 2: txtSpreker2.Visible = true;
                txtBeginTijd2.Visible = true;
                txtEindTijd2.Visible = true;

                Session.Add("sprekergetal", 2);
                break;

            case 3: txtSpreker3.Visible = true;
                txtBeginTijd3.Visible = true;
                txtEindTijd3.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd2.Text) < Convert.ToDateTime(txtEindTijd2.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker2.Text);
                    Sprekerbegintijd.Add(txtBeginTijd2.Text);
                    Sprekereindtijd.Add(txtEindTijd2.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 3);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 4: txtSpreker4.Visible = true;
                txtBeginTijd4.Visible = true;
                txtEindTijd4.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd3.Text) < Convert.ToDateTime(txtEindTijd3.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker3.Text);
                    Sprekerbegintijd.Add(txtBeginTijd3.Text);
                    Sprekereindtijd.Add(txtEindTijd3.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 4);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 5: txtSpreker5.Visible = true;
                txtBeginTijd5.Visible = true;
                txtEindTijd5.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd4.Text) < Convert.ToDateTime(txtEindTijd4.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker4.Text);
                    Sprekerbegintijd.Add(txtBeginTijd4.Text);
                    Sprekereindtijd.Add(txtEindTijd4.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 5);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 6: txtSpreker6.Visible = true;
                txtBeginTijd6.Visible = true;
                txtEindTijd6.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd5.Text) < Convert.ToDateTime(txtEindTijd5.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker5.Text);
                    Sprekerbegintijd.Add(txtBeginTijd5.Text);
                    Sprekereindtijd.Add(txtEindTijd5.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 6);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 7: txtSpreker7.Visible = true;
                txtBeginTijd7.Visible = true;
                txtEindTijd7.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd6.Text) < Convert.ToDateTime(txtEindTijd6.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker6.Text);
                    Sprekerbegintijd.Add(txtBeginTijd6.Text);
                    Sprekereindtijd.Add(txtEindTijd6.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 7);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 8: txtSpreker8.Visible = true;
                txtBeginTijd8.Visible = true;
                txtEindTijd8.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd7.Text) < Convert.ToDateTime(txtEindTijd7.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker7.Text);
                    Sprekerbegintijd.Add(txtBeginTijd7.Text);
                    Sprekereindtijd.Add(txtEindTijd7.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 8);
                }
                else
                {

                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 9: txtSpreker9.Visible = true;
                txtBeginTijd9.Visible = true;
                txtEindTijd9.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd8.Text) < Convert.ToDateTime(txtEindTijd8.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker8.Text);
                    Sprekerbegintijd.Add(txtBeginTijd8.Text);
                    Sprekereindtijd.Add(txtEindTijd8.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 9);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;

            case 10: txtSpreker10.Visible = true;
                txtBeginTijd10.Visible = true;
                txtEindTijd10.Visible = true;
                if (Convert.ToDateTime(txtBeginTijd9.Text) < Convert.ToDateTime(txtEindTijd9.Text))
                {
                    lblFeedbackTijd.Text = "";
                    Sprekernaam.Add(txtSpreker9.Text);
                    Sprekerbegintijd.Add(txtBeginTijd9.Text);
                    Sprekereindtijd.Add(txtEindTijd9.Text);
                    Session.Add("lijstsprekers", Sprekernaam);
                    Session.Add("lijstbegintijd", Sprekerbegintijd);
                    Session.Add("lijsteindtijd", Sprekereindtijd);
                    Session.Add("sprekergetal", 10);
                }
                else
                {
                    lblFeedbackTijd.Text = "De eindtijd moet hoger zijn dan de begintijd";
                }
                break;
        }

    }
    protected void btnMaak_Click(object sender, EventArgs e)
    {
        if (btnMaak.Text == "Maak aan")
        {


            lblFeedbackNaam.Text = "";
            Boolean toegestaan = true;

            Sprekernaam = (List<string>)Session["lijstsprekers"];
            Sprekerbegintijd = (List<string>)Session["lijstbegintijd"];
            Sprekereindtijd = (List<string>)Session["lijsteindtijd"];

            IList<User> userlijst = BLLUser.selectgebruiker(gebruikerid);
            User user = userlijst[0];
            gebruikerid = user.Id;
            Event newEvent = new Event();
            List<Event> LijstEvents = BLLEvent.SelectAllEvents();

            foreach (Event row in LijstEvents)
            {
                if (txtTitel.Text == row.naam)
                {
                    lblFeedbackNaam.Text = "Naam van het evenement bestaat al";
                    toegestaan = false;
                }
                if (clDatum.SelectedDate < DateTime.Now)
                {
                    lblFeedbackDatum.Text = "Datum ligt in het verleden";
                    toegestaan = false;
                }

            }
            if (toegestaan == true)
            {
                lblFeedbackDatum.Text = "";
                newEvent.naam = txtTitel.Text;
                newEvent.informatie = txtInformatie.Text;
                newEvent.datum = clDatum.SelectedDate;
                newEvent.eigenaar = gebruikerid;
                newEvent.visitors = 0;
                BLLEvent.insert(newEvent);
                if (txtSpreker1.Text == "")
                {

                }
                else
                {
                    int i;
                    List<Event> SelectEvent = BLLEvent.SelectEvent(newEvent.Id);
                    newEvent = SelectEvent[0];
                    for (i = 0; i < Sprekernaam.Count; i++)
                    {
                        Spreker newSpreker = new Spreker();
                        newSpreker.naam = Sprekernaam[i];
                        newSpreker.begintijd = Sprekerbegintijd[i];
                        newSpreker.eindtijd = Sprekereindtijd[i];
                        if (newSpreker.naam == "")
                        {

                        }
                        else
                        {
                            newSpreker.event_id = newEvent.Id;
                            BLLSpreker.insert(newSpreker);
                        }
                    }


                }
                Session.Add("gebruikersid", gebruikerid);
                Response.Redirect("~/Home.aspx");
            }
        }
        else
        {


            lblFeedbackNaam.Text = "";
            Boolean toegestaan = true;


            IList<User> userlijst = BLLUser.selectgebruiker(gebruikerid);
            User user = userlijst[0];
            gebruikerid = user.Id;
            Event newEvent = new Event();
            List<Event> LijstEvents = BLLEvent.SelectAllEvents();

            foreach (Event row in LijstEvents)
            {

                if (clDatum.SelectedDate < DateTime.Now)
                {
                    lblFeedbackDatum.Text = "Datum ligt in het verleden";
                    toegestaan = false;
                }

            }
            if (toegestaan == true)
            {
                eventid = (int)(Session["eventid"]);
                lblFeedbackDatum.Text = "";
                newEvent.Id = eventid;
                newEvent.naam = txtTitel.Text;
                newEvent.informatie = txtInformatie.Text;
                newEvent.datum = clDatum.SelectedDate;

                BLLEvent.update(newEvent);

                Session.Add("gebruikersid", gebruikerid);
                Response.Redirect("~/Home.aspx");

            }
        }
    }


}
    



       
            
        
    
   
