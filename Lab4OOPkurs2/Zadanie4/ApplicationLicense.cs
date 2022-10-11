using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie4
{
    internal class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версiя");
        }

        public void AllowPro()
        {
            Console.WriteLine("Платна версiя");
        }
    }
}
