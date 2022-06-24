using System;

public class calc {
public double first;
public double second;
public double equation(double y) {
var x = (y-second)/first;
return x;
}
}

public class Program {
public static void Main() {
calc ur = new calc();
Console.WriteLine("Введите значение y »");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение A »");
ur.first = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение B »");
ur.second = Convert.ToDouble(Console.ReadLine());
Console.Write("Корень уравнения = {0}", ur.equation(y));

}
}