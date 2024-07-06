using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.Entities.Ticket
{
    public class AddTicketDto
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        public string CurrencyType { get; set; }
        public long? SeatID { get; set; }
        [Required]
        public long EventSessionId { get; set; }
    }
}
