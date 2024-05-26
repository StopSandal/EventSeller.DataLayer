using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.TicketSeat
{
    public class UpdateTicketSeat
    {
        public string PlaceName { get; set; }
        public string PlaceType { get; set; }
        public int? PlaceRow { get; set; }
        public int? PlaceSeat { get; set; }
        public long HallSectorID { get; set; }
    }
}
