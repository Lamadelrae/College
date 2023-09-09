namespace Composition.Models;

public class Organ
{
    public string Name { get; set; }
    public Organ(string name) => Name = name;
}