/*
Задача 50. 
Напиcать программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Enter the number of lines");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of columns");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no such element");
}
else
{
    Console.WriteLine($"The value of the {n} line and {m} column element is equal to {numbers[n-1,m-1]}");
}

PrintArray(numbers);