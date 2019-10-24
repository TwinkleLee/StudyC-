using System;

namespace Event
{
    class Program
    {
        static int changeCount = 0;
        static void ListChanged(object sender, EventArgs e)
        {
            changeCount++;
        }
        static void Main(string[] args)
        {
            var e = new E();
            e.Changed += new EventHandler(ListChanged);
            e.OnChanged();
            e.OnChanged();
            e.OnChanged();
            Console.WriteLine(changeCount);//3
            Console.ReadLine();
        }
    }
    class E
    {
        public event EventHandler Changed;
        public void OnChanged() =>
        Changed?.Invoke(this, EventArgs.Empty);
    }
}
