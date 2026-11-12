
namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {
        
        public Guid SenderId { get; private set; }
        public Guid ReceiverId { get; private set; }
        public string? Content { get; private set; } = string.Empty;
        public Message(Guid senderId, Guid receiverId, string? content) : base(Guid.NewGuid())
        {
            this.SenderId = senderId;
            this.ReceiverId = receiverId;
            this.Content = content;
        }
        
    }
}
