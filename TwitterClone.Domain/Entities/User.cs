
namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; private set; } = string.Empty;
        public string? LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public User(string firstname, string? lastname, string email) : base(Guid.NewGuid())
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
        }
    
       
        

       
    }
}
