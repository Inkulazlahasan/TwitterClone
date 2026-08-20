
namespace TwitterClone.Domain.Entities
{
    public class Follow : BaseEntity
    {
        public Guid FollowerId { get; private set; }
        public Guid FollowedId { get; private set; }
        public Follow(Guid followerId, Guid followedId) : base(Guid.NewGuid())
        {
            this.FollowerId = followerId;
            this.FollowedId = followedId;
        }
        
    }
}
