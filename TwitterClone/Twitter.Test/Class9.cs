using TwitterClone.Domain.Entities;

namespace Twitter.Test;

public class Class9:Utils
{
    public void Run()
    {
        // Cwl();
        // var user = new User();
        // user.Email = "asifahammed@gmal.com";
        // user.FirstName = "Asif";
        // user.LastName = "Ahammad";
        // user.PhoneNumber = "01789846204";
        // Console.WriteLine($"Email:{user.Email} \nName:{user.FirstName} {user.LastName},\nPhone:{user.PhoneNumber}\nID:{user.Id}");
        //
        // Cwl();
        // var systemNotification = new SystemNotification();
        // systemNotification.AddMessage("Please update your app");
        // Cwl(systemNotification.GetMessage());
        //
        // Cwl();
        // var friendRequestNotification = new FriendRequestNotification(user.Id);
        // friendRequestNotification.AddMessage("Friend Request Message from FriendRequest notification");
        // Cwl(friendRequestNotification.GetMessage());
        //
        // Cwl();
        // var commentNotification = new CommentNotification(user.Id);
        // commentNotification.AddMessage("Your picture is so good sir");
        // Cwl(commentNotification.GetMessage());
        //
        // Cwl();
        // var mentionNotification = new MentionNotification(user.Id);
        // Cwl(mentionNotification.GetMessage());
        //
        // Cwl();
        // var likeNotification = new LikeNotification(user.Id);
        // likeNotification.AddMessage("Liked");
        // Cwl(likeNotification.GetMessage());
        
        var notifications = new List<Notification>()
        {
            new LikeNotification(Guid.NewGuid()),
            new CommentNotification(Guid.NewGuid()),
            new FriendRequestNotification(Guid.NewGuid()),
            new MentionNotification(Guid.NewGuid()),
            new SystemNotification()
        };

        foreach (var notification in notifications)
        {
            Console.WriteLine(notification.GetMessage());
        }
        
    }
}