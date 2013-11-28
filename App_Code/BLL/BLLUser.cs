using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLAddUser
/// </summary>
public class BLLUser
{
    DALUser DalAddUsers = new DALUser();

    public void insert(User p_us)
    {
        DalAddUsers.insert(p_us);
    }

    public Boolean Checker(User gebruiker)
    {
        Boolean Toegelaten = false;
        Toegelaten = DalAddUsers.Check(gebruiker);
        return Toegelaten;
    }

    public List<User> selectgebruiker(string g)
    {
       
        return DalAddUsers.selectGebruiker(g);
    }

    public List<User> selectAanwezigen(int id)
    {
        return DalAddUsers.selectAanwezigen(id);
    }
}