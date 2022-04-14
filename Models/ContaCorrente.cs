namespace ProjetoBanco.Models
{
    public class ContaCorrente
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
    }
}