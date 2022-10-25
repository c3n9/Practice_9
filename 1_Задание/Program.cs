
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Задание
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
                Console.WriteLine("R = U/I = " + (double)u/i);
            }
            catch
            {
                Console.WriteLine("Неверный формат ввода");
            }
        }
    }
}
