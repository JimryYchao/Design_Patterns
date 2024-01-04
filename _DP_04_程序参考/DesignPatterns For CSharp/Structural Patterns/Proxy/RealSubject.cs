using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Proxy
{
    public class RealImage : Image
    {
        private string fileName;
        public string FileName => fileName;
        private string Image;
        public RealImage(string fileName)
        {
            this.fileName = fileName;
            Image = string.Empty;
        }
        public void display()
        {
            Console.WriteLine($"Display an image:[{Image}] on Disk");
        }
        public void loadFromDisk()
        {
            Console.WriteLine("Create a Image");
            if (Image == "")
                Image = FileName.Substring(7);
        }
    }
}
