using Microsoft.EntityFrameworkCore;

namespace EventSeller.DataLayer.Entities
{
    [Index(nameof(HallName), nameof(PlaceAddressID), IsUnique = true)]
    public class PlaceHall
    {
        public long ID { get; set; }
        public string HallName { get; set; }
        public long PlaceAddressID { get; set; }
        public virtual PlaceAddress PlaceAddress { get; set; }
        public virtual ICollection<HallSector> HallSectors { get; set; }
    }
}
