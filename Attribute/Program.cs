using System;
using System.Reflection;

namespace Attribute
{
    public class MySpecialAttribute : System.Attribute
    {
        public MySpecialAttribute(string str,int num)
        {

        }
        public MySpecialAttribute()
        {

        }
    }

    [MySpecial]
    public class SomeOtherClass
    {
        private string name = "tk";
    }
    [MySpecial("hello",100)]
    public class SomeOtherClass2
    {

    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new SomeOtherClass().GetType();
    //        Console.WriteLine(obj);
    //        var classType = typeof(SomeOtherClass);
    //        Console.WriteLine(classType);

    //        var typeInfo = typeof(SomeOtherClass);
    //        Console.WriteLine(typeInfo);
    //        //TypeInfo typeInfo = typeof(SomeOtherClass).GetTypeInfo();
    //        //Console.WriteLine(typeInfo);

    //        var attrs = typeInfo.GetCustomAttributes();
    //        foreach (var attr in attrs)
    //            Console.WriteLine("Attribute on MyClass: " + attr.GetType().Name);

    //        Console.WriteLine("Hello World!");
    //    }
    //}
}
