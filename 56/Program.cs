// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();


Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
WriteLine("Сформированный рандомный массив");
PrintArray(array);
int []sumarr= SumArray(array);

WriteLine($"Сумма элементов в каждой строке: {String.Join(" ", (sumarr))}");//вывод на экран элементы массива

int StrMin=(MinSearch(sumarr));
WriteLine($"Минимальная сумма элементов в строке {StrMin}");


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}

int [] SumArray(int[,] inArray)

{
    int[] sum = new int[inArray.GetLength(0)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    { 
    for (int j = 0; j < inArray.GetLength(1); j++)
    {

        sum[i]=sum[i]+inArray[i,j];
        
    }
    }
    return sum;
}


int MinSearch(int[] inarr)
{
int minStr=1;
int minZnach = inarr[0];
for (int i = 1; i < inarr.Length; i++)
{
    if (minZnach>inarr[i])
    {
        minStr=i+1;
        i=i;
    }
}
return minStr;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}