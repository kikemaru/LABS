using System;

public class Program
{
	public static void Main()
	{
		Console.Write("Enter rows of a field: ");
int rows = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter columns of a field: ");
int columns = Convert.ToInt16(Console.ReadLine());

//fill field
var rand = new Random();
var field = new bool[rows, columns];
for (int i = 0; i < rows; ++i) {
for (int j = 0; j < columns; ++j) {
field[i, j] = rand.NextDouble() > 0.6;
Console.Write(field[i, j] ? 1 : 0);
}
Console.WriteLine();
}
for (int i = 0; i < rows; ++i) {
for (int j = 0; j < columns; ++j)
if (field[i, j]) {
if (i + 1 < rows && j + 1 < columns) {
if (field[i + 1, j] && field[i, j + 1] && field[i + 1, j + 1]) {
Console.WriteLine("Squuare was found at {0}, {1}", i, j);
return;
}
}
}
}
Console.WriteLine("Squuare was not found.");
	}
}