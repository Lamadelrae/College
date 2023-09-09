using Planos.Utils;

namespace Planos.Models
{
    public class Circulo : Forma2d
    {
        public LimitedList<Ponto> Pontos { get; set; }

        public Circulo()
        {
            Pontos = new LimitedList<Ponto>(2);
        }

        public override float ObterArea()
        {
            if (Pontos.Count != 2)
            {
                throw new InvalidOperationException("Não há pontos suficiente para calcular a area do ciclo.");
            }

            var centro = Pontos[0];
            var ponto = Pontos[1];

            var raio = (float)Math.Sqrt(Math.Pow(ponto.X - centro.X, 2) + Math.Pow(ponto.Y - centro.Y, 2));
            var area = (float)(Pi * Math.Pow(raio, 2));

            return area;
        }
    }
}
