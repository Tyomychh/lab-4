using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2
{
    internal class A
    {
        public A(B One)
        {
            Console.WriteLine($"Це клас A, i вiн приймає аргументи-нащадки класу B");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {One}");
        }
        public A(B One, B Two)
        {
            Console.WriteLine($"Це клас A, i вiн приймає аргументи-нащадки класу B");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {One}");
            Console.WriteLine($"| -- {Two}");
        }
        public A(B One, B Two, B Three)
        {
            Console.WriteLine($"Це клас A, i вiн приймає аргументи-нащадки класу B");
            Console.WriteLine("B");
            Console.WriteLine($"| -- {One}");
            Console.WriteLine($"| -- {Two}");
            Console.WriteLine($"| -- {Three}");
        }
    }
}
