using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.User
{
    public class AddUserDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
