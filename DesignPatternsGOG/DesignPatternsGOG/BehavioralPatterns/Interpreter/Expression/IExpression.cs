namespace DesignPatternsGOG.BehavioralPatterns.Interpreter.Expression
{
    /// <summary>
    /// This is an interface that defines the Interpret operation, which must be implemented by each subclass.
    /// </summary>
    interface IExpression
    {
        void Interpret(Context context);
    }
}
