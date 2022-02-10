# Singleton Pattern

---

- [Singleton Pattern](#singleton-pattern)
  - [1. 单例模式(Singleton)](#1-单例模式singleton)
  - [2. 单例模式简介](#2-单例模式简介)
  - [3. 动机](#3-动机)
  - [4. 单例模式优缺点](#4-单例模式优缺点)
  - [5. 应用场景](#5-应用场景)
  - [6. 单例的常规实现](#6-单例的常规实现)
    - [6.1 单线程安全(非多线程安全特性)](#61-单线程安全非多线程安全特性)
    - [6.2 多线程安全](#62-多线程安全)
  - [7. 设计要点](#7-设计要点)

---
## 1. 单例模式(Singleton)

- 单例模式（Singleton Pattern）是 编程语言 中最简单的设计模式之一。这种类型的设计模式属于创建型模式，它提供了一种创建对象的最佳方式。
- 这种模式涉及到一个单一的类，该类负责创建自己的对象，同时确保只有单个对象被创建。这个类提供了一种访问其唯一的对象的方式，可以直接访问，不需要实例化该类的对象。

> 注意：
1. 单例类只能有一个实例。
2. 单例类必须自己创建自己的唯一实例。
3. 单例类必须给所有其他对象提供这一实例。

---
## 2. 单例模式简介

- 意图：保证一个类仅有一个实例，并提供一个访问它的全局访问点。主要解决**一个全局使用的类频繁地创建与销毁**。
- 何时使用：当您想控制实例数目，节省系统资源的时候。
- 如何解决：判断系统是否已经有这个单例，如果有则返回，如果没有则创建。
- 关键代码：构造函数是私有的。

---
## 3. 动机

- 在软件系统中，经常有这样一些特殊的类，必须保证它们在系统中只存在一个实例，才能确保它们的逻辑正确性、以及良好的效率。
- 如何绕过常规的构造器，提供一种机制来保证一个类只有一个实例?
- 这应该是类设计者的责任，而不是使用者的责任。

---
## 4. 单例模式优缺点

- 优点： 
  1. 在内存里只有一个实例，减少了内存的开销，尤其是频繁的创建和销毁实例（比如管理学院首页页面缓存）
  2. 避免对资源的多重占用（比如写文件操作）。

- 缺点：
   - 没有接口，不能继承，与单一职责原则冲突，一个类应该只关心内部逻辑，而不关心外面怎么样来实例化。

---
## 5. 应用场景

1. Windows 是多进程多线程的，在操作一个文件的时候，就不可避免地出现多个进程或线程同时操作一个文件的现象，所以所有文件的处理必须通过唯一的实例来进行。 
2. 一些设备管理器常常设计为单例模式，比如一个电脑有两台打印机，在输出的时候就要处理不能两台打印机打印同一个文件。
3. 要求生产唯一序列号。 
4. WEB 中的计数器，不用每次刷新都在数据库里加一次，用单例先缓存起来。 
5. 创建的一个对象需要消耗的资源过多，比如 I/O 与数据库的连接等。

> 注意事项: getInstance() 方法中需要使用同步锁 synchronized (Singleton.class) 防止多线程同时进入造成 instance 被多次实例化。

---
## 6. 单例的常规实现

### 6.1 单线程安全(非多线程安全特性)

1. 常规实现

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

2. CSharp 属性调用单例

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

3. 带参构造单例

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

---
### 6.2 多线程安全

1. 内联初始化(静态构造)

```csharp
    public class Singleton{
        public static readonly Singleton Instance = new Singleton();
    }
```

2. 锁构造方式

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

3. 延迟初始化(System.Lazy)

```csharp
    public class Singleton{
        private static readonly Lazy<Singleton> instance = 
            new Lazy<Singleton>(()=>new Singleton());
        public static Singleton Instance => instance.Value;
    }
```

---
## 7. 设计要点

1. Singleton模式中的实例构造器可以设置为protected以允许子类派生。
2. Singleton模式一般不要支持ICloneable接口，因为这可能会导致多个对象实例，与Singleton模式的初衷违背。
3. Singleton模式一般不要支持序列化，因为这也有可能导致多个对象实例，同样与Singleton模式的初衷违背。
4. Singletom模式只考虑到了对象创建的管理，没有考虑对象销毁的管理。就支持垃圾回收的平台和对象的开销来讲，我们一般没有必要对其销毁进行特殊的管理。
5. 不能应对多线程环境:在多线程环境下，使用Singleton模式仍然有可能得到Singleton类的多个实例对象。

---