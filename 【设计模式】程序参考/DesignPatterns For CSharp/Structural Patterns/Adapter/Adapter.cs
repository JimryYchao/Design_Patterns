/* Author ：JimryYchao
 * Email : 17889982535@163.com
 *  设计模式结构型————适配器模式
 * 
 *  意图：{ 将一个类的接口转换成客户希望的另一个接口。Adapter模式使得原本由
 *         于接口不兼容而不能一起工作的那些类可以一起工作。}
 *         
 *  动机：{ 1. 软件系统中，由于应用环境的变化，常常需要将“一些现存的对象”放在
 *         新的环境中应用，但是新环境要求的接口是这些现存对象所不满足的。
 *         
 *         2. 如何应对这种"迁移的变化”?如何既能利用现有对象的良好实现，同时又
 *         能满足新的应用环境所要求的接口? }
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Adapter
{
    public class PlayerAdapter : Player
    {
        AudioPlayer audioPlayer = new AudioPlayer();
        VideoPlayer videoPlayer = new VideoPlayer();
        public override void Play(string fileName, MediaType type)
        {
            audioPlayer.PlayMedia(fileName, type);
            videoPlayer.PlayMedia(fileName, type);
            base.Play(fileName, type);
        }
    }
}