using DesignPatternsGOG.StructuralPatterns.Proxy.RealSubject;
using DesignPatternsGOG.StructuralPatterns.Proxy.Subject;
using System;

namespace DesignPatternsGOG.StructuralPatterns.Proxy
{
    /// <summary>
    /// This is a class which holds the instance of RealSubject class and can access 
    /// RealSubject class members as required.
    /// </summary>
    public class ProxyClient : IClient
    {
        RealClient client = new RealClient();

        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}
