namespace AnimalGenerator.Models
{
    public class Vaccine
    {
        public string Name { get; set; }
        public string WhatFor { get; set; }

        public Vaccine(string name, string whatFor)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(whatFor, nameof(whatFor));

            Name = name;
            WhatFor = whatFor;
        }
    }
}
