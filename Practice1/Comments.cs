public class Comments 
{
    public string _userName;
    public string _comments;

    public Comments()
    {

    }
    
    public string GetComments()
    {
        return $"({_userName}) {_comments}.";
    }

    public int CommentCount()
    {
        return _comments.Count();
    }
    
}