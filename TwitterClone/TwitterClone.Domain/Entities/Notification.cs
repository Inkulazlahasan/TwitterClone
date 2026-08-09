
namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private Guid _userId;
        private string _message;
        private bool _isRead;
        private DateTime _created;
        private DateTime _updated;
        public Notification()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
            _isRead = false;
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
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
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
