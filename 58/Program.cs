// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


using System;
using static System.Console;

Clear();


Write("Введите размер массивов: ");
int size = int.Parse(ReadLine());
int[,] FirstArray = GetArray(size, size, 0, 10);
int[,] SecondArray = GetArray(size, size, 0, 10);
WriteLine("Сформированный первый рандомный массив");
PrintArray(FirstArray);
WriteLine();
WriteLine("Сформированный второй рандомный массив");
PrintArray(SecondArray);

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


int[,] resultArray = new int[size,size];

MultiMatrix(FirstArray, SecondArray, resultArray);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultArray);

void MultiMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum =sum + firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

