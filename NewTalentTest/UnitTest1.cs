using Xunit;
using NewTalents;

namespace NewTalentsTest
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2022";
            Calculadora calc = new Calculadora(data);
            return calc;
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Somar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(6, 3, 3)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Subtrair(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = construirClasse();
            int resultadoCalculadora = calc.Dividir(num1, num2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Calculadora calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3,0)    
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(2, 4);
            calc.Somar(3, 7);
            calc.Somar(4, 0);

            var lista = calc.Historico();
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}