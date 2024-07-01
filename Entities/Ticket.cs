using EventSeller.DataLayer.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace DataLayer.Model
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
        public DateTime? TicketStartDateTime { get; set; }
        public DateTime? TicketEndDateTime { get; set; }
        public long? SeatID { get; set; }
        [JsonIgnore]
        public virtual TicketSeat? Seat { get; set; }
        public long? HallID { get; set; }
        [JsonIgnore]
        public virtual PlaceHall? Hall { get; set; }
        public long EventID { get; set; }
        [JsonIgnore]
        public virtual Event Event { get; set; } 
    }
}
