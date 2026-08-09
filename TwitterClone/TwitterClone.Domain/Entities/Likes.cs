
namespace TwitterClone.Domain.Entities
{
    internal class Likes
    {
        private Guid _userid;
        private Guid _tweetid;
        private DateTime _likedAt;

        public Guid UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }
        public Guid TweetId
        {
            get { return _tweetid; }
            set { _tweetid = value; }
        }

        public DateTime LikedAt
        {
            get { return _likedAt; }
            set { _likedAt = value; }
        }
    }
}
