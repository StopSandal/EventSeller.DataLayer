using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.HallSector
{
    public class AddHallSectorDto
    {
        [Required]
        public string SectorName { get; set; }
        [Required]
        public long PlaceHallID { get; set; }
    }
}
