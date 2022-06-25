using System;
namespace LR1._2
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Введите два числа:");
           int a, b;
           a = Convert.ToInt32(Console.ReadLine());
           b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine((a+b)*(a+b));
       }
   }
}