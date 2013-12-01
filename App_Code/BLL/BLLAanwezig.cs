using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLAanwezig
/// </summary>
public class BLLAanwezig
{
    DALAanwezig DALAanwezig = new DALAanwezig();

    public void insert(Aanwezig p_eve)
    {
        DALAanwezig.insert(p_eve);
    }

    public List<int> SelectEvent(int id)
    {
        return DALAanwezig.SelectEvent(id);
    }

    public List<Aanwezig> SelectAlleAanwezige(int id)
    {
        return DALAanwezig.SelectAllAanwezige(id);
    }

    public void deleteEvent(int id)
    {
        DALAanwezig.deleteEvent(id);

    }
    public void deletePersoon(int id)
    {
        DALAanwezig.deletePersoon(id);

    }
}