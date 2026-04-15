namespace SistemaDeGestionDeTicketsAereos.src.modules.systemStatus.Infrastructure.Entity;

public class SystemStatusEntity
{
    public int IdStatus { get; set; }
    public string StatusName { get; set; } = string.Empty;
    public string EntityType { get; set; } = string.Empty;
}
