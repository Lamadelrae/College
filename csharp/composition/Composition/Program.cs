using Composition.Models;

using var person = new Person("Matthew");

Console.WriteLine($"Hi! My name is {person.Name}!");
Console.WriteLine("Here are some of my organs:");

foreach (var organ in person.Organs) Console.WriteLine(organ.Name);