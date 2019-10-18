using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Number
    {
         public void Compute()
        {
            double result = 5 / 3;
            Console.WriteLine(result);//1
            var result2 = (double)5 / 3;
            Console.WriteLine(result2);//1.66666666666667
        }
    }
}
