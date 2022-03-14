namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computer);
    }
}