#include <locale>
#include <iostream>
#include <ctime>
#include <iomanip>
using namespace std;

int main()
{
setlocale(0, "rus");
srand(time(0));
int N, M;
cout << "Введите количество строк: ";
cin >> N;
cout << "Введите количество столбцов: ";
cin >> M;
int** A = new int* [N];
for (int i = 0; i < N; i++)
{
A[i] = new int[M];
}
cout << "Сформированная матрица:" << endl;
for (int i = 0; i < N; i++)
{
for (int j = 0; j < M; j++)
{
A[i][j] = 0 + rand() % 101 - 50;
cout << setw(4) << A[i][j];
} cout << endl;
}
int** B = new int* [M];
for (int i = 0; i < M; i++)
{
B[i] = new int[N];
}
cout << "Повёрнутая матрица на 90 градусов против часовой:" << endl;
for (int i = 0; i < M; i++)
{
for (int j = 0; j < N; j++)
{
B[i][j] = A[j][M - i - 1];
cout << setw(4) << B[i][j];
} cout << endl;
}
return 0;
}