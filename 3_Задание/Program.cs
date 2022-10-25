using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                try
                {
                    Console.Write("Введите число №1 = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите число №2 = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"{a}+{b}={a + b}");
                    Console.WriteLine($"{a}-{b}={a - b}");
                    Console.WriteLine($"{a}*{b}={a * b}");
                    Console.WriteLine($"{a}/{b}={a / b}");
                }
                catch when (a<0)
                {
                    Console.WriteLine("22");
                }
              
            }
            catch
            {
                Console.WriteLine("Неверный формат ввода!");
            }
        }
    }
}
