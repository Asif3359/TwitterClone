namespace TwitterClone.Domain.Entities;

public class Message
{
    public Guid Id { get; private set; }
    public Guid SenderId { get; private set; }
    public Guid ReceiverId { get; private set; }
    public string Content { get; set; }
    public DateTime SentAt { get; private set; }
    public bool IsRead { get; set; }
}