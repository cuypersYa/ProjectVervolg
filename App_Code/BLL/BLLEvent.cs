using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLEvent
/// </summary>
public class BLLEvent
{
    DALEvent DALEvents = new DALEvent();

    public void insert(Event p_eve)
    {
        DALEvents.insert(p_eve);
    }

    public void aanwezig(int p_int)
    {
        DALEvents.aanwezig(p_int);
    }

    public void afwezig(int p_int)
    {
        DALEvents.afwezig(p_int);
    }

    public List<Event> SelectAllEvents()
    {
        return DALEvents.SelectAll();
    }

    public List<Event> SelectEvent(int p_id)
    {
        return DALEvents.SelectEvent(p_id);
    }

    public void delete(int id)
    {
        DALEvents.delete(id);

    }
}

