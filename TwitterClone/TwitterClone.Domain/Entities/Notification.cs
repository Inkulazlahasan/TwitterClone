
namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
        public Guid UserId { get; private set; }
        public string NotificationType { get; private set; }
        public string? Message { get; private set; } 
        public bool IsRead { get; private set; } = false;
        
        
        public Notification(Guid userId, string notificationType, string? message, bool isRead) : base(Guid.NewGuid())
        {
            this.UserId = userId;
            this.NotificationType = notificationType;
            this.Message = message;
            this.IsRead = isRead;
        }

        public abstract string GetMessage();
        
    }
}
