namespace ProjetoBanco.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        private double TaxaJuros { get; set; }
        public double GetTaxaJuros()
        {
            return TaxaJuros;
        }
        public void SetTaxaJuros(double taxaJuros)
        {
            TaxaJuros = taxaJuros;
        }
        public void AtualizarSaldo()
        {
            SetSaldo(GetSaldo()+(GetSaldo()* (TaxaJuros/100)));
        }
    }
}