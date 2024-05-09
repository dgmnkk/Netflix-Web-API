using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.Entities
{
    public enum ClientType { Node, Regular, Premium }
    public class User : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public ClientType ClientType { get; set; }
        public ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}
