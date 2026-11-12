
namespace TwitterClone.Domain.Entities
{
    public class Retweet: BaseEntity
    {
        public Guid OriginalTweetId { get; private set; }
        public string Title { get; private set; } = string.Empty;
        public string Content { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty; 
        public Retweet(Guid originalTweetId, string title, string content, string description) : base(Guid.NewGuid())
        {
            this.OriginalTweetId = originalTweetId;
            this.Title = title;
            this.Content = content;
            this.Description = description;
        } 
    }
}
