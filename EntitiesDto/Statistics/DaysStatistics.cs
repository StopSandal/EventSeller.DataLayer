using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class DaysStatistics
    {
        public DateTime Date {  get; set; }
        public string DayOfWeek { get; set; } = "";
        public int TotalTraffic {  get; set; }
    }
}
