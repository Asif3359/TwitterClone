namespace TwitterClone.Domain.Entities;

public class User : BaseEntity
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public string Email { get;  set; }
    public string PhoneNumber { get;  set; }
    public string? ProfileImageUrl { get;  set; }
    public string? PasswordHash { get;  set; }
    public bool IsVerified { get;  set; }
    
    public User():base(Guid.NewGuid())
    {
    }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, PhoneNumber: {PhoneNumber}, ProfileImageUrl: {ProfileImageUrl}, isVerified: {IsVerified}";
    }
} 