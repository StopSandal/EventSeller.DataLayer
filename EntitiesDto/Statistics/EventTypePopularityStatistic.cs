
using EventSeller.DataLayer.Entities;

namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class EventTypePopularityStatisticDTO
    {
        public Entities.EventType EventTypeItem { get; set; }
        public PopularityStatisticDTO PopularityStatistic { get; set; }
    }
}
