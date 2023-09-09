namespace AtividadeComplementares.Models
{
    public class MiniCurso : AtividadeComplementar
    {
        public string UrlCertificado { get; private set; }

        public MiniCurso(string nome, DateTime realizacao, int cargaHoraria, string urlCertificado) : base(nome, realizacao, cargaHoraria)
        {
            UrlCertificado = urlCertificado;
        }
    }
}
