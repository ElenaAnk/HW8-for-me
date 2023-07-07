/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] newarray = GetArray(4, 4, 0, 0);
PrintArray(newarray);
Console.WriteLine();
SpiralArray(newarray);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SpiralArray(int[,] inArray)
{
    int s = 1;
    int i = 0;
    int j = 0;
    while (s <= inArray.GetLength(0) * inArray.GetLength(1))
    {
        inArray[i, j] = s;
        s++;
        if (i <= j + 1 && i + j < inArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= inArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > inArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}