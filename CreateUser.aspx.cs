using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateUser : System.Web.UI.Page
{
    
    protected void btnSignup_Click(object sender, EventArgs e)
    {
        User newUser = new User();
        BLLUser BLLAddUsers = new BLLUser();
        if (Page.IsValid)
        {
            var voornaam = txtVoornaam.Text;
            var naam = txtNaam.Text;
            var email = txtEmail.Text;
            var wachtwoord = txtWachtwoord.Text;
            var gebruikersnaam = txtGebruikersnaam.Text;
            Boolean toegestaan = false;

          
            newUser.wachtwoord = wachtwoord;
            newUser.gebruikersnaam = gebruikersnaam;
            toegestaan = BLLAddUsers.Checker(newUser);
            if (toegestaan == true)
            {
                lblinorde.Text = "gebruiker bestaat al";
            }
            else
            {
                newUser.email = email;
                newUser.voornaam = voornaam;
                newUser.naam = naam;
                newUser.rol = "visitor";
                BLLAddUsers.insert(newUser);
                Response.Redirect("~/Signin.aspx");
            }
            
           
        
        }
       

      
    }
}