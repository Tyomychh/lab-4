using System;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DebugTask<int> task1 = new DebugTask<int>();
            task1.GetInDebugMethod(10, 10);
        }
    }
}
