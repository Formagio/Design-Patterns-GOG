using DesignPatternsGOG.BehavioralPatterns.Interpreter.Expression;
using System;

namespace DesignPatternsGOG.BehavioralPatterns.Interpreter.NonTerminal
{
    /// <summary>
    /// This is a class that implements the Expression. This can have other instances of Expression.
    /// </summary>
    class NonterminalExpression : IExpression
    {
        public IExpression Expression1 { get; set; }
        public IExpression Expression2 { get; set; }

        public void Interpret(Context context)
        {
            Console.WriteLine($"Nonterminal for {context.Name}.");

            Expression1.Interpret(context);
            Expression2.Interpret(context);
        }
    }
}
