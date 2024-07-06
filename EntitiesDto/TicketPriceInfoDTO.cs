
namespace EventSeller.DataLayer.EntitiesDto
{
    public class TicketPriceInfoDTO
    {
        public decimal TotalAmount {  get; set; }
        public decimal TicketPrice { get; set; }
        public decimal BookingFeePercentage { get; set; }
        public decimal BookingAmount { get; set; }  
        public string CurrencyType { get; set; }
    }
}
