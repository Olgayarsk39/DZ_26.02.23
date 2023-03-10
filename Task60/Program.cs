// /*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// // 26(1,0,1) 55(1,1,1)
// // */

using System;
using static System.Console;

Clear();

Write("введите параметры 3-х мерного массива через пробел - ");
string[] st = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int  rows= int.Parse(st[0]);
int columns = int.Parse(st[1]);
int tabl = int.Parse(st[2]);

int[,,] array = new int[rows, columns, tabl];
GetArray(array, 10, 100);
PrintArray(array);


void GetArray(int[,,] InArray, int minValue, int maxValue)
{
    int[] UnicNumbers = new int[InArray.GetLength(0) * InArray.GetLength(1) * InArray.GetLength(2)];
    int number = UnicNumbers[0];
    int index = 0;
    for (int m = 0; m < UnicNumbers.Length; m++)
    {
        UnicNumbers[m] = new Random().Next(minValue, maxValue + 1);
        number = UnicNumbers[m];
        if (m > 0)
        {
            for (int n = 0; n < m; n++)
            {
                while (UnicNumbers[m] == UnicNumbers[n])
                {
                    UnicNumbers[m] = new Random().Next(minValue, maxValue + 1);
                    number = UnicNumbers[m];
                }
                number = UnicNumbers[m];
            }
        }
    }

    for (int i = 0; i < InArray.GetLength(0); i++)
    {
        for (int j = 0; j < InArray.GetLength(1); j++)
        {
            for (int k = 0; k < InArray.GetLength(2); k++)
            {
                InArray[i, j, k] = UnicNumbers[index];
                index++;
            }
        }
    }
}


void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($" {inArray[i,j,k]} ({i},{j},{k}) ");
            }
        }
        WriteLine();
    }
}


