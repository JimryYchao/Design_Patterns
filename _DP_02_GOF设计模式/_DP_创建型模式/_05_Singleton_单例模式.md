## Singleton Pattern

- [Singleton Pattern](#singleton-pattern)
  - [单例模式 (Singleton)](#单例模式-singleton)
  - [模式设计](#模式设计)
    - [模式实现](#模式实现)
  - [单例的常规实现](#单例的常规实现)
    - [单线程安全 (非多线程安全特性)](#单线程安全-非多线程安全特性)
    - [单例继承模式](#单例继承模式)
    - [多线程安全](#多线程安全)
    - [接口的抽象静态单例实现](#接口的抽象静态单例实现)
    - [线程单例模式](#线程单例模式)
  - [案例实现](#案例实现)

---
### 单例模式 (Singleton)

单例模式 (Singleton Pattern) 是编程语言中最简单的设计模式之一。这种类型的设计模式属于创建型模式，它提供了一种创建对象的最佳方式。

这种模式涉及到一个单一的类，该类负责创建自己的对象，同时确保只有单个对象被创建。这个类提供了一种访问其唯一的对象的方式，可以直接访问，不需要实例化该类的对象。

注意：
1. 单例类只能有一个实例。
2. 单例类必须自己创建自己的唯一实例。
3. 单例类必须给所有其他对象提供这一实例。

> **意图**

保证一个类仅有一个实例，并提供一个访问它的全局访问点。主要解决 **一个全局使用的类频繁地创建与销毁**。

> **动机**

在软件系统中，经常有这样一些特殊的类，必须保证它们在系统中只存在一个实例，才能确保它们的逻辑正确性、以及良好的效率。

如何绕过常规的构造器，提供一种机制来保证一个类只有一个实例? 这应该是类设计者的责任，而不是使用者的责任。

> **适用性**

可以使用 Singleton 的情况：
- 当类只能有一个实例而且客户可以从一个众所周知的访问点访问它时。
- 当这个唯一实例应该是通过子类化可扩展的，并且客户应该无需更改代码就能使用一个扩展的实例时。

>---
### 模式设计

> **参与者**

- Singleton：定义一个 Instance 操作，允许客户访问它的唯一实例，Instance 是一个类操作 (类方法或静态成员等)。

> **单例模式优缺点**

Singleton 有许多优点：
1. 对唯一实例的受控访问。
2. 缩小名空间：Singleton 模式是对全局变量的一种改进。
3. 允许对操作和表示的精化：Singleton 可以有子类，且利用这个扩展类配置功能会很容易。
4. 允许可变数量的实例：多例模式。
5. 比类操作更灵活：另一种封装单件功能的方式是使用类操作 (如静态方法) ，但类操作不允许一个类有多个实例，且静态方法不可以设定为虚函数，因此子类不能利用多态进行重定义。

#### 模式实现

使用 Singleton 需要考虑的问题：
1. 保证一个唯一的实例：将创建唯一实例的方法隐藏在一个类操作后面，保证了单件在它的首次使用前被创建和使用。
2. 创建 Singleton 的子类：将父类的 Instance 的实现分离出来并将它放入到子类中，可以使用一个单例注册表，访问单例通过 Singleton 集合中的注册信息进行访问，因此不需要所有单件无论是否使用都要被创建。

注意事项: getInstance() 方法中有时需要使用同步锁 synchronized (Singleton.class) 防止多线程同时进入造成 instance 被多次实例化。

> **设计要点**

1. Singleton 模式中的实例构造器可以设置为 protected 以允许子类派生。
2. Singleton 模式一般不要支持 ICloneable 接口，因为这可能会导致多个对象实例，与 Singleton 模式的初衷违背。
3. Singleton 模式一般不要支持序列化，因为这也有可能导致多个对象实例，同样与 Singleton 模式的初衷违背。
4. Singleton 模式只考虑到了对象创建的管理，没有考虑对象销毁的管理。就支持垃圾回收的平台和对象的开销来讲，我们一般没有必要对其销毁进行特殊的管理。
5. 不能应对多线程环境：在多线程环境下，使用 Singleton 模式仍然有可能得到 Singleton 类的多个实例对象。

>---
### 单例的常规实现
#### 单线程安全 (非多线程安全特性)

> 常规实现

```csharp
    public class Singleton{
        private static Singleton instance;
        private Singleton(){}
        public static Singleton getInstance(){
            if(instance == null)
                instance = new Singleton();
            return instance;
        }
    }
```

> CSharp 属性调用单例

```csharp
    public class Singleton{
        private static Singleton instance;
        private Singleton(){}
        public static Singleton Instance{
            get{
                if(instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
```

> 带参构造单例

```csharp
    public class Singleton{
        private static Singleton instance;
        int x,y;
        public static Singleton getInstance(int x, int y){
            if(instance == null)
                instance = new Singleton(x,y);
            else{
                instance.x = x;
                instance.y = y;
            }return instance;
        }
        private Singleton(int x, int y){
            this.x = x;
            this.y = y;
        }
    }
```

#### 单例继承模式

> 反射法

```csharp
 public class InheritSingleton<T> where T : InheritSingleton<T>
{
    private InheritSingleton() { }
    private static readonly Lazy<T> instance = new Lazy<T>(() =>
    {
        var ctors = typeof(T).GetConstructors(
          BindingFlags.Instance
          | BindingFlags.NonPublic
          | BindingFlags.Public);
        if (ctors.Count() != 1)
            throw new InvalidOperationException(String.Format("Type {0} must have exactly one constructor.", typeof(T)));
        // 子类可以设置为仅拥有私有或受保护的构造函数
        var ctor = ctors.SingleOrDefault(c => !c.GetParameters().Any() &&
        /* 按需求选择搭配 */
        (c.IsPrivate /* 是否私有 */ || c.IsFamily /* 是否派生 */ || c.IsAssembly /* 是否程序集可见 */ ));
        if (ctor == null)
            throw new InvalidOperationException(String.Format("The constructor for {0} must be private or protected and take no parameters.", typeof(T)));
        return (T)ctor.Invoke(null);
    }, true);
    public static T Instance => instance.Value;
}
```

#### 多线程安全

> 内联初始化 (静态构造)

```csharp
    public class Singleton{
        public static readonly Singleton Instance = new Singleton();
    }
```

> 锁构造方式

```csharp
    public class Singleton{
        private static volatile Singleton instance = null;
        private static object locker = new object();
        public static Singleton Instance{
            get{
                if(instance == null)
                    lock(locker){
                        if(instance == null)
                            instance = new Singleton();
                    }
                return instance;
            }
        }
    }
```

> 延迟初始化 (System.Lazy)

```csharp
    public class Singleton{
        private static readonly Lazy<Singleton> instance =
            new Lazy<Singleton>(()=>new Singleton());
        public static Singleton Instance => instance.Value;
    }
```

#### 接口的抽象静态单例实现

- 可以在接口中声明，抽象静态单例属性，要求所有派生实现类需要提供这样的静态单例。

```csharp
public interface ISingleton<T> where T : ISingleton<T>
{
    static abstract T Instance { get; }
}
class SingleClassA : ISingleton<SingleClassA>
{
    private static readonly SingleClassA s_ins = new SingleClassA();
    public static SingleClassA Instance => s_ins;
}
class SingleClassB : ISingleton<SingleClassB>
{
    private static readonly SingleClassB s_ins = new SingleClassB();
    public static SingleClassB Instance => s_ins;
}
```

#### 线程单例模式

- 每个线程一个单例。

```csharp
internal class ThreadSingleton(int threadId)
{
    public int ThreadSingletonID => threadId;
    [ThreadStatic]
    private static ThreadSingleton s_instance;  // 不能使用 readonly，只读静态字段初始化只调用一次静态构造函数。
    public static ThreadSingleton Instance => s_instance ??= new ThreadSingleton(Thread.CurrentThread.ManagedThreadId); 
}
```

>---
### 案例实现

1. [C# 实现](../../_DP_04_程序参考/DesignPatterns%20For%20CSharp/Creational%20Patterns/Singleton/Singleton.cs)
2. ...

---