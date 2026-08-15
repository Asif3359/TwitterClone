namespace TwitterClone.Domain.Entities;

public class Message:BaseEntity
{
    public Guid SenderId { get;  set; }
    public Guid ReceiverId { get;  set; }
    public string Content { get;  set; }
    public DateTime SentAt { get;  set; }
    public bool IsRead { get;  set; }

    public Message() : base(Guid.NewGuid())
    {
        SentAt = DateTime.UtcNow;
    }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, SenderId: {SenderId}, ReceiverId: {ReceiverId}, Content: {Content}, SentAt: {SentAt}, IsRead: {IsRead}";
    }
    
}