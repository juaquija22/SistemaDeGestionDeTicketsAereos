namespace SistemaDeGestionDeTicketsAereos.src.modules.CheckIn.Infrastructure.Entity;

public class CheckInEntity
{
    public int IdCheckIn { get; set; }
    public int IdTicket { get; set; }
    public DateTime CheckInDate { get; set; }
    public int IdChannel { get; set; }
    public int IdSeat { get; set; }
    public int IdUser { get; set; }
    public int IdStatus { get; set; }
}
