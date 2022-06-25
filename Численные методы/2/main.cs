using System;

public class Program
{
public const string eps22 = "0.00001";
public static void Main()
{
double eps1 = 0.001, eps2 = 0.00001;
double x_0, x_k, y_0, y_k, z_0, z_k, k = 0, x_k_1, y_k_1, z_k_1, R_x, R_y, R_z;
Console.WriteLine("Введите x_0");
x_0 = Convert.ToInt32(Console.ReadLine());
x_k = x_0;
Console.WriteLine("Введите y_0");
y_0 = Convert.ToInt32(Console.ReadLine());
y_k = y_0;
Console.WriteLine("Введите z_0");
z_0 = Convert.ToInt32(Console.ReadLine());
z_k = z_0;


//МЕТОД ПРОСТЫХ ИТЕРАЦИЙ

Console.WriteLine(" ");
Console.WriteLine("Метод простых итераций");
Console.WriteLine(" ");
while (true)
{
x_k_1 = 1.06667 + 0.33333 * y_k + 0.5 * z_k;
y_k_1 = 2.4 - 0.6 * x_k + 0.2 * z_k;
z_k_1 = 2.5 - 0.33333 * x_k + 0.5 * y_k;
k++;
if (Math.Abs(x_k_1 - x_k) + Math.Abs(y_k_1 - y_k) + Math.Abs(z_k_1 - z_k) <= eps1)
{
Console.WriteLine("eps1={0} x={1:F0} y={2:F0} z={3:F3}", eps1, x_k_1, y_k_1, z_k_1);
break;
}
else
{
x_k = x_k_1;
y_k = y_k_1;
z_k = z_k_1;
}
}

while (true)
{
x_k_1 = 1.06667 + 0.33333 * y_k + 0.5 * z_k;
y_k_1 = 2.4 - 0.6 * x_k + 0.2 * z_k;
z_k_1 = 2.5 - 0.33333 * x_k + 0.5 * y_k;
k++;
if (Math.Abs(x_k_1 - x_k) + Math.Abs(y_k_1 - y_k) + Math.Abs(z_k_1 - z_k) <= eps2)
{
Console.WriteLine("eps2={0} x={1:F0} y={2:F0} z={3:F3}", eps22, x_k_1, y_k_1, z_k_1);
break;
}
else
{
x_k = x_k_1;
y_k = y_k_1;
z_k = z_k_1;
}
}
Console.WriteLine(" ");


//МЕТОД ЗЕЙДЕЛЯ

Console.WriteLine("Метод Зейделя");
Console.WriteLine(" ");
while (true)
{
x_k_1 = 1.06667 + 0.33333 * y_k + 0.5 * z_k;
y_k_1 = 2.4 - 0.6 * x_k_1 + 0.2 * z_k;
z_k_1 = 2.5 - 0.33333 * x_k_1 + 0.5 * y_k_1;
k++;
if (Math.Abs(x_k_1 - x_k) + Math.Abs(y_k_1 - y_k) + Math.Abs(z_k_1 - z_k) <= eps1)
{
Console.WriteLine("eps1={0} x={1:F0} y={2:F0} z={3:F3}", eps1, x_k_1, y_k_1, z_k_1);
break;
}
else
{
x_k = x_k_1;
y_k = y_k_1;
z_k = z_k_1;
}
}

while (true)
{
x_k_1 = 1.06667 + 0.33333 * y_k + 0.5 * z_k;
y_k_1 = 2.4 - 0.6 * x_k_1 + 0.2 * z_k;
z_k_1 = 2.5 - 0.33333 * x_k_1 + 0.5 * y_k_1;
k++;
if (Math.Abs(x_k_1 - x_k) + Math.Abs(y_k_1 - y_k) + Math.Abs(z_k_1 - z_k) <= eps2)
{
Console.WriteLine("eps2={0} x={1:F0} y={2:F0} z={3:F3}", eps22, x_k_1, y_k_1, z_k_1);
break;
}
else
{
x_k = x_k_1;
y_k = y_k_1;
z_k = z_k_1;
}
}
Console.WriteLine(" ");


//МЕТОД РЕЛАКСАЦИИ

Console.WriteLine("Метод релаксации");
Console.WriteLine(" ");
x_0 = 0;
y_0 = 0;
z_0 = 0;

while (true)
{
R_x = 1.06667 - x_0 + 0.33333 * y_0 + 0.5 * z_0;
R_y = 2.4 - y_0 - 0.6 * x_0 + 0.2 * z_0;
R_z = 2.5 - z_0 - 0.33333 * x_0 + 0.5 * y_0;
k++;
if (Math.Abs(R_x)>=Math.Abs(R_y) && Math.Abs(R_x) >= Math.Abs(R_z))
{
x_0 += R_x;
}
if (Math.Abs(R_y) >= Math.Abs(R_x) && Math.Abs(R_y) >= Math.Abs(R_z))
{
y_0 += R_y;
}
if (Math.Abs(R_z) >= Math.Abs(R_x) && Math.Abs(R_z) >= Math.Abs(R_y))
{
z_0 += R_z;
}

if (Math.Abs(R_x) <= eps1 && Math.Abs(R_y) <= eps1 && Math.Abs(R_z) <= eps1 )
{
Console.WriteLine("eps1={0} x={1:F0} y={2:F0} z={3:F3}", eps1, x_0, y_0, z_0);
break;
}
}

while (true)
{
R_x = 1.06667 - x_0 + 0.33333 * y_0 + 0.5 * z_0;
R_y = 2.4 - y_0 - 0.6 * x_0 + 0.2 * z_0;
R_z = 2.5 - z_0 - 0.33333 * x_0 + 0.5 * y_0;
k++;
if (Math.Abs(R_x) >= Math.Abs(R_y) && Math.Abs(R_x) >= Math.Abs(R_z))
{
x_0 += R_x;
}
if (Math.Abs(R_y) >= Math.Abs(R_x) && Math.Abs(R_y) >= Math.Abs(R_z))
{
y_0 += R_y;
}
if (Math.Abs(R_z) >= Math.Abs(R_x) && Math.Abs(R_z) >= Math.Abs(R_y))
{
z_0 += R_z;
}

if (Math.Abs(R_x) <= eps2 && Math.Abs(R_y) <= eps2 && Math.Abs(R_z) <= eps2)
{
Console.WriteLine("eps2={0} x={1:F0} y={2:F0} z={3:F3}", eps22, x_0, y_0, z_0);
break;
}
}
}
}