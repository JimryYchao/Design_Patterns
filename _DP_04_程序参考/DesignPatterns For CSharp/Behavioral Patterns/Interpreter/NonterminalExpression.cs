namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter
{
    /// <summary>
    /// 对运算符进行解释
    /// </summary>
    public abstract class OperationExpression : AritheticExpression
    {
        public abstract double Interpret();
        protected AritheticExpression exp1, exp2;
        public OperationExpression(AritheticExpression exp1, AritheticExpression exp2)
        {
            this.exp1 = exp1;
            this.exp2 = exp2;
        }
    }
    public class AdditionExpression : OperationExpression
    {
        public AdditionExpression(AritheticExpression exp1, AritheticExpression exp2) : base(exp1, exp2) { }
        public override double Interpret()
        {
            //if (exp1 == null || exp2 == null)
            //    return;
            return exp1.Interpret() + exp2.Interpret();
        }
    }
    public class SubtractionExpression : OperationExpression
    {
        public SubtractionExpression(AritheticExpression exp1, AritheticExpression exp2) : base(exp1, exp2) { }
        public override double Interpret()
        {
            return exp1.Interpret() - exp2.Interpret();
        }
    }
    public class MultiplicationExpression : OperationExpression
    {
        public MultiplicationExpression(AritheticExpression exp1, AritheticExpression exp2) : base(exp1, exp2) { }
        public override double Interpret()
        {
            return exp1.Interpret() * exp2.Interpret();
        }
    }
    public class DivisionExpression : OperationExpression
    {
        public DivisionExpression(AritheticExpression exp1, AritheticExpression exp2) : base(exp1, exp2) { }
        public override double Interpret()
        {
            return exp1.Interpret() / exp2.Interpret();
        }
    }
}