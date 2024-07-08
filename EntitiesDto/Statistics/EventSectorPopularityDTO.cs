
namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class EventSectorPopularityDTO
    {
        public long EventId { get; set; }
        public IEnumerable<SectorPopularityDTO> SectorPopularity { get; set; }
    }
}
