
namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverId;
        private string _content;
        private DateTime _created;
        private DateTime _updated;
        public Message()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
        }
        public Guid Id
        {
            get { return _id; }
        }
        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public Guid ReceiverId
        {
            get { return _receiverId; }
            set { _receiverId = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
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
