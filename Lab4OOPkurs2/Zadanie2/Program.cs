using System;

namespace Zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            One one = new One();
            Two two = new Two();
            Three three = new Three();
            A a = new A(one, two, three);
            double y = one.Math(1, 3);
            Console.WriteLine(y);
        }
    }
}
