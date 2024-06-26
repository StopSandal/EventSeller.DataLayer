using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto
{
    public class TicketPriceInfoDTO
    {
        public decimal TotalAmount {  get; set; }
        public decimal TicketPrice { get; set; }
        public decimal BookingFeePercentage { get; set; }
        public string CurrencyType { get; set; }
    }
}
