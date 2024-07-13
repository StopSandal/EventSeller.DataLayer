using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.EventType
{
    public class AddEventTypeDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int MinutesForMoneyReturn { get; set; }
        [Required]
        public decimal BookingFeePercentage { get; set; }
        public int? MinimalSeatRowForEvent { get; set; } = null;
    }
}
