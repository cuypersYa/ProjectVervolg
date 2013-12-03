using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLComment
/// </summary>
public class BLLComment
{
    DALComment DALComments = new DALComment();

    public void insert(Comment c_ev)
    {
        DALComments.insert(c_ev);
    }

    public List<Comment> selectAll(int e_ev)
    {
        return DALComments.selectAll(e_ev);
    }
}