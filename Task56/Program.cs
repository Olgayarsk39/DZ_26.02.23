/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой 
элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

using System;
using static System.Console;

Clear();

Write("введите количество строк - ");
int rows = int.Parse(ReadLine());

Write("введите количество столбцов - ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
MinSumElements(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}

void MinSumElements(int[,] InArray)
{
    int MinSum = 0;
    int sum = 0;
    int MinRow = 0;
    for (int j = 0; j < InArray.GetLength(1); j++)
    {
        MinSum += InArray[0, j];
    }
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++) 
        sum += InArray[i, j];
        WriteLine($"строка {i+1} -- сумма  {sum}");

        if (sum < MinSum)
        {
            MinSum = sum;
            MinRow = i;
        }
        sum = 0;
    }
    WriteLine();
    WriteLine($"Номер строки с наименьшей суммой элементов --> {MinRow+1}");
}
