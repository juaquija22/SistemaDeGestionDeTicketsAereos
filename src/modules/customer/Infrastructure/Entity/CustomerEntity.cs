namespace SistemaDeGestionDeTicketsAereos.src.modules.customer.Infrastructure.Entity;

public class CustomerEntity
{
    public int IdCustomer { get; set; }
    public int IdPerson { get; set; }
    public bool Active { get; set; }
    public DateOnly RegistrationDate { get; set; }
}
