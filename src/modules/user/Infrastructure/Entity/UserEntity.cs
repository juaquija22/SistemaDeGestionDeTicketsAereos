namespace SistemaDeGestionDeTicketsAereos.src.modules.user.Infrastructure.Entity;

public class UserEntity
{
    public int IdUser { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public int IdUserRole { get; set; }
    public int? IdPerson { get; set; }
    public bool Active { get; set; }
}
