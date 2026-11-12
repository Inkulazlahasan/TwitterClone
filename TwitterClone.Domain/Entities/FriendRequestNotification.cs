
namespace TwitterClone.Domain.Entities
{
    public class FriendRequestNotification : Notification
    {
        public Guid RequestByUser { get; private set; }
        public Guid? RequestToUser { get; private set; }

        public FriendRequestNotification(Guid requestByUser, Guid? requestToUser) : base(Guid.NewGuid(), "friend_request", $"User {requestByUser} sent you a friend request", false)
        {
            this.RequestByUser = requestByUser;
            this.RequestToUser = requestToUser;
        }

        public void CreateFriendRequestNotification(Guid requestByUser, Guid? requestToUser)
        {
            this.RequestByUser = requestByUser;
            this.RequestToUser = requestToUser;
        }
    }
}
