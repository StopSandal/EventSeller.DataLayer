

namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class EventPopularityStatistic
    {
        public Entities.Event EventItem {  get; set; }
        public PopularityStatisticDTO PopularityStatistic { get; set; }
    }
}
