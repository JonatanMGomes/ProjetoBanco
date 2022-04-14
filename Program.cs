using ProjetoBanco.Models;
namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contaPoup = new ContaPoupanca();
            var contaCorre = new ContaCorrente();
            Console.WriteLine("Conta Poupança:");
            contaPoup.ExibirSaldo();
            Console.WriteLine("Conta Corrente:");
            contaCorre.ExibirSaldo();

            contaPoup.Depositar(550);
            contaCorre.Depositar(420);
            Console.WriteLine("Conta Poupança:");
            contaPoup.ExibirSaldo();
            Console.WriteLine("Conta Corrente:");
            contaCorre.ExibirSaldo();

            contaPoup.Sacar(300);
            contaCorre.Sacar(150);
            Console.WriteLine("Conta Poupança:");
            contaPoup.ExibirSaldo();
            Console.WriteLine("Conta Corrente:");
            contaCorre.ExibirSaldo();
        }
    }
}