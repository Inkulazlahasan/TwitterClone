using TwitterClone.Domain.Entities;

/*
Console.WriteLine("Task 1 completed.");

var like_notification = new LikeNotification(Guid.NewGuid());
Console.WriteLine(like_notification.GetMessage());

var comment_notification = new CommentNotification(Guid.NewGuid(), "This is a comment");
Console.WriteLine(comment_notification.GetMessage());

var friend_request_notification = new FriendRequestNotification(Guid.NewGuid(), Guid.NewGuid());
Console.WriteLine(friend_request_notification.GetMessage());

var mention_notification = new MentionNotification(Guid.NewGuid());
Console.WriteLine(mention_notification.GetMessage());
*/

// Upcasting with Foreach...this is the a common way to impliment polimorphism in C#.
// The ability of assigning a derived class object to a base class reference is called upcasting.
var notifications = new List<Notification>()
{
    new LikeNotification(Guid.NewGuid()),
    new CommentNotification(Guid.NewGuid(), "This is a comment"),
    new FriendRequestNotification(Guid.NewGuid(), Guid.NewGuid()),
    new MentionNotification(Guid.NewGuid())
};

foreach (var notification in notifications)
{
    Console.WriteLine(notification.GetMessage());
}

var tweet = new Tweet(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "This is a tweet");
tweet.AddContent(Guid.NewGuid(), "This is an updated tweet content");


// polymorphism implemented with interface...
ILikeable LikeableTweel = new Tweet(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), "This is a tweet");
Console.WriteLine(LikeableTweel.CanBeLiked());

// Slatic member can be accessed only by a class. Not by an instance of a class or Object of a class.
var maxContentLength = Tweet.MaxContentLength;