namespace TwitterClone.Domain.Entities;

public class Tweet:BaseEntity,ILikeable
{
    public Guid UserId { get; set; }
    public string Content { get;  set; }
    private int _likeCount;

    public int LikeCount => _likeCount;

    public Tweet(string content):base(Guid.NewGuid())
    {
        Content = content;
    }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
    }

    public bool CanBeLiked()
    {
        return !string.IsNullOrWhiteSpace(Content);
    }
    
    public void Like()
    {
        if (!CanBeLiked())
            throw new Exception("Can't like");
        _likeCount++;
    }
}