using System.ComponentModel.DataAnnotations;

namespace EventSeller.DataLayer.EntitiesDto.HallSector
{
    public class AddHallSectorDto
    {
        [Required]
        public string SectorName { get; set; }
        [Required]
        public long PlaceHallID { get; set; }
    }
}
