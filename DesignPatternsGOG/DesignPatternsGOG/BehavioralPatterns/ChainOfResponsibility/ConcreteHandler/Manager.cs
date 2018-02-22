using DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Client;
using DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Handler;
using System;

namespace DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.ConcreteHandler
{
    /// <summary>
    /// These are concrete handlers classes inherited from Handler class. 
    /// These include the functionality to handle some requests and pass others to the next item in the chain of request.
    /// </summary>
    class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000.0)
            {
                Console.WriteLine($"{sender.GetType().Name} approved request# {e.Loan.Number}");
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
            else
            {
                Console.WriteLine($"Request# {e.Loan.Number} requires an executive meeting!");
            }
        }
    }
}
