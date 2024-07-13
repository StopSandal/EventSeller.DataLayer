namespace EventSeller.DataLayer.EntitiesDto.Statistics
{
    public class DaysStatistics
    {
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; } = "";
        public int TotalTraffic { get; set; }
    }
}
