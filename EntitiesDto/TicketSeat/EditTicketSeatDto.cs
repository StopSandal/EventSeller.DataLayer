namespace EventSeller.DataLayer.EntitiesDto.TicketSeat
{
    public class EditTicketSeatDto
    {
        public string? PlaceName { get; set; }
        public string? PlaceType { get; set; }
        public int? PlaceRow { get; set; }
        public int? PlaceSeat { get; set; }
        public long HallSectorID { get; set; }
    }
}
