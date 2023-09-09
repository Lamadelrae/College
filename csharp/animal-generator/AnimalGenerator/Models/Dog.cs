namespace AnimalGenerator.Models
{
    public class Dog
    {
        public Guid Id { get; private set; }
        public static string Species { get; private set; } = "Canis lupus familiaris";
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public List<Vaccine> Vaccines { get; private set; }

        /// <summary>
        /// This constructor is used for when the animal has vaccines.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ownerName"></param>
        /// <param name="vaccines"></param>
        public Dog(string name, string ownerName, List<Vaccine> vaccines)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(ownerName, nameof(ownerName));
            ArgumentNullException.ThrowIfNull(vaccines, nameof(vaccines));
            if (!vaccines.Any()) throw new Exception("No vaccines passed.");
            
            Id = Guid.NewGuid();
            Name = name;
            OwnerName = ownerName;
            Vaccines = vaccines;
        }

        /// <summary>
        ///  This constructor is used for when the animal has no vaccines.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ownerName"></param>
        public Dog(string name, string ownerName)
        {
            ArgumentNullException.ThrowIfNull(name, nameof(name));
            ArgumentNullException.ThrowIfNull(ownerName, nameof(ownerName));
            
            Id = Guid.NewGuid();
            Name = name;
            OwnerName = ownerName;
            Vaccines = new List<Vaccine>();
        }
    }
}
