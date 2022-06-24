#include <iostream>
#include <string>
using namespace std;
int main()
{
setlocale(0, "rus");
cout << "Введите имя:" << endl;
string a;
cin >> a;
cout << "Hello World " << a << endl;
}