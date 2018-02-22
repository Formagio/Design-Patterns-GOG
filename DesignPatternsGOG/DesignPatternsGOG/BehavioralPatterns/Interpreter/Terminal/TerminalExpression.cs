using DesignPatternsGOG.BehavioralPatterns.Interpreter.Expression;
using System;

namespace DesignPatternsGOG.BehavioralPatterns.Interpreter.Terminal
{
    /// <summary>
    /// This is a class that implements the Expression.
    /// </summary>
    class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine($"Terminal for {context.Name}.");
        }
    }
}
