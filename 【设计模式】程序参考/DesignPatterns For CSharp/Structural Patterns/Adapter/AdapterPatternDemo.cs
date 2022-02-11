namespace DesignPatterns_For_CSharp.Structural_Patterns.Adapter
{
    public class AdapterPatternDemo
    {
        public static void Enter()
        {
            Client playerClient = new Client(new PlayerAdapter());
            playerClient.PlayCG();
            playerClient.PlayBGMusic();
        }
    }
}
