using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.Entities
{
    public class EventType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int MinutesForMoneyReturn { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal BookingFeePercentage { get; set; }
        public int? MinimalSeatRowForEvent { get; set; } = null;
        public virtual ICollection<Event> Event { get; set; }
    }
}
