namespace Composition.Models;

public class Person : IDisposable
{
    private bool _disposed;

    public string Name { get; set; }
    public List<Organ> Organs { get; set; }

    public Person(string name)
    {
        Name = name;

        /* 
         * Composition is a subset of association.
         * Therefore, in composition, the "Father" object OWNS the "Child" object, controlling its lifetime.
         * In this case, a Person owns the Organs, so if the Person "dies" the organs also die.
        */

        Organs = new List<Organ>()
        {
            new Organ(name: "Heart"),
            new Organ(name: "Kidney"),
            new Organ(name: "Lungs"),
            new Organ(name: "Bladder"),
        };
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                Name = null;
                Organs = null;
                GC.Collect();
            }

            _disposed = true;
        }
    }
}