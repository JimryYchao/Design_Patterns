namespace DesignPatterns_For_CSharp.Behavioral_Patterns.Memento
{
    public class Originator
    {
        // state
        private string state_1;
        private string state_2;
        private string state_3;
        public void ConsoleState()
        {
            Console.WriteLine($"State_1: {state_1}");
            Console.WriteLine($"State_2: {state_2}");
            Console.WriteLine($"State_3: {state_3}");
        }
        public Originator(string s1, string s2, string s3)
        {
            state_1 = s1;
            state_2 = s2;
            state_3 = s3;
        }
        // Memento
        public Memento CreateMemento(int version)
        {
            Memento memento = new Memento(version);
            memento.SetState(nameof(state_1), state_1);
            memento.SetState(nameof(state_2), state_2);
            memento.SetState(nameof(state_3), state_3);
            return memento;
        }
        public void SetMemento(Memento m)
        {
            state_1 = (string)m.GetState(nameof(state_1));
            state_2 = (string)m.GetState(nameof(state_2));
            state_3 = (string)m.GetState(nameof(state_3));
        }
    }
}