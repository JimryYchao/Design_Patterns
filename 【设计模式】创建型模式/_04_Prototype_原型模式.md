# Prototype Pattern

---

- [Prototype Pattern](#prototype-pattern)
- [1. 原型模式(Prototype)](#1-原型模式prototype)
- [2. 意图](#2-意图)
- [3. 动机](#3-动机)
- [4. 适用性](#4-适用性)
- [5. 结构与参与者](#5-结构与参与者)
- [6. 原型模式优缺点](#6-原型模式优缺点)
- [7. 实现](#7-实现)
- [8. 设计要点](#8-设计要点)
- [9. CSharp 中的深拷贝与浅拷贝](#9-csharp-中的深拷贝与浅拷贝)
	- [9.1 浅拷贝](#91-浅拷贝)
	- [9.2 深拷贝](#92-深拷贝)
- [10. 案例实现](#10-案例实现) 

---
# 1. 原型模式(Prototype)

- 原型模式（Prototype Pattern）是用于创建重复的对象，同时又能保证性能。这种类型的设计模式属于创建型模式，它提供了一种创建对象的最佳方式。

- 这种模式是实现了一个原型接口，该接口用于创建当前对象的克隆。当直接创建对象的代价比较大时，则采用这种模式。例如，一个对象需要在一个高代价的数据库操作之后被创建。我们可以缓存该对象，在下一个请求时返回它的克隆，在需要的时候更新数据库，以此来减少数据库调用。

> 依赖关系的倒置

- 抽象不应该依赖于实现细节，实现细节应该依赖于抽象。
  - 抽象 A 直接依赖于实现细节 b（人用陶瓷水杯喝水，人直接依赖于陶瓷水杯）
  - 抽象 A 依赖于抽象 B，实现细节 b 依赖于抽象 B（人 A 用杯子 B 喝水，杯子是陶瓷水杯 b）

---
# 2. 意图

- 用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。**主要解决：在运行期建立和删除原型**，利用已有的一个原型对象，快速地生成和原型对象一样的实例

- 何时使用： 
  1. 当一个系统应该独立于它的产品创建，构成和表示时。 
  2. 当要实例化的类是在运行时刻指定时，例如，通过动态装载。 
  3. 为了避免创建一个与产品类层次平行的工厂类层次时。 
  4. 当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。

---
# 3. 动机

- 在软件系统中，经常面临着 “某些结构复杂的对象” 的创建工作；由于需求的变化，这些对象经常面临着剧烈的变化，但是它们却拥有比较稳定一致的接口。
- 如何应对这种变化? 如何向 “客户程序 (使用这些对象的程序)” 隔离出 “这些易变对象”，从而使得 “依赖这些易变对象的客户程序” 不随着需求改变而改变?

---
# 4. 适用性

> 使用 Prototype 的几种情况

- 当一个系统应该独立与它的产品创建、构成和表示时
- 当要实例化的类是在运行时刻指定时，如动态装载
- 为了避免创建一个与产品类层次平行的工厂类层次时
- 当一个类的实例只能有几种不同状态组合中的一种时，建立相应的数目原型并克隆它们可能比每次用合适的状态手动实例化该类更方便

---
# 5. 结构与参与者

> 原型模式

  ![原型模式](img/原型模式设计.png)

> 参与者

- Prototype：声明一个克隆自身的接口
- ConcretePrototype：实现一个克隆自身的操作
- Client：让一个原型克隆自身从而创建一个新的对象

---
# 6. 原型模式优缺点

> 优点 
  
- 有助于性能提高：减少了构造函数的调用
- 运行时刻增加和删除产品：Prototype 允许只通过客户注册原型实例就可以将一个新的具体产品类并入系统
- 改变值以指定新对象：高度动态的系统允许通过复合定义的方式为原型实例创建新的行为，如为一个对象变量指定值就可以有效定义新类别的对象
- 改变结构以指定新对象：许多应用由部件与子部件来创建对象，Prototype 可以通过深拷贝方式来构建具有不同结构的对象
- 减少子类的构造：通过克隆原型而避免创建一个对象的平行工厂类进行构建对象
- 用类动态配置应用：一个希望创建动态载入类的实例的应用不能静态引用类的构造器，而由运行环境在载入时自动创建每个类的实例，并用原型管理器来注册这个实例

> 缺点： 
 
- 配备克隆方法需要对类的功能进行通盘考虑，这对于全新的类不是很难，但对于已有的类不一定很容易，特别当一个类引用不支持串行化（拷贝）的间接对象，或者引用含有循环结构的时候。 
- 每一个 Prototype 的子类都必须实现 Clone 操作
---
# 7. 实现

> 当实现原型时，要考虑

1. 使用一个原型管理器：当一个系统中原型数目不固定时，它们可以动态的创建和销毁，要保持一个可用原型的注册表；客户只会在这个注册表中存储和检索原型
2. 实现克隆操作：浅拷贝意味着拷贝与原型之间共享指针；对于一个结构复杂对象通常会使用深拷贝方式，复制的对象与原型之间相互独立
3. 初始化克隆对象：在克隆中传递参数一般会破坏克隆接口的一致性，有时也会需要选择一些值初始化该对象的部分或全部内部状态。由于可能传递参数，有时会不得不引入一个 Initialize 操作，该操作使用初始化参数并依据此设定对象的内部状态

> 注意事项：与通过对一个类进行实例化来构造新对象不同的是，原型模式是通过拷贝一个现有对象生成新对象的。浅拷贝实现 Cloneable，重写，深拷贝是通过实现 Serializable 读取二进制流。

---
# 8. 设计要点

- Prototype 模式同样用于隔离类对象的使用者和具体类型 (易变类) 之间的耦合关系，它同样要求这些 “易变类” 拥有 “稳定的接口”
- Prototype 模式对于 “如何创建易变类的实体对象” 采用 “原型克隆” 的方法来做，它使得我们可以非常灵活地动态创建 “拥有某些稳定接口” 的新对象——所需工作仅仅是注册一个新类的对象 (即原型)，然后在任何需要的地方不断地 Clone。
- Prototype 模式中的 Clone 方法可以利用，DotNET 中的 Object 类的 MemberwiseClone() 方法浅拷贝或者序列化来实现深拷贝。

---
# 9. CSharp 中的深拷贝与浅拷贝

## 9.1 浅拷贝

```csharp
    public class WiseCloneDemo
    {
        WiseCloneDemo wiseClone;
        public WiseCloneDemo WiseClone()
        {
            WiseCloneDemo wise = null;
            if (wiseClone == null)
                wiseClone = new WiseCloneDemo();
            try
            {
                wise = wiseClone.MemberwiseClone() as WiseCloneDemo;
            }
            catch (Exception e)
            {
                Console.WriteLine("[ WiseClone Failed ]:" + e.Message);
            }
            return wise;
        }
    }
```

---
## 9.2 深拷贝

> 二进制流

```csharp
    // 使用二进制流进行 对象深拷贝, 要求对象必须具有[Serializable]属性
    public static T CloneObject<T>(this T source) where T : class
    {
        if (!typeof(T).IsSerializable)
            throw new ArgumentException("The type must be Serializable.", "source");
        if (Object.ReferenceEquals(source, null))
            return default(T);
        IFormatter formatter = new BinaryFormatter();
        Stream stream = new MemoryStream();
        using (stream)
        {
            formatter.Serialize(stream, source);
            stream.Seek(0, SeekOrigin.Begin);
            stream.Close();
            return (T)formatter.Deserialize(stream);
        }
    }
    
```

> 序列化与反序列化

```csharp
    // using Newtonsoft.Json;
    // 利用序列化与反序列化进行 对象深拷贝
    public static T serializerClone<T>(this T source) where T : class
    {
        if (Object.ReferenceEquals(source, null))
            return default(T);
        JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ObjectCreationHandling = ObjectCreationHandling.Replace
        };
        return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), serializerSettings);
    }
```

> 反射

```csharp
    /// 利用反射进行 对象深拷贝
    public static T ReflectClone<T>(this T source) where T : class
    {
        if (source is string || source.GetType().IsValueType)
        {
            return source;
        }
        object retval = Activator.CreateInstance(source.GetType());
        FieldInfo[] fields = source.GetType().GetFields(BindingFlags.Public 
            | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        foreach (FieldInfo item in fields)
        {
            try
            {
                item.SetValue(retval, ReflectClone(item.GetValue(source)));
            }
            catch (Exception)
            {
                Console.WriteLine("ReflectClone failed");
            }
        }
        return (T)retval;
    }
```

> XML 序列化

```csharp
    /// 利用XML序列化进行 对象深拷贝
    public static T xmlSerClone<T>(this T source) where T : new()
    {
        T docItms = new T();
        using (MemoryStream ms = new MemoryStream())
        {
            XmlSerializer xms = new XmlSerializer(docItms.GetType());
            xms.Serialize(ms, source);
            ms.Seek(0, SeekOrigin.Begin);
            docItms = (T)xms.Deserialize(ms);
            ms.Close();
        }
        return docItms == null ? default(T) : docItms;
    }
```

> DataContractSerializer 序列化

```csharp
    /// 利用 DataContract 序列化进行 对象深拷贝
    public static T DataSerClone<T>(this T source) where T : new()
    {
        T docItms = new T();
        using (MemoryStream ms = new MemoryStream())
        {
            DataContractSerializer ser = new DataContractSerializer(docItms.GetType());
            ser.WriteObject(ms, source);
            ms.Seek(0, SeekOrigin.Begin);
            docItms = (T)ser.ReadObject(ms);
            ms.Close();
        }
        return docItms == null ? default(T) : docItms;
    }
```

---
# 10. 案例实现

- 我们将创建一个抽象类 Shape 和扩展了 Shape 类的实体类。下一步是定义类 ShapeCache，该类把 shape 对象存储在一个 Hashtable 中，并在请求的时候返回它们的克隆。
- PrototypPatternDemo，我们的演示类使用 ShapeCache 类来获取 Shape 对象。

> 案例示意

  ![案例实例](img/原型模式案例.png)

> 代码实现

1. [C# 实现](/【设计模式】程序参考/DesignPatterns%20For%20CSharp/Creational%20Patterns/Prototype/Prototype.cs)
2. ...

---