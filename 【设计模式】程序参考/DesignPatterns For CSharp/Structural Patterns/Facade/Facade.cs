/* Author : JimryYchao
 * Email : 17889982535@163.com
 * 
 *  设计模式结构型————外观模式
 * 
 *  意图：{ 为子系统中的一组接口提供一个一致的界面，Facade 模式定义了一个高层接口，这个接
 *         口使得这子系统更加容易使用。}
 *         
 *  动机：{ 1. 组件的客户和组件中各种复杂的子系统有了过多的耦合，随着外部客户程序和各子
 *         系统的演化，这种过多的耦合面临很多变化的挑战。
 *         
 *         2. 如何简化外部客户程序和系统间的交互接口？如何将外部客户程序的演化和内部子系
 *         统的变化之间的依赖相互解耦? }
 */

namespace DesignPatterns_For_CSharp.Structural_Patterns.Facade
{
    public class Facade
    {
        public static readonly Facade Instance = new Facade();
        private Wall walls = new Wall(3, 5);
        private Door door = new Door(1, 2);
        private Window windows = new Window(4, 1, 1);
        public void Build()
        {
            walls.BuildWall();
            door.BuildDoor();
            windows.BuildWindow();
        }
    }
}