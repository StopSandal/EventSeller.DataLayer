using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.TicketSeat
{
    public class AddTicketSeatDto
    {
        [Required]
        public string PlaceName { get; set; }
        [Required]
        public string PlaceType { get; set; }
        public int? PlaceRow { get; set; }
        public int? PlaceSeat { get; set; }
        [Required]
        public long HallSectorID { get; set; }
    }
}
