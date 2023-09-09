namespace Planos.Models
{
    public abstract class Forma2d
    {
        public float Pi { get; } = 3.1415926f;
        public Cor? Cor { get; protected set; }

        public void ImporCor(Cor cor) => Cor = cor;
        public abstract float ObterArea();
    }
}
