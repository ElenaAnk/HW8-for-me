/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] matrix1 = GetArray(2, 2, 1, 9);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = GetArray(2, 2, 1, 9);
PrintArray(matrix2);
int[,] resultMatr = new int[2, 2];
result(matrix1, matrix2);
Console.WriteLine();
PrintArray(resultMatr);




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


void result(int[,] array1, int[,] array2)

{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatr.GetLength(1); j++)
        {
            int result = 0;
            for (int k = 0; k < resultMatr.GetLength(1); k++)
            {
                result += array1[i, k] * array2[k, j];
            }
            resultMatr[i, j] = result;
        }
    }
}