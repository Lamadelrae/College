namespace Planos.Utils
{
    public class LimitedList<T> : List<T>
    {
        private readonly int maxCapacity;

        public LimitedList(int capacity)
        {
            maxCapacity = capacity;
        }

        public new void Add(T item)
        {
            if (Count >= maxCapacity)
            {
                throw new InvalidOperationException("Maximum capacity reached.");
            }

            base.Add(item);
        }
    }
}
