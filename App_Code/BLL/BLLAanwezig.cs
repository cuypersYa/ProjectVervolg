using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLAanwezig
/// </summary>
public class BLLAanwezig
{
    DALAanwezig DalAddAanwezig = new DALAanwezig();

    public void insert(Aanwezig p_eve)
    {
        DalAddAanwezig.insert(p_eve);
    }

    public List<int> SelectEvent(int id)
    {
        return DalAddAanwezig.SelectEvent(id);
    }

    public List<Aanwezig> SelectAlleAanwezige(int id)
    {
        return DalAddAanwezig.SelectAllAanwezige(id);
    }

    public void delete(int id)
    {
        DalAddAanwezig.delete(id);

    }
}