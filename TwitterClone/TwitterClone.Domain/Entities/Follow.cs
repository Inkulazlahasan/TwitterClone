
namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followeeId;
        private DateTime _created;
        private DateTime _updated;
        public Follow()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid FollowerId
        {
            get { return _followerId; }
            set { _followerId = value; }
        }
        public Guid FolloweeId
        {
            get { return _followeeId; }
            set { _followeeId = value; }
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
