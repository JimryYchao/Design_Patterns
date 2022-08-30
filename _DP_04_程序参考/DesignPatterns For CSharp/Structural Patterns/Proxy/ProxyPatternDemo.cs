namespace DesignPatterns_For_CSharp.Structural_Patterns.Proxy
{
    public class ProxyPatternDemo
    {
        public static void Enter()
        {
            // 实体对象
            RealImage image1 = new RealImage("//path/image1");
            RealImage image2 = new RealImage("//path/image2");
            RealImage image3 = new RealImage("//path/image3");
            RealImage image4 = new RealImage("//path/image4");
            RealImage image5 = new RealImage("//path/image5");
            // 代理对象
            ImageProxy imageProxy = new ImageProxy();

            imageProxy.AddImage(image1);
            imageProxy.AddImage(image2);
            imageProxy.AddImage(image3);
            imageProxy.AddImage(image4);
            imageProxy.AddImage(image5);

            imageProxy.loadFromDisk();
            imageProxy.display();
        }
    }
}