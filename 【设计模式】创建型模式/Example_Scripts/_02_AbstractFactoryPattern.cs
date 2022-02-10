/*
 *  设计模式创建型————抽象工厂模式
 * 
 *  意图：{ 提供一个接口，让该接口负责创建一系列“相关或者相互依赖的对象”，无
 *         需指定它们具体的类。}
 *         
 *  动机：{ 1. 在软件系统中，经常面临着“一系列相互依赖的对象"的创建工作；同时，
 *         由于需求的变化，往往存在更多系列对象的创建工作。
 *         
 *         2. 如何应对这种变化？如何绕过常规的对象创建方法(new)，提供一种“封
 *         装机制”来避免客户程序和这种“多系列具体对象创建工作”的紧耦合? }
 */

using System;

namespace Ychao.Learn.DesignPattern.CreationalPattern
{
    //---------------------------------------Car
    public class Car
    {
        public Engine engine;
        public Wheels wheels;
        public Carframe carframe;
        public void Produce()
        {
            engine.ProduceEngine();
            wheels.ProduceWheel();
            carframe.ProduceCarframe();
        }
    }
    //---------------------------------------Engines of Car
    public abstract class Engine
    {
        public abstract void ProduceEngine();
    }
    public class EngineA : Engine
    {
        public override void ProduceEngine()
        {
            //Do produce EngineA...
        }
    }
    public class EngineB : Engine
    {
        public override void ProduceEngine()
        {
            //Do produce EngineB...
        }
    }
    //---------------------------------------Wheels of Car 
    public abstract class Wheels
    {
        public abstract void ProduceWheel();
    }
    public class WheelsA : Wheels
    {
        public override void ProduceWheel()
        {
            //Do produce wheels...
        }
    }
    public class WheelsB : Wheels
    {
        public override void ProduceWheel()
        {
            //Do produce wheels...
        }
    }
    //---------------------------------------Carframes of Car 
    public abstract class Carframe
    {
        public abstract void ProduceCarframe();
    }
    public class CarframeA : Carframe
    {
        public override void ProduceCarframe()
        {
            //Do produce CarframeA...
        }
    }
    public class CarframeB : Carframe
    {
        public override void ProduceCarframe()
        {
            //Do produce CarframeB...
        }
    }
    //---------------------------------------Abstract Factorys
    public abstract class AbstractFactory
    {
        public static Car GetCar(AbstractFactory carfactory)
        {
            Car car = new Car();
            car.engine = carfactory.GetEngine();
            car.carframe = carfactory.GetCarframe();
            car.wheels = carfactory.GetWheels();
            return car;
        }
        public abstract Engine GetEngine();
        public abstract Wheels GetWheels();
        public abstract Carframe GetCarframe();
    }
    public class CarAFactory : AbstractFactory
    {
        public override Carframe GetCarframe()
        {
            return new CarframeA();
        }

        public override Engine GetEngine()
        {
            return new EngineA();
        }

        public override Wheels GetWheels()
        {
            return new WheelsA();
        }
    }
    public class CarBFactory : AbstractFactory
    {
        public override Carframe GetCarframe()
        {
            return new CarframeB();
        }

        public override Engine GetEngine()
        {
            return new EngineB();
        }

        public override Wheels GetWheels()
        {
            return new WheelsB();
        }
    }
    //---------------------------------------AbstractFactory Pattern Demo
    public class AbstractFactoryPatternDemo
    {
        static void Main_(string[] args)
        {
            Car carA = AbstractFactory.GetCar(new CarAFactory());
            carA.Produce();
            Car carB = AbstractFactory.GetCar(new CarBFactory());
            carB.Produce();
        }
    }
}
