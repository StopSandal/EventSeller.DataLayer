using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.PlaceAddress
{
    public class AddPlaceAddressDto
    {
        [Required]
        public string PlaceName { get; set; }
        public string Address { get; set; }
    }
}
