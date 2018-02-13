using DesignPatternsGOG.StructuralPatterns.Proxy.Subject;
using System;

namespace DesignPatternsGOG.StructuralPatterns.Proxy.RealSubject
{
    /// <summary>
    /// This is a class which we want to use more efficiently by using proxy class.
    /// </summary>
    class RealClient : IClient
    {
        string Data;

        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            Data = "Dot Net Tricks";
        }

        public string GetData()
        {
            return Data;
        }
    }
}
