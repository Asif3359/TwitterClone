namespace TwitterClone.Domain.Entities;

public class Tweet:BaseEntity
{
    public Guid UserId { get; set; }
    public string Content { get;  set; }

    public Tweet(string content):base(Guid.NewGuid())
    {
        Content = content;
    }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
    }
}