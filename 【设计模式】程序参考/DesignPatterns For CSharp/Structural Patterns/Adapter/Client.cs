namespace DesignPatterns_For_CSharp.Structural_Patterns.Adapter
{
    public class Client
    {
        IPlayer Player;
        public Client(IPlayer player) => Player = player;
        public void PlayBGMusic()
        {
            Player.Play("BGMusic.wave", MediaType.wave);
        }
        public void PlayCG()
        {
            Player.Play("CG.mp4", MediaType.mp4);
        }
    }
}