using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.EventSession
{
    public class AddEventSessionDTO
    {
        [Required]
        public DateTime StartSessionDateTime { get; set; }
        [Required]
        public DateTime EndSessionDateTime { get; set; }
        [Required]
        public long EventID { get; set; }
        [Required]
        public long HallID { get; set; }
    }
}
