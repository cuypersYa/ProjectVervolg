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

    public List<int> SelectAllAanwezige(int id)
    {
        return DalAddAanwezig.SelectEvent(id);
    }

    public void delete(int id)
    {
        DalAddAanwezig.delete(id);

    }
}