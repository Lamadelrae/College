namespace Planos.Models
{
    public class Plano
    {
        public Forma2d? Forma2d { get; private set; }

        public bool AttachFigura(Forma2d figura)
        {
            Forma2d = figura;

            return true;
        }

        public bool DetachFigura()
        {
            Forma2d = null;

            return true;
        }
    }
}
