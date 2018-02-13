namespace DesignPatternsGOG.StructuralPatterns.Proxy.Subject
{
    /// <summary>
    /// This is an interface having members that will be implemented by RealSubject and Proxy class.
    /// </summary>
    interface IClient
    {
        string GetData();
    }
}
