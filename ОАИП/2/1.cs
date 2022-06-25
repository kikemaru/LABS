using System;
namespace ConsoleApplication2
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Введите три числа: ");
           var x = Convert.ToDouble(Console.ReadLine());
           var y = Convert.ToDouble(Console.ReadLine());
           var z = Convert.ToDouble(Console.ReadLine());
           var L = 5 * Math.Min(Math.Pow(x, 2), Math.Pow(y, 2)) - 3 * Math.Min(x, Math.Min(y, z));
           Console.WriteLine("L= " + L);
       }
   }
}