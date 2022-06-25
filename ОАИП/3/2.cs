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
double summa = 0;
double day = 10;
int p, i = 0;
Console.Write("Введите P ");
p = Convert.ToInt32(Console.ReadLine());
while (summa <= 200)
{
summa = summa + day;
i = i + 1;
Console.WriteLine("В {0} день пробежал {1:F2} км. Всего {2:F2} км.", i, day, summa);
day = day + day * p / 100;
}
Console.WriteLine("После {0} дн. суммарный пробег лыжника за все дни превысил 200 км", i);
Console.ReadLine();
}
}
}