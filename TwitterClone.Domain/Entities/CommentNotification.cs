
namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public Guid CommentByUser { get; set; }

        public string? Comment { get; set; }

        public CommentNotification(Guid commentByUser, string? comment) : base(Guid.NewGuid(), "comment", $"User {commentByUser} commented on your tweet: {comment}", false)
        {
            this.CommentByUser = commentByUser;
            this.Comment = comment;
        }

        public void CreateCommentNotification(Guid commentByUser, string? comment)
        {
            this.CommentByUser = commentByUser;
            this.Comment = comment;
        }

        public override string GetMessage()
        {
            return $"User with ID {this.CommentByUser} comment on your post.";
        }
    }
}
