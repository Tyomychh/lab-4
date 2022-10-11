using System;
using static System.Net.Mime.MediaTypeNames;

namespace Zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            Console.WriteLine("Введiть свiй код, щоб визначити доступ до програми");
            code = Convert.ToInt32(Console.ReadLine());
            ApplicationKey applicationKey = new ApplicationKey(code);
            Console.WriteLine($"Ваш код : {code}");
            applicationKey.DoWork(10, 2);
        }
    }
}
