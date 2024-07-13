namespace EventSeller.DataLayer.ExternalDTO.PaymentSystem
{

    public class ProcessPaymentResponse
    {
        public long TransactionId { get; set; }
        public string ConfirmationCode { get; set; }
    }
}
