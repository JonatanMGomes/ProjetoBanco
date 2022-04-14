namespace ProjetoBanco.Models
{
    public class Titular
    {
        private string Nome { get; set; }
        private string CPF { get; set; }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetCPF()
        {
            return CPF;
        }
        public void SetCPF(string cpf)
        {
            Nome = cpf;
        }
    }
}