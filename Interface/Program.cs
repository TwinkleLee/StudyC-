using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var boy = new Boy("小明");
            boy.Say();//My name is 小明
            //dog.Shout();

            IHuman girl = boy;
            girl.Say();//My name is 小明
            girl.Shout();//WOWOWOW

            IHuman child = new Boy("大志");
            child.Say();//My name is 大志
            child.Shout();//WOWOWOW

            Boy child2 = (Boy)child;
            child2.Say();//My name is 大志
            //child2.Shout();

            Console.ReadLine();
        }
    }
    interface IAnimal{
        void Shout();
    }
    interface IHuman:IAnimal
    {
        void Say();
    }
    class Boy: IHuman
    {
        readonly string name;
        public void Say()
        {
            Console.WriteLine($"My name is {name}");
        }
        void IAnimal.Shout()
        {
            Console.WriteLine("WOWOWOW");
        }
        public Boy(string name)
        {
            this.name = name;
        }
    }
}
