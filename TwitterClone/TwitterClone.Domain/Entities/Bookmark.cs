
namespace TwitterClone.Domain.Entities
{
    public class Bookmark
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _created;
        private DateTime _updated;
        public Bookmark()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }
        public DateTime Created
        {
            get { return _created; }
            set { _created = value; }
        }
        public DateTime Updated
        {
            get { return _updated; }
            set { _updated = value; }
        }
    }
}
