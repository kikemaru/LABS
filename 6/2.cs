using System;

class Triangle {

private double angle1, angle2, angle3, side1, side2, side3;

public void set_sides(){
side1 = Convert.ToDouble(Console.ReadLine());
side2 = Convert.ToDouble(Console.ReadLine());
side3 = Convert.ToDouble(Console.ReadLine());
}

public void set_angles(){
angle1 = Convert.ToDouble(Console.ReadLine());
angle2 = Convert.ToDouble(Console.ReadLine());
angle3 = Convert.ToDouble(Console.ReadLine());
}

public double square(){
double square, p;
p=(side1+side2+side3)/2;
square = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3));
return square;
}

public double perimeter(){
double perimeter;
perimeter = side1+side2+side3;
return perimeter;
}

public void hight(){
double h1, h2, h3, p;
p=(side1+side2+side3)/2;
h1 = Math.Sqrt(4*p*((p-side1)*(p-side2)*(p-side3))/(side1*side1));
h2 = Math.Sqrt(4*p*((p-side1)*(p-side2)*(p-side3))/(side2*side2));
h3 = Math.Sqrt(4*p*((p-side1)*(p-side2)*(p-side3))/(side3*side3));
Console.WriteLine("Высоты треугольника: {0} {1} {2}", h1, h2, h3);
}

public void kind_of_triangle(){
if ((side1 == side2 && side1 == side3)){
Console.WriteLine("равносторонний треугольник");
} else if((side1 == side2) || (side2 == side3) || (side3 == side1)){
Console.WriteLine("равнобедренный треугольник");
} else if((angle1==90)||(angle2==90)||(angle3==90)){
Console.WriteLine("прямоугольный треугольник");
}
}
}

public class Program
{
public static void Main()
{
Triangle r = new Triangle();
Console.WriteLine("Введите стороны треугольника »");
r.set_sides();
Console.WriteLine("Введите углы треугольника »");
r.set_angles();
Console.WriteLine("Площадь = {0}", r.square());
Console.WriteLine("Периметр = {0}", r.perimeter());
r.hight();
Console.WriteLine("Вид треугольника:");
r.kind_of_triangle();
}
}