using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите U - напряжение");
                int u = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите  I - силу тока");
                int i = int.Parse(Console.ReadLine());
                try
                {
                    int r = u / i;
                    Console.WriteLine("R = U/I = " + r);
                }
                catch when(i==0)
                {
                    Console.WriteLine("Деление на ноль");
                }
                 
            }
            catch
            {
                Console.WriteLine("Неверный формат ввода");
            }
        }
    }
}
