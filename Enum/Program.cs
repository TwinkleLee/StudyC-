using System;

namespace Enum
{
    enum Day
    {
        Sun,
        Mon = 2,
        Tue,
        Wed
    }
    class Program
    {
        static void Main(string[] args)
        {
            var num = (int)Day.Tue;
            var day = (Day)4;
            Console.WriteLine(Day.Tue);
            Console.WriteLine(num);
            Console.WriteLine(day);

            Console.WriteLine("Hello World!");
        }
    }
}
