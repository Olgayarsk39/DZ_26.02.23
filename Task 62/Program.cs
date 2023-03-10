/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
using System;
using static System.Console;

Clear();
Write("введите количество строк - ");
int rows = int.Parse(ReadLine());

Write("введите количество столбцов - ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns);
WriteLine();
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m,n];
    int Ibeg = 0;
    int Ifin = 0;
    int Jbeg = 0;
    int Jfin = 0;

    int number = 1;
    int i = 0;
    int j = 0;

    while (number <= result.GetLength(0) * result.GetLength(1))
    {
        result [i,j] = number;
        if (i == Ibeg && j < result.GetLength(1) - Jfin - 1)
            j++;
        else if (j == result.GetLength(1) - Jfin - 1 && i < result.GetLength(0) - Ifin - 1)
            i++;
        else if (i == result.GetLength(0) - Ifin - 1 && j > Jbeg)
            j--;
        else
            i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != result.GetLength(0) - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        number++;
    }
    return result;
}
void PrintArray(int[,] InArray)
{
    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            Write($" {InArray[i, j]} ");
        }
        Console.WriteLine("");
    }
}
