using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class CreateEvent : System.Web.UI.Page
{
    String gebruiker = "";
    List<string> Sprekernaam = new List<string>();
    List<string> Sprekertijd = new List<string>();
   
    
    protected void Page_Load(object sender, EventArgs e)
    {

        gebruiker = (string)(Session["gebruikersnaam"]);
        
    }
 
    public void txtSpreker1_TextChanged(object sender, EventArgs e)
    {
        
        int spreker;
      
        if (txtSpreker2.Visible == false)
        { 
            Session.Add("sprekergetal", 1);
            Sprekernaam.Add(txtSpreker1.Text);
            Sprekertijd.Add(txtTijd1.Text);
            Session.Add("lijstsprekers", Sprekernaam);
            Session.Add("lijsttijd", Sprekertijd);
        }
        Sprekernaam = (List<string>)Session["lijstsprekers"];
        Sprekertijd = (List<string>)Session["lijsttijd"];
        spreker = (int)Session["sprekergetal"];
        spreker++;
        switch (spreker)
        {

            case 2: txtSpreker2.Visible = true;
                txtTijd2.Visible = true;
              
                Session.Add("sprekergetal", 2);
                break;
            case 3: txtSpreker3.Visible = true;
                txtTijd3.Visible = true;
                Sprekernaam.Add(txtSpreker2.Text);
                Sprekertijd.Add(txtTijd2.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 3);
                break;
            case 4: txtSpreker4.Visible = true;
                txtTijd4.Visible = true;
                Sprekernaam.Add(txtSpreker3.Text);
                Sprekertijd.Add(txtTijd3.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                   Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 4);
                break;
            case 5: txtSpreker5.Visible = true;
                txtTijd5.Visible = true;
                Sprekernaam.Add(txtSpreker4.Text);
                Sprekertijd.Add(txtTijd4.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 5);
                break;
            case 6: txtSpreker6.Visible = true;
                txtTijd6.Visible = true;
                Sprekernaam.Add(txtSpreker5.Text);
                Sprekertijd.Add(txtTijd5.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 6);
                break;
            case 7: txtSpreker7.Visible = true;
                txtTijd7.Visible = true;
                Sprekernaam.Add(txtSpreker6.Text);
                Sprekertijd.Add(txtTijd6.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 7);
                break;
            case 8: txtSpreker8.Visible = true;
                txtTijd8.Visible = true;
                Sprekernaam.Add(txtSpreker7.Text);
                Sprekertijd.Add(txtTijd7.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 8);
                break;
            case 9: txtSpreker9.Visible = true;
                txtTijd9.Visible = true;
                Sprekernaam.Add(txtSpreker8.Text);
                Sprekertijd.Add(txtTijd8.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 9);
                break;
            case 10: txtSpreker10.Visible = true;
                txtTijd10.Visible = true;
                Sprekernaam.Add(txtSpreker9.Text);
                Sprekertijd.Add(txtTijd9.Text);
                Session.Add("lijstsprekers", Sprekernaam);
                Session.Add("lijsttijd", Sprekertijd);
                Session.Add("sprekergetal", 10);
                break;
        }
     
    }
    protected void btnMaak_Click(object sender, EventArgs e)
    {
        int ideigenaar = 0;
        Sprekernaam = (List<string>)Session["lijstsprekers"];
        Sprekertijd = (List<string>)Session["lijsttijd"];

        BLLUser inladen = new BLLUser();
        IList<User> lijst = inladen.selectgebruiker(gebruiker);
        User eigenaar = lijst[0];
        ideigenaar = eigenaar.Id;


        
        BLLEvent maakEvent = new BLLEvent();
        Event newEvent = new Event();
        Boolean toegestaanNaam = new Boolean();
        List<Event> LijstEvents = maakEvent.SelectAllEvents();

        foreach (Event row in LijstEvents){
            toegestaanNaam = true;
            if (txtTitel.Text == row.naam)
            {
                lblFeedbackNaam.Text = "Naam van het evenement bestaat al";
                toegestaanNaam = false;
            }
        }
        if (toegestaanNaam == true)
        {
            lblFeedbackNaam.Text = "";
            if (clDatum.SelectedDate < DateTime.Now)
            {
                lblFeedbackDatum.Text = "Datum ligt in het verleden";
            }
            else
            {
                lblFeedbackDatum.Text = "";
                newEvent.naam = txtTitel.Text;
                newEvent.informatie = txtInformatie.Text;
                newEvent.datum = clDatum.SelectedDate;
                newEvent.eigenaar = ideigenaar;
                newEvent.visitors = 0;
                maakEvent.insert(newEvent);
                BLLSpreker maakSpreker = new BLLSpreker();

                int i;
                List<Event> SelectEvent = maakEvent.SelectEvent(newEvent.Id);
                newEvent = SelectEvent[0];
                for (i = 0; i < Sprekernaam.Count; i++)
                {
                    Spreker newSpreker = new Spreker();
                    newSpreker.naam = Sprekernaam[i];
                    newSpreker.tijd = Sprekertijd[i];
                    if (newSpreker.naam == "")
                    {

                    }
                    else
                    {

                        newSpreker.event_id = newEvent.Id;
                        maakSpreker.insert(newSpreker);
                    }
                }


                Session.Add("gebruikersnaam", gebruiker);
                Response.Redirect("~/Home.aspx");
            }
        }
    }
    
   
}