using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Введите число Nb");
int nb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Mb");
int mb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите план базы");

string[] baza = new string[nb];


for (int z = 0; z < nb; z++)
{
baza[z]= Console.ReadLine();

}

Console.WriteLine("Введите число Nd");
int nd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число Md");
int md = Convert.ToInt32(Console.ReadLine());


if ((nd < nb) || (md < mb))
{
Console.WriteLine("Некорректные данные");
return;
}

Console.WriteLine("Введите план пустыни");
string[] desert = new string[nd];
for (int z=0;z<nd;z++)
desert[z] = Console.ReadLine();

int dx = md - mb;
int dy = nd - nb;
int klvo = 0;
for (int x=0;x<=dx;x++)
for(int y = 0; y <= dy; y++)
{
bool c = true;

for (int i = x; i < x + mb; i++)
{
for (int j = y; j < y + nb; j++)
if ((baza[j - y][i - x] == '#') &&(desert[j][i] == '.'))
{ c = false; break; }
if (!c) break;
}
if (c) klvo++;
}
Console.WriteLine("Количество возможных положений базы террористов {0}", klvo);
	}
}