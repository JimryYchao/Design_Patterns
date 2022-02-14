namespace DesignPatterns_For_CSharp.Structural_Patterns.Composite
{
    public class CompositePatternDemo
    {
        public static void Enter()
        {
            Client team = new Client();
            team.DoWork(team.BuildATeam());
        }
    }
}
