using TwitterClone.Domain.Entities;

namespace Twitter.Test;

public class Class10:Utils
{
    public void Run()
    {
        // 1
        Tweet tweet = new Tweet("Assalamualikum everyone");
        tweet.Like();
        tweet.Like();
        tweet.Like();
        tweet.Like();
        Cwl($"Likes: {tweet.LikeCount}");
        
        // 2
        User user = new User();
        User user3 = new User();
        User user2 = new User();
        User user4 = new User();
       
        user.Follow(user2.Id);
        user.Follow(user3.Id);
        user.Unfollow(user4.Id);
        user4.Follow(user3.Id);

        foreach (var VARIABLE in user.GetFollowers())
        {
            Cwl($"Follower: {VARIABLE}");
        }
        Cwl($"Total follower: {user.GetFollowers().Count}");
        
        
        // 3
        Notification notification = new LikeNotification(user2.Id);
        Notification notification2 = new LikeNotification(user3.Id);
        
        user.AddNotification(notification.Id);
        user.AddNotification(notification2.Id);
        
        Cwl($"Notification :{user.GetInComingNotifications()[0]}");
        Cwl($"Notification :{user.GetInComingNotifications()[1]}");
        Cwl($"Notification Total:{user.GetInComingNotifications().Count}");
        
    }
}