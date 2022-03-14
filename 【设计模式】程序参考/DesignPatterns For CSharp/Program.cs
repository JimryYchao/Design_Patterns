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
// #define Flyweight
// #define Proxy

// #define ChainOfResponsibility
// #define Command
// #define Interpreter
// #define Iterator
// #define Mediator
// #define Memento
// #define Observer
// #define State
// #define Strategy
// #define TemplateMethod
#define Visitor

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
using DesignPatterns_For_CSharp.Structural_Patterns.Flyweight;
using DesignPatterns_For_CSharp.Structural_Patterns.Proxy;

using DesignPatterns_For_CSharp.Behavioral_Patterns.ChainOfResponsibility;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Command;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Interpreter;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Iterator;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Mediator;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Memento;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Observer;
using DesignPatterns_For_CSharp.Behavioral_Patterns.State;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Strategy;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Template_Method;
using DesignPatterns_For_CSharp.Behavioral_Patterns.Visitor;

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
FlyweightPatternDemo.Enter();
#endif

#if Proxy
ProxyPatternDemo.Enter();
#endif

#endregion Structural Patterns


#region  Behavioral Patterns

#if ChainOfResponsibility
ChainOfResponsibilityPatternDemo.Enter();
#endif

#if Command
CommandPatternDemo.Enter();
#endif

#if Interpreter
InterpreterPatternDemo.Enter();
#endif

#if Iterator
IteratorPatternDemo.Enter();
#endif

#if Mediator
MediatorPatternDemo.Enter();
#endif

#if Memento
MementoPatternDemo.Enter();
#endif

#if Observer
ObserverPatternDemo.Enter();
#endif

#if State
StatePatternDemo.Enter();
#endif

#if Strategy
StrategyPatternDemo.Enter();
#endif

#if TemplateMethod
TemplateMethodPatternDemo.Enter();
#endif

#if Visitor
VisitorPatternDemo.Enter();
#endif

#endregion Behavioral Patterns