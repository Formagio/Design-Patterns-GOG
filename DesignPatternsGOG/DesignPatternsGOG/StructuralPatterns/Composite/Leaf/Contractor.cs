using DesignPatternsGOG.StructuralPatterns.Composite.Component;

namespace DesignPatternsGOG.StructuralPatterns.Composite.Leaf
{
    /// <summary>
    /// This is a class which is used to define leaf components within the tree structure means these cannot have children.
    /// </summary>
    class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
}
