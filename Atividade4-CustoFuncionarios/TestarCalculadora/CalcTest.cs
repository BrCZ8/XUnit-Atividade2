using Atividade4_CustoFuncionarios.Models;

namespace TestarCalculadora
{
    public class CalcTest
    {
        [Fact]
        public void CalcCustoTotalCorreto()
        {
            var funcionario = new FuncionarioModel
            {
                Nome = "Brunin",
                SalarioBase = 20000,
                Desconto = 19000,
                Beneficio = 30000
            };
            var resultado = funcionario.CalcCT();
            Assert.Equal(31000, resultado);
        }
    }
}