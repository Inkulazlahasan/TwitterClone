
namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private string _title;
        private string _content;
        private string _description;
        private DateTime _created;
        private DateTime _updated;

        public Retweet()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
