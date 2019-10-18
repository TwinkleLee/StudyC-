using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MyArrayList
    {
        public void Do()
        {
            var initArray = new MyArray().Do();
            //var intArrayList = initArray.ToList();
            var intArrayList = new ArrayList(initArray);
            //Console.WriteLine(initArray.Length);
            Console.WriteLine(intArrayList);
        }
    }
    class MyArray
    {
        public int[] Do()
        {
            int[] intArray = { 3, 2, 1,1 };
            Console.WriteLine(intArray);
            return intArray;
        }
    }
    class MyList
    {
        public void Do()
        {
            var list = new List<string> { "name", "Ana", "Felipe" };
            var list2 = new List<string>(list);
            var stringArrayList = new ArrayList { "hello"};
            var index = list2.IndexOf("Felipe");

            Console.WriteLine(list);
        }
        public object Feibonaqi(int initIndex)
        {
            var index = initIndex - 1;
            if (index == 0 || index == 1) return 1;
            var newList = new List<int> { 1,1 };
            for(var i = 2; i <= index; i++)
            {
                newList.Add(newList[i-2]+ newList[i-1]);
            }
            return newList[newList.Count - 1];

        }
    }

}
