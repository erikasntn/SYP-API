namespace ProjetoPI.Model
{
    public class Usuario
    {
        // Propriedades privadas
        protected string Nome;
        protected string Email;
        protected string Senha;
        // Construtor
        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }

        // Métodos Getters e Setters (opcional, dependendo das suas necessidades)
        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public string GetSenha()
        {
            return Senha;
        }

        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}
