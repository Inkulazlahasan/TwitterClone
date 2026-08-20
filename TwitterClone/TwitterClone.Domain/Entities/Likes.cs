
namespace TwitterClone.Domain.Entities
{
    internal class Likes : BaseEntity
    {
        public Guid TweeId { get; private set; }

        public Likes(Guid tweeId) : base(Guid.NewGuid())
        {
            this.TweeId = tweeId;
        }

        public void CreateLike(Guid tweeId)
        {
            this.TweeId = tweeId;
        }

    }
}
