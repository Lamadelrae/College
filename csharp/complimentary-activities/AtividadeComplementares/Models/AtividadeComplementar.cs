namespace AtividadeComplementares.Models
{
    public class AtividadeComplementar
    {
        public string Nome { get; private set; }
        public DateTime Realizacao { get; private set; }
        public int CargaHoraria { get; private set; }

        public AtividadeComplementar(string nome, DateTime realizacao, int cargaHoraria)
        {
            Nome = nome;
            Realizacao = realizacao;
            CargaHoraria = cargaHoraria;
        }
    }
}
