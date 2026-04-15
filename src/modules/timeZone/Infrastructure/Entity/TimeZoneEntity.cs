namespace SistemaDeGestionDeTicketsAereos.src.modules.timeZone.Infrastructure.Entity;

public class TimeZoneEntity
{
    public int IdTimeZone { get; set; }
    public string Name { get; set; } = string.Empty;
    public string UTCOffset { get; set; } = string.Empty;
}
