using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALAanwezig
/// </summary>
public class DALAanwezig
{
    private CreativityEventDataContext dc = new CreativityEventDataContext();

    public void insert(Aanwezig p_ev)
    {

        dc.Aanwezigs.InsertOnSubmit(p_ev);
        dc.SubmitChanges();
    }

    public List<int> SelectEvent(int id)
    {
        var query = (from u in dc.Aanwezigs where u.EventId == id
                     select u.PersoonId).ToList();
        return query;

    }

    public List<Aanwezig> SelectAllAanwezige(int id)
    {
        var query = (from u in dc.Aanwezigs
                     where u.EventId == id
                     select u).ToList();
        return query;
    }
    public void deleteEvent(int e_int)
    {
        try
        {
        dc.Aanwezigs.DeleteAllOnSubmit(from e in dc.Aanwezigs
                                  where e.EventId == e_int
                                  select e);

        dc.SubmitChanges();
        }  
        catch (InvalidOperationException e)
        {

            Console.Write(e);

        }

        }
       

  

    public void deletePersoon(int p_int){
        dc.Aanwezigs.DeleteAllOnSubmit(from e in dc.Aanwezigs
                                  where e.PersoonId == p_int
                                  select e);

        dc.SubmitChanges();
}
}
