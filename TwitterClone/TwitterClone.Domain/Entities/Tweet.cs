
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikeable
    {
        public Guid TweetByUserId { get; private set; }
        public Guid TweetId { get; private set; }
        public Guid AuthorId { get; private set; }
        public string? Content { get; private set; } = string.Empty;
        public static int MaxContentLength = 200;

        public Tweet(Guid tweetByUserId, Guid tweetId, Guid authorId, string? content) : base(Guid.NewGuid())
        {
            this.TweetByUserId = tweetByUserId;
            this.TweetId = tweetId;
            this.AuthorId = authorId;
            Content = content;
        }

        public void AddContent(Guid userId, string content)
        {
            this.TweetByUserId = userId;
            this.Content = content;
        }

        public bool CanBeLiked()
        {
            return true; 
        }
    }

}
