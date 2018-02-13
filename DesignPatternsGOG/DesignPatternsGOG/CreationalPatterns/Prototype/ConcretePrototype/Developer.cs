namespace DesignPatternsGOG.CreationalPatterns.Prototype.ConcretePrototype
{
    /// <summary>
    /// This is a class which implements the Prototype interface for cloning itself.
    /// </summary>
    class Developer : IEmployee
    {
        public int WordsPerMinute { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string PreferredLanguage { get; set; }

        public IEmployee Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IEmployee)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (IEmployee)this.Clone();
        }

        public string GetDetails()
        {
            return $"{Name} - {Role} - {PreferredLanguage}";
        }
    }
}
