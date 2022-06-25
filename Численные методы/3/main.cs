using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM_3
{
class Program
{
static void Main(string[] args)
{
double h, b = 2.3, a = 2, n = 5;
h = (b - a) / n;
double[] masx = { 2, 2.06, 2.12, 2.18, 2.24, 2.3};
double[] x = new double[3];

for (int i = 0; i < 3; i++)
{
Console.Write("Введите X" + (i + 1) + ": ");
x[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("| x | y(x) | PI(x) | |y(x)-PI(x)| | PII(x) | |y(x)-PII(x)| | L(x) | |y(x)-L(x)| |");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
for (int i = 0; i < 3; i++)
{
double q = (x[i] - masx[0]) / h;
double PI = 6275.2186 + q * 293.0529 + ((q * (q - 1)) / 2 * 1) * 17.49615 + ((q * (q - 1) * (q - 2)) / 3 * 2 * 1) * 0.9808 +
((q * (q - 1) * (q - 2) * (q - 3)) / 4 * 3 * 2 * 1) * 0.0609 + ((q * (q - 1) * (q - 2) * (q - 3) * (q - 4)) / 5 * 4 * 3 * 2 * 1) * 0.00346;
double t = (x[i] - masx[5]) / h;
double PII = 7925.5603 + t * 369.1692 + ((t * (t + 1)) / 2 * 1) * 20.62471 + ((t * (t + 1) * (t + 2)) / 3 * 2 * 1) * 1.10606 +
((t * (t - 1) * (t + 2) * (t + 3)) / 4 * 3 * 2 * 1) * 0.06436 + ((t * (t + 1) * (t + 2) * (t + 3) * (t + 4)) / 5 * 4 * 3 * 2 * 1) * 0.00346;
double L = (-6.72499) * Math.Pow(10, 7) * (x[i] - masx[1]) * (x[i] - masx[2]) * (x[i] - masx[3]) * (x[i] - masx[4]) * (x[i] - masx[5]) +
(3.51952) * Math.Pow(10, 8) * (x[i] - masx[0]) * (x[i] - masx[2]) * (x[i] - masx[3]) * (x[i] - masx[4]) * (x[i] - masx[5]) +
(-7.37185) * Math.Pow(10, 8) * (x[i] - masx[0]) * (x[i] - masx[1]) * (x[i] - masx[3]) * (x[i] - masx[4]) * (x[i] - masx[5]) +
(7.72446) * Math.Pow(10, 8) * (x[i] - masx[0]) * (x[i] - masx[1]) * (x[i] - masx[2]) * (x[i] - masx[4]) * (x[i] - masx[5]) +
(-4.04899209) * Math.Pow(10, 8) * (x[i] - masx[0]) * (x[i] - masx[1]) * (x[i] - masx[2]) * (x[i] - masx[3]) * (x[i] - masx[5]) +
(8.49361) * Math.Pow(10, 7) * (x[i] - masx[0]) * (x[i] - masx[1]) * (x[i] - masx[2]) * (x[i] - masx[3]) * (x[i] - masx[4]);
double y = 3 * Math.Pow(Math.E, 5 + Math.Sqrt(Math.Pow(x[i], 2) + 3));

Console.Write($"|{x[i]:F14}|");
Console.Write($"{y:F14}|");
Console.Write($"{PI:F14}|");
Console.Write($"{Math.Abs(y - PI):F14}|");
Console.Write($"{PII:F14}|");
Console.Write($"{Math.Abs(y - PII):F14}|");
Console.Write($"{L:F14}|");
Console.WriteLine($"{Math.Abs(y - L):F14}|");
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
}
}
}
}