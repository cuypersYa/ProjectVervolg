using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALAddUser
/// </summary>
public class DALUser
{
    private CreativityEventDataContext dc = new CreativityEventDataContext();

    
    public void insert(User p_us)
    {
        dc.Users.InsertOnSubmit(p_us);
        dc.SubmitChanges();
        
    }

    public Boolean Check(User gebruiker)
    {
        Boolean Toegelaten = false;
        var query =
            from t in dc.Users
            where t.gebruikersnaam == gebruiker.gebruikersnaam && t.wachtwoord == gebruiker.wachtwoord
            select t;

        List<User> x = query.ToList();

        if (x.Count > 0)
        {
            foreach (User gebruikers in query)
            {
                Toegelaten = true;
            }
        }
        else
        {
            Toegelaten = false;
           
        }
        // Submit the changes to the database.

        return Toegelaten;
    }

    public List<User> selectGebruiker(int g_id)
    {
        var gebruiker = from u in dc.Users where u.Id == g_id
                     select u;
        return gebruiker.ToList();
    }

    public List<int> selectIdGebruiker(string gebruikersnaam)
    {
        var gebruikerid = from u in dc.Users where u.gebruikersnaam == gebruikersnaam select u.Id;
        return gebruikerid.ToList();
    }
}