
/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, m = 3, n = 4.

double[,] numbers = new double(rows, columns)
 CreateRandom2dArray(numbers);

{
  void CreateRandom2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
    }
}
}

{
  void ShowRandom2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
       for(int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
*/

