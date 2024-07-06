namespace EventSeller.DataLayer.Entities
{
    public class PlaceAddress
    {
        public long ID { get; set; }
        public string PlaceName { get; set; }
        public string Address { get; set; }
        public virtual ICollection<PlaceHall> PlaceHall { get; set; }
    }
}
