namespace TwitterClone.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }
    public string? ProfileImageUrl { get; private set; }
    public string? PasswordHash { get; private set; }
    public bool IsVerified { get; private set; }
    public DateTime JoinedAt { get; private set; }

    private User()
    {
    }

    public User(
        string firstName,
        string lastName,
        string email,
        string phoneNumber,
        string? profileImageUrl = null,
        string? passwordHash = null)
    {
        Id = Guid.NewGuid();

        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        ProfileImageUrl = profileImageUrl;
        PasswordHash = passwordHash;

        IsVerified = false;
        JoinedAt = DateTime.UtcNow;
    }
    
    public void Verify()
    {
        IsVerified = true;
    }
}