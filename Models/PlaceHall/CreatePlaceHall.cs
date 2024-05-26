using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.PlaceHall
{
    public class CreatePlaceHall
    {
        [Required]
        public string HallName { get; set; }
        [Required]
        public long PlaceAddressID { get; set; }
    }
}
