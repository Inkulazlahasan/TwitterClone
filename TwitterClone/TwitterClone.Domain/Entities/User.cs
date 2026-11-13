
namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity, IFollowable,INotifiable
    {
        public string FirstName { get; private set; } = string.Empty;
        public string? LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _incommingNotifications = new List<Guid>();

        public User(string firstname, string? lastname, string email) : base(Guid.NewGuid())
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
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

        public void AddNotification(Guid notificationId)
        {
            if(!_incommingNotifications.Contains(notificationId))
            {
                _incommingNotifications.Add(notificationId);
            }
        }

    }
}
