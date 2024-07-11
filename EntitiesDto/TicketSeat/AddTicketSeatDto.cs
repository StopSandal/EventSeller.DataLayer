using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.TicketSeat
{
    public class AddTicketSeatDto
    {
        [Required]
        public string PlaceName { get; set; }
        [Required]
        public string PlaceType { get; set; }
        public int? PlaceRow { get; set; }
        public int? PlaceSeat { get; set; }
        [Required]
        public long HallSectorID { get; set; }
    }
}
