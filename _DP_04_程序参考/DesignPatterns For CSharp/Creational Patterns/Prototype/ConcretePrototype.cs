using Newtonsoft.Json;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace DesignPatterns_For_CSharp.Creational_Patterns.Prototype
{
    public class DefaultPrototype : Prototype
    {
        protected Shape defaultShape;
        public DefaultPrototype()
        {
            if (defaultShape == null)
                this.defaultShape = new Circle("1001", "Circle");
        }
        protected DefaultPrototype(Shape shape) : this()
        {
            this.defaultShape = shape;
        }
        public override Shape DeepClone()
        {
            // 自由选择深拷贝方式
            return defaultShape.serializerClone();
        }
        public override Shape WiseClone()
        {
            try
            {
                Circle? cir = defaultShape.Clone() as Circle;
                return cir;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
    public class RectanglePrototype : DefaultPrototype
    {
        public RectanglePrototype() : base(new Rectangle("1002", "Rectangle")) { }
        public override Shape WiseClone()
        {
            try
            {
                Rectangle? cir = defaultShape.Clone() as Rectangle;
                return cir;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
    public class SquarePrototype : DefaultPrototype
    {
        public SquarePrototype() : base(new Square("1002", "Square")) { }
        public override Shape WiseClone()
        {
            try
            {
                Square? cir = defaultShape.Clone() as Square;
                return cir;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
    }
    static class DeepWiseExpansion
    {
        /// <summary>
        /// 使用二进制流进行 对象深拷贝, 要求对象必须具有 [Serializable] 属性
        /// </summary>
        [Obsolete("在 5.0 后续版本中逐渐 obsolute")]
        public static T CloneObject<T>(this T source) where T : Shape
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
        /// <summary>
        /// 利用序列化与反序列化进行 对象深拷贝
        /// </summary>
        public static T serializerClone<T>(this T source) where T : Shape
        {
            if (Object.ReferenceEquals(source, null))
                return default(T);
            JsonSerializerSettings serializerSettings = new JsonSerializerSettings
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace
            };
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), serializerSettings);
        }
        /// <summary>
        /// 利用反射进行 对象深拷贝
        /// </summary>
        public static T ReflectClone<T>(this T source) where T : class
        {
            if (source is string || source.GetType().IsValueType)
                return source;
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
            return retval as T;
        }
        /// <summary>
        /// 利用 XML 序列化进行 对象深拷贝
        /// </summary>
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
        /// <summary>
        /// 利用 DataContract 序列化进行 对象深拷贝
        /// </summary>
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
    }
}