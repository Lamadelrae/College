
using AnimalGenerator.Models;

var dogs = new List<Dog>();
for (int i = 0; i < 10; i++)
{
    var withOutVaccine = new Dog($"Dog_WithOutVaccine_{i}", $"Owner_WithOutVaccine_{i}");
    dogs.Add(withOutVaccine);

    var vaccines = Enumerable.Range(0, 5).Select(j => new Vaccine($"Vaccine_{j}", $"WhatFor_{j}")).ToList();
    var withVaccine = new Dog($"Dog_WithVaccine_{i}", $"Owner_WithVaccine_{i}", vaccines);
    dogs.Add(withVaccine);
}

foreach (var dog in dogs.OrderBy(dog => dog.Vaccines.Any()))
{
    var hasVaccines = dog.Vaccines.Any() ? "Yes" : "No";

    Console.WriteLine($"Name: {dog.Name}; Owner: {dog.OwnerName}; HasVaccines? {hasVaccines}");
}
