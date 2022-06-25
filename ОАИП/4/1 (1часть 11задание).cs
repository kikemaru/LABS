using System;

public class Program
{
	public static void Main()
	{
		var rand = new Random();
int n = 12, k = 3;
int[,] a = new int[k, n];
for(int i=0; i<k; i++){
for(int j=0; j<n; j++){
a[i, j]=(rand.Next()%35+25)*1000;
Console.Write("{0} ", a[i, j]);
}
Console.WriteLine();
}
Console.WriteLine("Общая сумма, выплаченная всеми работниками:");
int s = 0;
for (int i = 0; i < k; i++){
for (int j = 0; j < n; j++ ){
s += a[i, j];
}
}
Console.WriteLine("{0}\nЗарплата каждого работника за квартал:",s);
s = 0;
for (int j = 0; j < n; j++ )
{
s = 0;
for (int i = 0; i < k; i++ )
{
s += a[i, j];
}
Console.Write("{0} ",s);
}
Console.WriteLine("\nОбщие зарплаты всех работников по месяцам:");
for (int i = 0; i < k; i++ )
{
s = 0;
for (int j = 0; j < n; j++ )
{
s += a[i, j];
}
Console.Write("{0} ",s);
}
Console.WriteLine();
	}
}