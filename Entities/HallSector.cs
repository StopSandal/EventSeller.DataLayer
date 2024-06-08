using Microsoft.EntityFrameworkCore;

namespace DataLayer.Model
{
    [Index(nameof(SectorName), nameof(PlaceHallID), IsUnique = true)]
    public class HallSector
    {
        public long ID { get; set; }
        public string SectorName { get; set; }
        public long PlaceHallID { get; set; }
        public PlaceHall PlaceHall { get; set; }
        public virtual ICollection<TicketSeat> TicketSeats { get; set; }
    }
}
