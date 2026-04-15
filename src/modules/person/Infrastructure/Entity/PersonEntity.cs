namespace SistemaDeGestionDeTicketsAereos.src.modules.person.Infrastructure.Entity;

public class PersonEntity
{
    public int IdPerson { get; set; }
    public int IdDocumentType { get; set; }
    public string DocumentNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateOnly BirthDate { get; set; }
    public int IdGender { get; set; }
    public int IdCountry { get; set; }
    public int? IdAddress { get; set; }
}
