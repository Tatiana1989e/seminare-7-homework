
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
*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
CreateRandom2dArray(numbers);

if (n > numbers.GetLength(0) && m > numbers.GetLength(1))
{
    Console.WriteLine("not element");
}
else
{
    Console.WriteLine($"element value {n} rows and {m} columns equally {numbers[n-1,m-1]}");
}

Show2dArray(numbers);

void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
