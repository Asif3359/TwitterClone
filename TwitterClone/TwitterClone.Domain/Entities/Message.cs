namespace TwitterClone.Domain.Entities;

public class Message
{
    public Guid Id { get; private set; }

    public Guid SenderId { get; private set; }
    public Guid ReceiverId { get; private set; }

    public string Content { get; private set; }

    public DateTime SentAt { get; private set; }

    public bool IsRead { get; private set; }

    private Message()
    {
    }

    public Message(
        Guid senderId,
        Guid receiverId,
        string content)
    {
        Id = Guid.NewGuid();

        SenderId = senderId;
        ReceiverId = receiverId;
        Content = content;

        SentAt = DateTime.UtcNow;
        IsRead = false;
    }
}