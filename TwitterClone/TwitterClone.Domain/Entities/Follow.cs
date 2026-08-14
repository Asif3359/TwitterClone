namespace TwitterClone.Domain.Entities;

public class Follow
{
    public Guid Id { get; private set; }
    public Guid FollowerId { get; private set; }
    public Guid FolloweeId { get; private set; }
    public DateTime CreatedAt { get; private set; }
}