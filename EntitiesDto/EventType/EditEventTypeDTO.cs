

namespace EventSeller.DataLayer.EntitiesDto.EventType
{
    public class EditEventTypeDTO
    {
        public string? Name { get; set; }
        public int? MinutesForMoneyReturn { get; set; }
        public decimal? BookingFeePercentage { get; set; }
        public int? MinimalSeatRowForEvent { get; set; } = null;
    }
}
