namespace AtividadeComplementares.Models
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }  

        public Aluno(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
