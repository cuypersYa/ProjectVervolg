using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALEvent
/// </summary>
public class DALEvent
{
    private CreativityEventDataContext dc = new CreativityEventDataContext();

    public void insert(Event p_ev)
    {

        dc.Events.InsertOnSubmit(p_ev);
        dc.SubmitChanges();
    }

    public void aanwezig(int p_int)
    {
        var record_to_update = (from e in dc.Events
                                where e.Id == p_int
                                select e).Single();
        record_to_update.visitors++;
        dc.SubmitChanges();
    }

    public void afwezig(int p_int)
    {
        var record_to_update = (from e in dc.Events
                                where e.Id == p_int
                                select e).Single();
        record_to_update.visitors--;
        dc.SubmitChanges();
    }



    public List<Event> SelectAll()
    {
        var query = (from u in dc.Events
                     select u).ToList();
        return query;

    }

    public List<Event> SelectEvent(int p_id)
    {
        var record_to_update = (from e in dc.Events
                                where e.Id == p_id
                                select e).ToList();
        return record_to_update;
    }
    
    public void delete(int e_int)
    {
        BLLAanwezig BLLAanwezigen = new BLLAanwezig();
        BLLSpreker BLLSpreker = new BLLSpreker();
        var eventVerwijder = (from e in dc.Events
                   where e.Id == e_int
                   select e).Single();
        BLLSpreker.delete(e_int);
        BLLAanwezigen.deleteEvent(e_int);
        dc.Events.DeleteOnSubmit(eventVerwijder);
        
        dc.SubmitChanges();

    }

    public void update(Event u_event)
    {
        var recordToUpdate = (from e in dc.Events
                              where e.Id == u_event.Id
                              select e).Single();

        recordToUpdate.naam = u_event.naam;
        recordToUpdate.informatie = u_event.informatie;
        recordToUpdate.datum = u_event.datum;
        dc.SubmitChanges();
    }
}