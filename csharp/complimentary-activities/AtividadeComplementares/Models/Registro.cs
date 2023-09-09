namespace AtividadeComplementares.Models
{
    public class Registro
    {
        public DateTime DataValidacao { get; private set; }
        public Aluno Aluno { get; private set; }
        public AtividadeComplementar AtividadeComplementar { get; private set; }

        public Registro(Aluno aluno, AtividadeComplementar atividadeComplementar)
        {
            DataValidacao = DateTime.Now;
            Aluno = aluno;
            AtividadeComplementar = atividadeComplementar;
        }

        public void RegistrarAtividadeComplementar()
        {
            if(DataValidacao < AtividadeComplementar.Realizacao)
            {
                throw new InvalidOperationException("Data de validação não pode ser anterior a de realização.");
            }
        }
    }
}
