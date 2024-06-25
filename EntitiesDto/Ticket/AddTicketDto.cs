using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.Ticket
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
        public DateTime? TicketStartDateTime { get; set; }
        public DateTime? TicketEndDateTime { get; set; }
        public long? HallID { get; set; }
        public long? SeatID { get; set; }
    }
}
