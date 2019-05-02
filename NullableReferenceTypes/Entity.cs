namespace NullableReferenceTypes
{
    class Entity
    {
        public string Name { get; }
        public string Description { get; }

        public Entity(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
