using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLSpreker
/// </summary>
public class BLLSpreker
{
    DALSpreker DalSprekers = new DALSpreker();

    public void insert(Spreker p_eve)
    {
        DalSprekers.insert(p_eve);
    }

    public void delete(int id)
    {
        DalSprekers.delete(id);

    }

    public List<Spreker> selectAll(int event_id)
    {
        return DalSprekers.selectAll(event_id);
    }
}