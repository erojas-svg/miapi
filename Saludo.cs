namespace MiApi
{
    public static class Saludo
    {
        public static string Generar(string? nombre) =>
        string.IsNullOrWhiteSpace(nombre) ? "Hola Dockhjhjer!" : $"Hola {nombre}!";
    }
}
