using MiApi;
using Xunit;

public class SaludoTests
{
    [Fact]
    public void SinNombre_DevuelveSaludoPorDefecto() =>
        Assert.Equal("Hola Docker!", Saludo.Generar(null));

    [Fact]
    public void ConNombre_IncluyeElNombre() =>
        Assert.Equal("Hola Ana!", Saludo.Generar("Ana"));
}