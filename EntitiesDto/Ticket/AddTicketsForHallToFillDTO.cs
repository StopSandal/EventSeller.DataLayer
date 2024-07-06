using EventSeller.DataLayer.EntitiesDto.EventSession;
using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.Ticket
{
    public class AddTicketsForHallToFillDTO
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
        public AddEventSessionDTO addEventSessionDTO { get; set; }
        [Required]
        public long HallID { get; set; }
        [Required]
        public int SeatsStartRow { get; set; }
        [Required]
        public int SeatsEndRow { get; set; }
    }
}
