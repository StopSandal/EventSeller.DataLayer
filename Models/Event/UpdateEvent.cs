using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.Event
{
    internal class UpdateEvent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartEventDateTime { get; set; }
        public DateTime EndEventDateTime { get; set; }
    }
}
