using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.User
{
    public class LoginUserDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
