using EventSeller.DataLayer.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace EventSeller.DataLayer.Entities
{
    public class Ticket
    {
        public long ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string CurrencyType { get; set; } = CurrencyTypes.USD.ToString();
        public bool isSold { get; set; } = false;
        public DateTime? BookedUntil { get; set; }
        public long? SeatID { get; set; }
        [JsonIgnore]
        public virtual TicketSeat? Seat { get; set; }
        public long EventSessionID { get; set; }
        [JsonIgnore]
        public virtual EventSession EventSession { get; set; }
    }
}
