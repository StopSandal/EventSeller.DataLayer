using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto.Event
{
    public class EventViewDTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartEventDateTime { get; set; }
        public DateTime? EndEventDateTime { get; set; }
        public long EventTypeID { get; set; }
    }
}
