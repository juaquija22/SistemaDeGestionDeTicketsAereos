namespace SistemaDeGestionDeTicketsAereos.src.modules.ticketStatusHistory.Infrastructure.Entity;

public class TicketStatusHistoryEntity
{
    public int IdHistory { get; set; }
    public int IdTicket { get; set; }
    public int IdStatus { get; set; }
    public DateTime ChangeDate { get; set; }
    public int IdUser { get; set; }
    public string? Observation { get; set; }
}
