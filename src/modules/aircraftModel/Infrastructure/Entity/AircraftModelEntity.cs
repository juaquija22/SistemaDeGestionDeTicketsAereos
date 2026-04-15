namespace SistemaDeGestionDeTicketsAereos.src.modules.aircraftModel.Infrastructure.Entity;

public class AircraftModelEntity
{
    public int IdModel { get; set; }
    public int IdManufacturer { get; set; }
    public string Model { get; set; } = string.Empty;
}
