
namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdateAt { get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }
    
        public BaseEntity(Guid Id)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }

        public virtual string DescribeRecord()
        {
            return $"Base entity -> Id: {Id}, CreatedAt: {CreatedAt}, UpdateAt: {UpdateAt}, CreatedBy: {CreatedBy}, ModifiedBy: {ModifiedBy}";
        }
    }

}
