using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto.EventType
{
    public class EventTypeViewDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal BookingFeePercentage { get; set; }
    }
}
