using EventSeller.DataLayer.Entities;
using DataLayer.Model;

namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class EventPopularityStatistic
    {
        public DataLayer.Model.Event EventItem {  get; set; }
        public PopularityStatisticDTO PopularityStatistic { get; set; }
    }
}
