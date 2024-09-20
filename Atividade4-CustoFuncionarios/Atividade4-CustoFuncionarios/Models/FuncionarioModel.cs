namespace Atividade4_CustoFuncionarios.Models
{
    public class FuncionarioModel
    {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Desconto { get; set; }
        public decimal Beneficio { get; set; }

        public decimal CalcCT()
        {
            return (SalarioBase + Beneficio) - Desconto;
        }

    }
}
