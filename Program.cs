using Npgsql;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Docker!");

app.MapGet("/db", async (IConfiguration config) =>
{
    await using var conn = new NpgsqlConnection(config.GetConnectionString("Default"));
    await conn.OpenAsync();
    await using var cmd = new NpgsqlCommand("SELECT version()", conn);
    return await cmd.ExecuteScalarAsync();
});

app.Run();