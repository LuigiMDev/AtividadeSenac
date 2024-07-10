using Xunit;

namespace AtividadeSenac;

class Program
{
    static void Main(string[] args)
    {
    }
}

public static class Calculadora
{
    public static double Somar(double x, double y)
    {
        return x + y;
    }

    public static double Subtrair(double x, double y)
    {
        return x - y;
    }

    public static double Multiplicar(double x, double y)
    {
        return x * y;
    }

    public static double Dividir(double x, double y)
    {
        return x / y;
    }
}

public class Calculadora_Teste
{
    [Fact]
    public void TesteSomar()
    {
        double resultado = Calculadora.Somar(2,3);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TesteSubtrair()
    {
        double resultado = Calculadora.Subtrair(5,2);
        Assert.Equal(3, resultado);
    }

    [Fact]
    public void TesteMultiplicar()
    {
        double resultado = Calculadora.Multiplicar(5,2);
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void TesteDividir()
    {
        double resultado = Calculadora.Dividir(10,0);
        Assert.Equal(double.PositiveInfinity, resultado);
    }
}