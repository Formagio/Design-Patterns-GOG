namespace DesignPatternsGOG.BehavioralPatterns.ChainOfResponsibility.Client
{
    /// <summary>
    /// Class that holds request details
    /// </summary>
    class Loan
    {
        public double Amount { get; set; }
        public string Purpose { get; set; }
        public int Number { get; set; }
    }
}
