using ProjetoPI.Model;

namespace ProjetoPI.Model
{
    public class Doador : Usuario
    {
        private string CPF;

        // Construtor para a classe Doador
        public Doador(string nome, string email, string senha, string cpf)
            : base(nome, email, senha)
        {
            CPF = cpf;
        }
        public string GetCPF()
        {
            return CPF;
        }

        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }
    }
}
