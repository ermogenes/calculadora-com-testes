using Xunit;
using Calculadora.Lib;

namespace Calculadora.Test;

public class AritmeticaTest
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(0, 2, 2)]
    [InlineData(2, 0, 2)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -2, -4)]
    [InlineData(-2, 1, -1)]
    [InlineData(1, -2, -1)]
    [InlineData(2.5, 1, 3.5)]
    [InlineData(-2.5, 2, -0.5)]
    public void SomaCalculaCorretamente(double a, double b, double resultado)
    {
        Assert.Equal(resultado, Aritmetica.Soma(a, b));
    }

    [Theory]
    [InlineData(2, 2, 0)]
    [InlineData(0, 2, -2)]
    [InlineData(2, 0, 2)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -2, 0)]
    [InlineData(-2, 1, -3)]
    [InlineData(1, -2, 3)]
    [InlineData(2.5, 1, 1.5)]
    [InlineData(-2.5, 2, -4.5)]
    public void SubtracaoCalculaCorretamente(double a, double b, double resultado)
    {
        Assert.Equal(resultado, Aritmetica.Subtracao(a, b));
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(0, 2, 0)]
    [InlineData(2, 0, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -2, 4)]
    [InlineData(-2, 1, -2)]
    [InlineData(1, -2, -2)]
    [InlineData(2.5, 1, 2.5)]
    [InlineData(-2.5, 2, -5)]
    public void MultiplicacaoCalculaCorretamente(double a, double b, double resultado)
    {
        Assert.Equal(resultado, Aritmetica.Multiplicacao(a, b));
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(3, 2, 1.5)]
    [InlineData(0, 2, 0)]
    [InlineData(0, -2, 0)]
    [InlineData(0, 2.5, 0)]
    [InlineData(-2, -2, 1)]
    [InlineData(-2, 1, -2)]
    [InlineData(1, -2, -0.5)]
    [InlineData(2.5, 1, 2.5)]
    [InlineData(-2.5, 2, -1.25)]
    public void DivisaoCalculaCorretamente(double a, double b, double resultado)
    {
        Assert.Equal(resultado, Aritmetica.Divisao(a, b));
    }

    [Theory]
    [InlineData(2)]
    [InlineData(-2)]
    [InlineData(2.5)]
    [InlineData(-2.5)]
    [InlineData(0)]
    public void DivisaoPorZeroGeraExcecao(double dividendo)
    {
        Assert.Throws<System.DivideByZeroException>(() => Aritmetica.Divisao(dividendo, 0));
    }
}
