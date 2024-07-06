using System.ComponentModel.DataAnnotations.Schema;


namespace EventSeller.DataLayer.Entities
{
    public class TicketTransaction
    {
        public long ID { get; set; }
        public string userId { get; set; }
        public virtual User User { get; set; }
        public long TicketID { get; set; }
        public virtual Ticket Ticket { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TransactionAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnreturnableFee { get; set; }
        public string CurrencyType { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public long TransactionId { get; set; }
        public bool IsReturned { get; set; } = false;
    }
}
