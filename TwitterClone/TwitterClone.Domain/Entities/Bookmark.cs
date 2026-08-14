namespace TwitterClone.Domain.Entities;

public class Bookmark
{
    public Guid Id { get; private set; }
    public Guid UserId { get; private set; }
    public Guid TweetId { get; private set; }
    public DateTime BookmarkedAt { get; private set; }
}