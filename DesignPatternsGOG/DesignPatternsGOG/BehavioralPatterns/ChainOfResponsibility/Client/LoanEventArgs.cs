using System;

namespace DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Client
{
    // Loan event argument holds Loan info
    class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }
}
