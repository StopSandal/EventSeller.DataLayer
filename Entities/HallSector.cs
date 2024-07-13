using Microsoft.EntityFrameworkCore;

namespace EventSeller.DataLayer.Entities
{
    [Index(nameof(SectorName), nameof(PlaceHallID), IsUnique = true)]
    public class HallSector
    {
        public long ID { get; set; }
        public string SectorName { get; set; }
        public long PlaceHallID { get; set; }
        public virtual PlaceHall PlaceHall { get; set; }
        public virtual ICollection<TicketSeat> TicketSeats { get; set; }
    }
}
