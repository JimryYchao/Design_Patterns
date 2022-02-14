// #define Abstract_Factory
// #define Builder
// #define Factory_Method
// #define Prototype
// #define Singleton

// #define Adapter
// #define Bridge
// #define Composite
// #define Decoretor
// #define Facade
#define Flyweight
#define Proxy

using DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory;
using DesignPatterns_For_CSharp.Creational_Patterns.Builder;
using DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method;
using DesignPatterns_For_CSharp.Creational_Patterns.Prototype;
using DesignPatterns_For_CSharp.Creational_Patterns.Singleton;

using DesignPatterns_For_CSharp.Structural_Patterns.Adapter;
using DesignPatterns_For_CSharp.Structural_Patterns.Bridge;
using DesignPatterns_For_CSharp.Structural_Patterns.Composite;
using DesignPatterns_For_CSharp.Structural_Patterns.Decorator;
using DesignPatterns_For_CSharp.Structural_Patterns.Facade;

Console.WriteLine("Hello, World!");

#region Creational Patterns

#if Abstract_Factory
AbstractFactoryPatternDemo.Enter();
#endif

#if Builder
BuilderPatternDemo.Enter();
#endif

#if Factory_Method
FactoryMethodPatternDemo.Enter();
#endif

#if Prototype
PrototypePatternDemo.Enter();
#endif

#if Singleton
SingletonPatternDemo.Enter();
#endif

#endregion Creational Patterns


#region Structural Patterns

#if Adapter
AdapterPatternDemo.Enter();
#endif

#if Bridge
BridgePatternDemo.Enter();
#endif

#if Composite
CompositePatternDemo.Enter();
#endif

#if Decoretor
DecoratorPatternDemo.Enter();
#endif

#if Facade
FacadePatternDemo.Enter();
#endif

#if Flyweight

#endif

#if Proxy

#endif

#endregion Structural_Patterns