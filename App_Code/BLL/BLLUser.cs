using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLAddUser
/// </summary>
public class BLLUser
{
    DALUser DALUsers = new DALUser();

    public void insert(User p_us)
    {
        DALUsers.insert(p_us);
    }

    public Boolean Checker(User gebruiker)
    {
        Boolean Toegelaten = false;
        Toegelaten = DALUsers.Check(gebruiker);
        return Toegelaten;
    }

    public List<User> selectgebruiker(int g_id)
    {
       
        return DALUsers.selectGebruiker(g_id);
    }

    public List<int> selectgebruikerid(string gebruikersnaam)
    {
        return DALUsers.selectIdGebruiker(gebruikersnaam);
    }

    public List<User> selectGeenAdmin()
    {
        return DALUsers.selectGeenAdmin();
    }

    public void updateUser(string gebruikersnaam)
    {
        DALUsers.updateUser(gebruikersnaam);
    }

   
}