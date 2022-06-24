#include <iostream>
using namespace std;
int main()
{
   setlocale(0, "rus");
   cout << "Введите два числа: " << endl;
   int a, b, c;
   cin >> a >> b;
   c = (a + b) * (a + b);
   cout << c << endl;
}