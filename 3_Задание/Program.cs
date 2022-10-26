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
                    Console.Write("Введите число №1 = ");
                    uint a = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Введите число №2 = ");
                    uint b = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine($"{a}+{b}={a + b}");
                    Console.WriteLine($"{a}-{b}={a - b}");
                    Console.WriteLine($"{a}*{b}={a * b}");
                    Console.WriteLine($"{a}/{b}={a / b}");
            }
            catch
            {
                    Console.WriteLine("Число не может быть отрицательным");
            }
        }
    }
}
