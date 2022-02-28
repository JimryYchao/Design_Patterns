namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Memento
{
    public class MementoPatternDemo
    {
        public static void Enter()
        {
            Originator o = new Originator("Hello", "World", "!");
            Caretaker.SaveMemento(1, o.CreateMemento(1));
            o = new Originator("X", "Y", "Z");
            o.SetMemento(Caretaker.GetMemento(1));
            o.ConsoleState();
        }
    }
}