using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLSpreker
/// </summary>
public class BLLSpreker
{
    DALSpreker DALSprekers = new DALSpreker();

    public void insert(Spreker p_eve)
    {
        DALSprekers.insert(p_eve);
    }

    public void delete(int id)
    {
        DALSprekers.delete(id);

    }

    public List<Spreker> selectAll(int event_id)
    {
        return DALSprekers.selectAll(event_id);
    }
}