namespace SistemaDeGestionDeTicketsAereos.src.modules.ticket.Infrastructure.Entity;

public class TicketEntity
{
    public int IdTicket { get; set; }
    public string TicketCode { get; set; } = string.Empty;
    public int IdBooking { get; set; }
    public int IdFare { get; set; }
    public int IdStatus { get; set; }
    public DateTime IssueDate { get; set; }
}
