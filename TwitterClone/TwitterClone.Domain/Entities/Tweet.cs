namespace TwitterClone.Domain.Entities;

public class Tweet
{
    public Guid Id { get; private set; }
    public Guid AuthorId { get; private set; }

    public string Content { get; private set; }

    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    public bool IsDeleted { get; private set; }

    private Tweet()
    {
    }

    public Tweet(Guid authorId, string content)
    {
        Id = Guid.NewGuid();

        AuthorId = authorId;
        Content = content;

        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }
}