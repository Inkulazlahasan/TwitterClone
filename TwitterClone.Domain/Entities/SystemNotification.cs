
namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public Guid SystemUserId { get; private set; }

        public Guid? TargetUserId { get; private set; }

        public SystemNotification(Guid systemUserId, Guid? targetUserId) : base(Guid.NewGuid(), "system_notification", $"System notification for user {targetUserId}", false)
        {
            this.SystemUserId = systemUserId;
            this.TargetUserId = targetUserId;
        }

        public void CreateSystemNotification(Guid systemUserId, Guid? targetUserId)
        {
            this.SystemUserId = systemUserId;
            this.TargetUserId = targetUserId;
        }   
    }
}
