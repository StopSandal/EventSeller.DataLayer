using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.PlaceHall
{
    public class AddPlaceHallDto
    {
        [Required]
        public string HallName { get; set; }
        [Required]
        public long PlaceAddressID { get; set; }
    }
}
