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

    public List<Comment> selectAll(int comment_id)
    {
        var query = (from u in dc.Comments where u.Id == comment_id select u).ToList();
        return query;
    }
}