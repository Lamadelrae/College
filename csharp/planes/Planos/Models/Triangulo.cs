using Planos.Utils;

namespace Planos.Models
{
    public class Triangulo : Forma2d
    {
        public LimitedList<Ponto> Pontos { get; set; }

        public Triangulo()
        {
            Pontos = new LimitedList<Ponto>(3);
        }

        public override float ObterArea()
        {
            if (Pontos.Count != 3)
            {
                throw new InvalidOperationException("Não há pontos suficiente para calcular a area do triangulo.");
            }

            var ponto1 = Pontos[0];
            var ponto2 = Pontos[1];
            var ponto3 = Pontos[2];

            var expressaoUma = ponto1.X * (ponto2.Y - ponto3.Y);
            var expressaoDuas = ponto2.X * (ponto3.Y - ponto1.Y);
            var expressaoTres = ponto3.X * (ponto1.Y - ponto2.Y);

            return Math.Abs((expressaoUma + expressaoDuas + expressaoTres) / 2);
        }
    }
}
