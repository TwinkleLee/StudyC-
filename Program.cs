using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            //new Child().Do2();
            //new Father().Do();
            //new Person().Shout();
            //Console.WriteLine(NameScape.NameScape.ShowString);

            //new Number().Compute();

            //new MyArray().Do();
            //new MyArrayList().Do();
            //new MyList().Do();

            
            Console.WriteLine(new MyList().Feibonaqi(5));

            Console.WriteLine("\n输入任意键退出");
            Console.ReadKey();


        }
    }
}
