namespace TwitterClone.Domain.Entities;

public class Tweet
{
    public Guid Id { get; private set; }       
    public Guid AuthorId { get; private set; } 
    public string? Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public Boolean IsDeleted { get; set; } = false;
}