using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.EntitiesDto
{
    public class PaymentConfirmationDTO
    {
        public long TransactionId { get; set; }
        public string ConfirmationCode { get; set; }
        public long TicketId { get; set; }
    }
}
