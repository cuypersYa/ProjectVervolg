using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DALComment
/// </summary>
public class DALComment
{
    private CreativityEventDataContext dc = new CreativityEventDataContext();

    public void insert(Comment c_ev)
    {
        
            dc.Comments.InsertOnSubmit(c_ev);
            dc.SubmitChanges();
        
        
    }

    public List<Comment> selectAll(int e_id)
    {
        var query = (from u in dc.Comments where u.eventId == e_id select u).ToList();
        return query;
    }

    public void deleteComments(int e_ev)
    {
        var eventVerwijder = (from e in dc.Comments
                              where e.eventId == e_ev
                              select e).ToList();

        foreach (Comment row in eventVerwijder)
        {
            dc.Comments.DeleteOnSubmit(row);
            dc.SubmitChanges();
        }
      
    }
}