namespace EventSeller.DataLayer.ExternalDTO.PaymentSystem
{
    public class ConfirmPaymentDTO
    {
        public long TransactionId { get; set; }
        public string ConfirmationCode { get; set; }
    }
}
