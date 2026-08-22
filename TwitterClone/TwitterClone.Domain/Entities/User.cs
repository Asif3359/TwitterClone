namespace TwitterClone.Domain.Entities;

public class User : BaseEntity , IFollowable, INotifiable
{
    public string FirstName { get;  set; }
    public string LastName { get;  set; }
    public string Email { get;  set; }
    public string PhoneNumber { get;  set; }
    public string? ProfileImageUrl { get;  set; }
    public string? PasswordHash { get;  set; }
    public bool IsVerified { get;  set; }

    private List<Guid> _followers = new List<Guid>();
    private List<Guid> _inComingNotifications = new List<Guid>();
    
    
    public User():base(Guid.NewGuid())
    {
    }
    
    public override string DescribeRecord()
    {
        var baseRecord = base.DescribeRecord();
        return $"{baseRecord}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, PhoneNumber: {PhoneNumber}, ProfileImageUrl: {ProfileImageUrl}, isVerified: {IsVerified}";
    }

    public void Follow(Guid userId)
    {
        if(!_followers.Contains(userId))
        {
            _followers.Add(userId);
        }
    }

    public void Unfollow(Guid userId)
    {
        if(_followers.Contains(userId))
        {
            _followers.Remove(userId);
        }
    }

    public List<Guid> GetFollowers()
    {
        return _followers;
    }

    public void AddNotification(Guid notificationId)
    {
        if(!_inComingNotifications.Contains(notificationId))
        {
            _inComingNotifications.Add(notificationId);
        }
    }
    
    public List<Guid> GetInComingNotifications()
    {
        return _inComingNotifications;
    }
} 