
namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
        public Guid TweetId { get; private set; }
        public Bookmark(Guid tweetId) : base(Guid.NewGuid())
        {
            this.TweetId = tweetId;
        }
        
    }
}
