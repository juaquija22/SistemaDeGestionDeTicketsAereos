namespace SistemaDeGestionDeTicketsAereos.src.modules.customerPhone.Infrastructure.Entity;

public class CustomerPhoneEntity
{
    public int IdPhone { get; set; }
    public int IdPerson { get; set; }
    public string Phone { get; set; } = string.Empty;
}
