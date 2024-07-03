using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.Ticket
{
    public class EditTicketDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Range(0,double.MaxValue)]
        public decimal? Price { get; set; }
        public string? CurrencyType { get; set; }
        public bool? isSold { get; set; } = false;
        public long? SeatID { get; set; }
        public long? EventSessionID { get; set; }
    }
}
