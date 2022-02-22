namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter
{
    public class NumberExpression : AritheticExpression
    {
        private double number;
        public NumberExpression(double num)
        {
            number = num;
        }
        public double Interpret()
        {
            return number;
        }
    }
}
