 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
 namespace ConsoleApplication2
 {
 class Program
 {
 static void Main(string[] args)
 {
 Console.Write("Enter real a: ");
 double a = double.Parse(Console.ReadLine());
 Console.Write("Enter natural n ");
 int n = int.Parse(Console.ReadLine());
 double result = 0;
 for (int i = 1; i <= (2 * n); i *= 2) {
 result += (Math.Pow(a, -i));
 }
 Console.Write("Result = {0}", result);
 }
  }
 }