/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

using System;
using static System.Console;

Clear();

Write("введите через пробел количество строк и столбцов 1-ой матрицы - ");
string[] st1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int  rows1= int.Parse(st1[0]);
int columns1 = int.Parse(st1[1]);
Write("введите через пробел количество строк и столбцов 2-ой матрицы - ");
string[] st2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int  rows2= int.Parse(st2[0]);
int columns2 = int.Parse(st2[1]);
int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);
WriteLine("Произведение матриц - ");
PrintArray(DivMatrix(array1, array2));


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


int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    return matrix3;
}
