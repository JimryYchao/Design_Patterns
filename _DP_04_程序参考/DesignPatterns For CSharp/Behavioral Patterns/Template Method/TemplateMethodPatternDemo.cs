namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Template_Method
{
    public class TemplateMethodPatternDemo
    {
        public static void Enter()
        {
            TemplateAbstract templateA = new ConcreteClassA();
            templateA.TemplateMethod();

            TemplateAbstract templateB = new ConcreteClassB();
            templateB.TemplateMethod();
        }
    }
}
