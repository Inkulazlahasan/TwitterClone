
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        public Guid TweetByUserId { get; private set; }
        public Guid TweetId { get; private set; }
        public Guid AuthorId { get; private set; }
        public string? Content { get; private set; } = string.Empty;

        public Tweet(Guid tweetByUserId, Guid tweetId, Guid authorId, string? content) : base(Guid.NewGuid())
        {
            this.TweetByUserId = tweetByUserId;
            this.TweetId = tweetId;
            this.AuthorId = authorId;
            Content = content;
        }
    }
}
