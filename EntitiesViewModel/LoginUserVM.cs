using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesViewModel
{
    public class LoginUserVM
    {
        [Required]
        [DisplayName("User name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Password")]
        public string Password { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
    }
}
