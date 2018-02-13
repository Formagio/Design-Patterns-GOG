namespace DesignPatternsGOG.StructuralPatterns.Composite.Component
{
    /// <summary>
    /// This is an abstract class containing members that will be implemented by all object in the hierarchy. 
    /// It acts as the base class for all the objects within the hierarchy
    /// </summary>
    interface IEmployed
    {
        int EmpID { get; set; }
        string Name { get; set; }
    }
}
