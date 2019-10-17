using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Father
    {
        protected int age = 2;
        public void Do()
        {
            Father father = new Father();
            Console.WriteLine(father.age);//2
            Console.ReadKey();
        }
    }
    class Child : Father
    {
        public void Do2()
        {
            Console.WriteLine(this.age);//2
            Child child = new Child();
            Console.WriteLine(child.age);//2
            //Father father = new Father();
            //Console.WriteLine(father.age);//报错
            Console.ReadKey();
        }
    }
}
