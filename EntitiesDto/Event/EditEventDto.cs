
namespace EventSeller.DataLayer.EntitiesDto.Event
{
    public class EditEventDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartEventDateTime { get; set; }
        public DateTime? EndEventDateTime { get; set; }
        public long? EventTypeID { get; set; }
    }
}
