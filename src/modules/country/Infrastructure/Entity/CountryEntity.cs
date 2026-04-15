namespace SistemaDeGestionDeTicketsAereos.src.modules.country.Infrastructure.Entity;

public class CountryEntity
{
    public int IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ISOCode { get; set; } = string.Empty;
}
