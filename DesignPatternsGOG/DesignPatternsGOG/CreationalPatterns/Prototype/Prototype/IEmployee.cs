namespace DesignPatternsGOG.CreationalPatterns.Prototype
{
    /// <summary>
    /// This is an interface which is used for the types of object that can be cloned itself.
    /// </summary>
    interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
