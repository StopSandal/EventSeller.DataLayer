using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto.EventType
{
    public class AddEventTypeDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int MinutesForMoneyReturn { get; set; }
        [Required]
        public decimal BookingFeePercentage { get; set; }
        public int? MinimalSeatRowForEvent { get; set; } = null;
    }
}
