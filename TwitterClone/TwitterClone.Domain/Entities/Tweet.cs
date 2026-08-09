
namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _authorId;
        private string _content;
        private DateTime _created;
        private DateTime _updated;

        public Tweet()
        {
            _id = Guid.NewGuid();
            _created = DateTime.UtcNow;
            _updated = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        

        public Guid AuthorId
        {
            get { return _authorId; }
            set { _authorId = value; }
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
