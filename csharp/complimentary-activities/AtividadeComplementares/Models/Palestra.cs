namespace AtividadeComplementares.Models
{
    public class Palestra : AtividadeComplementar
    {
        public string Palestrante { get; private set; }

        public Palestra(string nome, DateTime realizacao, int cargaHoraria, string palestrante) : base(nome, realizacao, cargaHoraria)
        {
            Palestrante = palestrante;
        }
    }
}
