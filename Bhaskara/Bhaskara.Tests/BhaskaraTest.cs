namespace Bhaskara.Tests
{
    public class BhaskaraTest
    {
        [Fact]
        public void Duas()
        {
            double a = 1, b = -3, c = 2;

            var resultado = Bhaskara.Bhaskarer.Raizes(a, b, c);

            Assert.Equal(2, resultado.Item1);
            Assert.Equal(1, resultado.Item2);
        }

        [Fact]
        public void Nenhuma()
        {
            double a = 1, b = 2, c = 5;

            var resultado = Bhaskara.Bhaskarer.Raizes(a, b, c);

            Assert.Null(resultado.Item1);
            Assert.Null(resultado.Item2);
        }
    }
}