using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSeller.DataLayer.ExternalDTO.PaymentSystem
{
    public class ProcessPaymentResponse
    {
        public long TransactionId { get; set; }
        public string ConfirmationCode { get; set; }
    }
}
