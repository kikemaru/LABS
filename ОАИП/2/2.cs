using System;
namespace ConsoleApplication2
{
   class Program
   {
       static void Main(string[] args)
       {
           int a, b, number;
           Console.WriteLine("Выберите № вопроса от 1 до 5: ");
           number = Convert.ToInt32(Console.ReadLine());
           switch (number)
           {
               case 1:
                   Console.WriteLine("Укажите единицу измерения атмосферного давления\n1) Ньютон 2) Паскаль 3) Ампер 4) Вольт 5) Ом");
                   a = Convert.ToInt32(Console.ReadLine());
                   b = 2;
                   break;
               case 2:
                   Console.WriteLine("Укажите единицу измерения атмосферного давления\n1) Ньютон 2) Паскаль 3) Ампер 4) Вольт 5) Ом");
                   a = Convert.ToInt32(Console.ReadLine());
                   b = 2;
                   break;
               case 3:
                   Console.WriteLine("Укажите единицу измерения атмосферного давления\n1) Ньютон 2) Паскаль 3) Ампер 4) Вольт 5) Ом");
                   a = Convert.ToInt32(Console.ReadLine());
                   b = 2;
                   break;
               case 4:
                   Console.WriteLine("Укажите единицу измерения атмосферного давления\n1) Ньютон 2) Паскаль 3) Ампер 4) Вольт 5) Ом");
                   a = Convert.ToInt32(Console.ReadLine());
                   b = 2;
                   break;
               case 5:
                   Console.WriteLine("Укажите единицу измерения атмосферного давления\n1) Ньютон 2) Паскаль 3) Ампер 4) Вольт 5) Ом");
                   a = Convert.ToInt32(Console.ReadLine());
                   b = 2;
                   break;
               default:
                   Console.WriteLine("Такого вопроса не существует");
                   a = 0;
                   b = 1;
                   return;
           }
           if (a == b)
           {
               Console.WriteLine("Ответ верный");
           }
           else
           {
               Console.WriteLine("Ответ неверный");
           }
       }
   }
}