
namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class SalesStatisticsDTO
    {
        public int TotalTickets { get; set; }
        public int TotalSold { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal MaxPossibleIncome { get; set; }

    }
}
