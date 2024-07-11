using System.Text.Json.Serialization;

namespace EventSeller.DataLayer.Entities
{
    public class EventSession
    {
        public long Id { get; set; }
        public DateTime StartSessionDateTime { get; set; }
        public DateTime EndSessionDateTime { get; set; }
        public long EventID { get; set; }
        [JsonIgnore]
        public virtual Event Event { get; set; }
        public long HallID { get; set; }
        [JsonIgnore]
        public virtual PlaceHall Hall { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
