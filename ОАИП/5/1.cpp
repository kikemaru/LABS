#include <cmath>
#include <iostream>
using namespace std;

void function(double *a, double *b, double *c, double *s, double *p)
{
   *s = 0.5 * (*a) * (*b) * (sin(*c * 3.141592653589793 / 180));
   *p = sqrt(pow(*a, 2) + pow(*b, 2) - 2 * (*a) * (*b) * cos(*c * 3.141592653589793 / 180)) + *a + *b;
}
int main()
{
   setlocale(0, "rus");
   double a = 0, b = 0;
   double c = 0, s = 0, p = 0;
   cout << "Введите первую сторону треугольника ";
   cin >> a;
   cout << "Введите вторую сторону треугольника ";
   cin >> b;
   cout << "Введите угол между сторонами в градусах ";
   cin >> c;
   function(&a, &b, &c, &s, &p);
   cout << "Площадь треугольника = " << s << endl;
   cout << "Периметр треугольника = " << p << endl;
   return 0;
}