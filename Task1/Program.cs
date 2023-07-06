/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] newarray = GetArray(3, 4, 1, 9);
PrintArray(newarray);
Console.WriteLine();
SortingArray(newarray);
PrintArray(newarray);


int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
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
            Console.Write($"{inArray[i, j]}");
        }
        Console.WriteLine();
    }
}

void SortingArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)

    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k + 1] > Array[i, k])
                {
                    int temp = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }
}


