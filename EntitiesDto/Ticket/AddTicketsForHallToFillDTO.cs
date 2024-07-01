using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DateTime? TicketStartDateTime { get; set; }
        public DateTime? TicketEndDateTime { get; set; }
        [Required]
        public long HallID { get; set; }
        [Required]
        public long EventID { get; set; }
        [Required]
        public int SeatsStartRow { get; set; }
        [Required]
        public int SeatsEndRow { get; set; }
    }
}
