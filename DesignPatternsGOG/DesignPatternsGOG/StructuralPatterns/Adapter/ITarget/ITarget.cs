using System.Collections.Generic;

namespace DesignPatternsGOG.StructuralPatterns.Adapter
{
    /// <summary>
    /// This is an interface which is used by the client to achieve its functionality/request.
    /// </summary>
    interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
