﻿/* 
Задача 52. Задать двумерный массив из целых чисел. 
Найти среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Enter the number of lines");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArray(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double medium = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        medium = (medium + numbers[i, j]);
    }
    medium = medium / n;
    Console.Write("Medium value " + medium + "; ");
}
Console.WriteLine();
PrintArray(numbers);