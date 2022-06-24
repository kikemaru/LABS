#include <iostream>
#include <ctime>

using namespace std;

void fillArray(int *arr, int n)
{
for (int i = 0; i < n; i++)
{
arr[i] = rand() % 11;
}
}

void showArray(int *arr, int n)
{
for (int i = 0; i < n; i++)
{
cout << arr[i] << ' ';
}
cout << endl;
}

int minArray(int* arr, int n)
{
int min = arr[0];

for (int i = 1; i < n; i++)
{
if (arr[i] < min)
{
min = arr[i];
}
}
return min;
}
int main()
{
setlocale(0, "rus");
srand(time(0));
int n = 0;
cout << "Введите количество элементов: ";
cin >> n;
int* arr = new int[n];
fillArray(arr, n);
showArray(arr, n);
cout << "Минимальный элемент массива: " << minArray(arr, n) << endl;
cout << "Адрес минимального элемента массива: " << &minArray << endl;
return 0;
}