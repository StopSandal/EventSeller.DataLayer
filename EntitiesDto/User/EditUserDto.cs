using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto.User
{
    public class EditUserDto
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }
    }
}
