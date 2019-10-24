using System;

namespace Genericity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pair<int, string> pair = new Pair<int, string> { First = 1, Second = "two" };
            Pair<int, string> pair1 = new Pair<int, string> { First = 1 };
            Pair<int, string> pair2 = new Pair<int, string>();
            //int i = pair.First;     // TFirst is int
            //string s = pair.Second; // TSecond is string


            Test test = new Test { num = 1 };
            var newTest = test.change(test);


            Console.WriteLine(Test.age);


            Console.WriteLine("Hello World!");
        }
    }
    public class Pair<TFirst, TSecond>
    {
        public TFirst First;
        public TSecond Second;
    }

    public class Test{
        public int num;
        public static int age;
        public Test change(Test obj)
        {
            obj.num += 1;
            return obj;
        }
        static Test()
        {
            age = 20;
        }
    }

}
