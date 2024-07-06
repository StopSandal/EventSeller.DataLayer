using Microsoft.AspNetCore.Identity;

namespace EventSeller.DataLayer.Entities
{
    public class User : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
