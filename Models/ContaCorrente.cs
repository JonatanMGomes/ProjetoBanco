namespace ProjetoBanco.Models
{
    public class ContaCorrente : ContaBancaria
    {
        private double LimiteCredito { get; set; }
        public double GetLimiteCredito()
        {
            return LimiteCredito;
        }
        public void SetLimiteCredito(double limiteCredito)
        {
            LimiteCredito = limiteCredito;
        }
        public override void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo atual é:{Saldo}");
            Console.WriteLine($"Limite disponivel:{LimiteCredito}");
        }
    }
}