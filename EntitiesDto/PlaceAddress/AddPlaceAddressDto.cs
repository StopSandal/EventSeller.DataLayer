using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.PlaceAddress
{
    public class AddPlaceAddressDto
    {
        [Required]
        public string PlaceName { get; set; }
        public string Address { get; set; }
    }
}
