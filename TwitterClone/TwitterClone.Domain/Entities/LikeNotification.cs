
namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public Guid LikedByUserId { get; private set; }

        public LikeNotification(Guid likedByUserId) : base(Guid.NewGuid(), "like", $"User {likedByUserId} liked your tweet", false)
        {
            this.LikedByUserId = likedByUserId;
        }

        public void CreateLikeNotification(Guid likedByUserId)
        {
            this.LikedByUserId = likedByUserId;
        }

        public override string DescribeRecord()
        {
            var BaseRecord = base.DescribeRecord();
            return $"{BaseRecord} - Notification Id: {Id}, CreatedAt: {CreatedAt}, UpdateAt: {UpdateAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedBy}";
        }

        public override string GetMessage()
        {
            return $"User with ID {this.LikedByUserId} liked your post.";
        }
    }
}
