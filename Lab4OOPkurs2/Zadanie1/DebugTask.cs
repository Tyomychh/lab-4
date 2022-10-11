using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Zadanie1
{
    internal class DebugTask<T>
    {
            public void GetInDebugMethod(T first, T second)
            {

                Debug.WriteLine(first);
                Debug.WriteLine(second);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Тип першого параметра : {first.GetType()} i значення:  ");
                Console.WriteLine(first);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Тип другого параметра : {second.GetType()} i значення:  ");
                Console.WriteLine(second);

                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }