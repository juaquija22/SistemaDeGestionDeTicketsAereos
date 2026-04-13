using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace SistemaDeGestionDeTicketsAereos.src.shared.helpers;

/// <summary>
/// Resuelve la cadena de conexión: variable de entorno, sección <c>Database</c> (recomendado si la contraseña tiene caracteres especiales como <c>=</c>),
/// o <c>ConnectionStrings:MySqlDB</c>.
/// </summary>
public static class MySqlConnectionStringResolver
{
    public static string Resolve(IConfiguration config)
    {
        var fromEnv = Environment.GetEnvironmentVariable("MYSQL_CONNECTION");
        if (!string.IsNullOrWhiteSpace(fromEnv))
            return fromEnv.Trim();

        var server = config["Database:Server"];
        if (!string.IsNullOrWhiteSpace(server))
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = server.Trim(),
                Database = config["Database:Database"]?.Trim() ?? "",
                UserID = config["Database:UserId"]?.Trim() ?? "",
            };

            if (uint.TryParse(config["Database:Port"], out var port) && port > 0)
                builder.Port = port;

            var password = config["Database:Password"];
            if (!string.IsNullOrEmpty(password))
                builder.Password = password;

            if (Enum.TryParse<MySqlSslMode>(config["Database:SslMode"], ignoreCase: true, out var ssl))
                builder.SslMode = ssl;
            else
                builder.SslMode = MySqlSslMode.None;

            if (bool.TryParse(config["Database:AllowPublicKeyRetrieval"], out var allowPk))
                builder.AllowPublicKeyRetrieval = allowPk;
            else
                builder.AllowPublicKeyRetrieval = true;

            return builder.ConnectionString;
        }

        var legacy = config.GetConnectionString("MySqlDB");
        if (!string.IsNullOrWhiteSpace(legacy))
        {
            var builder = new MySqlConnectionStringBuilder(legacy.Trim());
            return builder.ConnectionString;
        }

        throw new InvalidOperationException(
            "No hay cadena de conexión: define MYSQL_CONNECTION, o Database:Server + credenciales en appsettings.json, o ConnectionStrings:MySqlDB.");
    }
}
