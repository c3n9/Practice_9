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
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число №2 = ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (b < 0 || a<0)
                {
                    throw new Exception("Число не должно быть отрицательным");
                }
                Console.WriteLine($"{a}+{b}={a + b}");
                Console.WriteLine($"{a}-{b}={a - b}");
                Console.WriteLine($"{a}*{b}={a * b}");
                Console.WriteLine($"{a}/{b}={a / b}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
