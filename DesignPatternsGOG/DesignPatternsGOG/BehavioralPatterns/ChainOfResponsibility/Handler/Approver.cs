using DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Client;
using System;

namespace DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Handler
{
    /// <summary>
    /// This is the abstract class that contains a member that holds the next handler in the chain and an associated method to set this successor. 
    /// It also has an abstract method that must be implemented by concrete classes to handle the request or pass it to the next object in the pipeline. 
    /// </summary>
    abstract class Approver
    {
        // Loan event 
        public EventHandler<LoanEventArgs> Loan;

        // Loan event handler
        public abstract void LoanHandler(object sender, LoanEventArgs e);

        // Constructor
        public Approver()
        {
            Loan += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

        // Invoke the Loan event
        public virtual void OnLoan(LoanEventArgs e)
        {
            Loan?.Invoke(this, e);
        }

        // Sets or gets the next approver
        public Approver Successor { get; set; }
    }
}
