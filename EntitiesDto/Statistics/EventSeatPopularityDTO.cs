
namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class EventSeatPopularityDTO
    {
        public long EventId { get; set; }
        public IEnumerable<SeatPopularityDTO> SeatPopularity { get; set; }
    }
}
