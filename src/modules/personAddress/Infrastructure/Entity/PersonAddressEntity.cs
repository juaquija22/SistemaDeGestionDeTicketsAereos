namespace SistemaDeGestionDeTicketsAereos.src.modules.personAddress.Infrastructure.Entity;

public class PersonAddressEntity
{
    public int IdAddress { get; set; }
    public int IdPerson { get; set; }
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public int IdCity { get; set; }
    public string? ZipCode { get; set; }
    public bool Active { get; set; }
}
