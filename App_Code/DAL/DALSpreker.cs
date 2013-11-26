using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALSpreker
/// </summary>
public class DALSpreker
{
    private CreativityEventDataContext dc = new CreativityEventDataContext();

    public void insert(Spreker sp_ev)
    {

        dc.Sprekers.InsertOnSubmit(sp_ev);
        dc.SubmitChanges();
    }
    public void delete(int e_int)
    {
        try
        {
           
            dc.Sprekers.DeleteAllOnSubmit(from e in dc.Sprekers
                                  where e.event_id== e_int
                                  select e);

            dc.SubmitChanges();
        }
        catch (InvalidOperationException e)
        {

            Console.Write(e);

        }
    }

     public List<Spreker> selectAll(int event_id)
    {
        var query = (from u in dc.Sprekers where u.event_id == event_id select u).ToList();
        return query;
    }
}