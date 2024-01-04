using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Facade
{
    internal class Door
    {
        int width;
        int height;
        public Door(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void BuildDoor()
        {
            Console.WriteLine($"Build a Door >> width:{width} * height:{height}");
        }
    }
    internal class Window
    {
        int count;
        int width;
        int height;
        public Window(int count, int width, int height)
        {
            this.count = count;
            this.width = width;
            this.height = height;
        }
        public void BuildWindow()
        {
            Console.WriteLine($"Build {count} Windows >> width:{width} * height:{height}");
        }
    }
    internal class Wall
    {
        int Height;
        int Width;
        public Wall(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }
        public void BuildWall()
        {
            Console.WriteLine($"Build Walls >> width:{Width} * height:{Height}");
        }
    }
}
