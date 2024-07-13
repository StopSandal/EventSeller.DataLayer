
namespace EventSeller.DataLayer.EntitiesDto.EventSession
{
    public class EditEventSessionDTO
    {
        public DateTime? StartSessionDateTime { get; set; }
        public DateTime? EndSessionDateTime { get; set; }
        public long? EventID { get; set; }
        public long? HallID { get; set; }
    }
}
