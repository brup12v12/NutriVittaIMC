using OperacoesImc;
using Xunit;

namespace CalcularXUnit;

public class Teste1
{
    [Fact]
    public void CalcularImc()
    {
        //Arrange - Organização

        double peso = 80;
        double altura = 1.75;
        double resultadoEsperado = peso / (altura * altura);

        //Act - Execução

        var resultado = Operacao.Calcular(peso, altura);

        //Assert - Verificação

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(43, 1.62, 60 / (1.62 * 1.62))]
    [InlineData(58, 1.75, 70 / (1.75 * 1.75))]
    [InlineData(68, 1.80, 80 / (1.80 * 1.80))]
    public void CalcularImcMultiplo(double peso, double altura, double resultado)
    {
        double resultadoEsperado = Operacao.Calcular(peso, altura);

        Assert.Equal(resultado, resultadoEsperado);

    }
}