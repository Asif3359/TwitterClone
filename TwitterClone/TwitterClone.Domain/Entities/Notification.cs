namespace TwitterClone.Domain.Entities;

public class Notification
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid? SourceUserId { get; private set; }
    public string Type { get; private set; }
    public string Message { get; private set; }
    public bool IsRead { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Notification()
    {
    }

    public Notification(
        Guid userId,
        string type,
        string message,
        Guid? sourceUserId = null)
    {
        Id = Guid.NewGuid();

        UserId = userId;
        SourceUserId = sourceUserId;

        Type = type;
        Message = message;

        IsRead = false;
        CreatedAt = DateTime.UtcNow;
    }
}