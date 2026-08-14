namespace TwitterClone.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? PasswordHash { get; set; }
    public Boolean IsVerified { get; set; } = false;
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
}