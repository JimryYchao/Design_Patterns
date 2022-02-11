// #define Abstract_Factory
// #define Builder
// #define Factory_Method
// #define Prototype
#define Singleton

using DesignPatterns_For_CSharp.Creational_Patterns.Abstract_Factory;
using DesignPatterns_For_CSharp.Creational_Patterns.Builder;
using DesignPatterns_For_CSharp.Creational_Patterns.Factory_Method;
using DesignPatterns_For_CSharp.Creational_Patterns.Prototype;
using DesignPatterns_For_CSharp.Creational_Patterns.Singleton;

Console.WriteLine("Hello, World!");

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