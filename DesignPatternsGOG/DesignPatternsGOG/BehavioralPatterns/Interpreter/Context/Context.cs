namespace DesignPatternsGOG.BehavioralPatterns.Interpreter
{
    /// <summary>
    /// This is a class that contains information (input and output), which is used by the Interpreter.
    /// </summary>
    class Context
    {
        public string Name { get; set; }

        public Context(string name)
        {
            Name = name;
        }
    }
}
