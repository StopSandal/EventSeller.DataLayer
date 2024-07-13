using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.Event
{
    public class AddEventDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime StartEventDateTime { get; set; }
        [Required]
        public DateTime EndEventDateTime { get; set; }
        [Required]
        public long EventTypeID { get; set; }
    }
}
