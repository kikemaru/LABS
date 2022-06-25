using System;

public class Program
{
	public const string eps22 = "0.00001";
	public static void Main()
	{
		Console.WriteLine("Выбрать метод:\n1. метод простых итераций\n2. метод Ньютона\n3. модифицированный метод ньютона.");
		int method = Int32.Parse(Console.ReadLine());
		double e1=0.001, e2 = 0.00001, x0, xn, x1, f, n, c=-0.5, y1;
	    int a=0, b=5;
        Console.WriteLine("Введите начальное приближение хо в промежутке [0; 5]:");
		x0 = Convert.ToDouble(Console.ReadLine());
		xn = x0; n=1;
		if(method==1){
			if (x0>=a && x0<=b){
				Console.Clear();
            Console.WriteLine("\nМетод простых итераций:");
				Console.WriteLine("-----------------------------------------");
				while(true){
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn+c*f;
					if (Math.Abs(x1-xn)<=e1 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e1){
						Console.WriteLine("eps={0}   | x0={1} | n={2} | xn+1={3:F6}", e1, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				} Console.WriteLine("-----------------------------------------");
				while(true){
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn+c*f;
					if (Math.Abs(x1-xn)<=e2 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e2){
						Console.WriteLine("eps={0} | x0={1} | n={2} | xn+1={3:F6}", eps22, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				}
				Console.WriteLine("-----------------------------------------");
			}else{ Console.Clear(); Console.WriteLine("Некорректно введено начальное приближение Xo!");}
		} else if(method==2){
				if (x0>=a && x0<=b){
				Console.Clear();
				Console.WriteLine("\nМетод Ньютона:");
				Console.WriteLine("-----------------------------------------");
				while(true){
					y1 = 2*Math.Cos(xn)+2*xn;//derivative
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn-(f/y1);
					if (Math.Abs(x1-xn)<=e1 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e1){
						Console.WriteLine("eps={0}   | x0={1} | n={2} | xn+1={3:F6}", e1, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				} Console.WriteLine("-----------------------------------------"); while(true){
					y1 = 2*Math.Cos(xn)+2*xn;//derivative
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn-(f/y1);
					if (Math.Abs(x1-xn)<=e2 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e2){
						Console.WriteLine("eps={0} | x0={1} | n={2} | xn+1={3:F6}", eps22, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				}
				Console.WriteLine("-----------------------------------------");
			}else{ Console.Clear(); Console.WriteLine("Некорректно введено начальное приближение Xo!");}
		}else if(method==3){
			if (x0>=a && x0<=b){
				Console.Clear();
				Console.WriteLine("\nМодифицированный метод Ньютона:");
				Console.WriteLine("-----------------------------------------");
				while(true){
					y1 = 2*Math.Cos(x0)+2*x0;//derivative
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn-(f/y1);
					if (Math.Abs(x1-xn)<=e1 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e1){
						Console.WriteLine("eps={0}   | x0={1} | n={2} | xn+1={3:F6}", e1, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				} Console.WriteLine("-----------------------------------------"); while(true){
					y1 = 2*Math.Cos(x0)+2*x0;//derivative
					f=2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5;
					x1=xn-(f/y1);
					if (Math.Abs(x1-xn)<=e2 && Math.Abs(2*Math.Sin(xn)+Math.Pow(xn, 2)-1.5)<=e2){
						Console.WriteLine("eps={0} | x0={1} | n={2} | xn+1={3:F6}", eps22, x0, n, x1);
						break;
					}
					xn = x1;
                    ++n;
				}
				Console.WriteLine("-----------------------------------------");
			}else{ Console.Clear(); Console.WriteLine("Некорректно введено начальное приближение Xo!");}
		}else{ Console.Clear(); Console.WriteLine("Некорректно указан номер метода!"); }
	}
}