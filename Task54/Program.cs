/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
//WriteLine();
SortMaxMin(array);
WriteLine();
PrintArray(array);

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


void SortMaxMin(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j <InArray.GetLength(1); j++)
        {
            for (int k = 0; k < InArray.GetLength(1)-1; k++)
            {
                if (array[i, k] < InArray[i, k + 1])
                {
                    int temp = InArray[i, k + 1];
                    InArray[i, k + 1] = InArray[i, k];
                    InArray[i, k] = temp;
                }
            }
        }
    }
}