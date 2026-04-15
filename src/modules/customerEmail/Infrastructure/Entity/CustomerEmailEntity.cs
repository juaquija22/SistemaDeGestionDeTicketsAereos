namespace SistemaDeGestionDeTicketsAereos.src.modules.customerEmail.Infrastructure.Entity;

public class CustomerEmailEntity
{
    public int IdEmail { get; set; }
    public int IdPerson { get; set; }
    public string Email { get; set; } = string.Empty;
}
