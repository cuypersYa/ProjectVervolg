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

    //INSERT
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

        // Execute the query, and change the column values
        // you want to change.
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

    public List<User> selectGebruiker(string g)
    {
        var gebruiker = from u in dc.Users where u.gebruikersnaam == g
                     select u;
        return gebruiker.ToList();
    }

    public List<User> selectAanwezigen(int id){
        var gebruikers = from u in dc.Users where u.Id == id select u;
        return gebruikers.ToList();
    }
}