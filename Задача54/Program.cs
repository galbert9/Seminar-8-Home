// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// печать заданного массива

int[,] matrix = { { 4, 3, 2 }, { 5, 9, 1 } };

Console.WriteLine();
Console.WriteLine("Первоначальный массив");
PrintArray(matrix);

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int l = 0; l < matrix.GetLength(1) - 1; l++)
        {
            if (matrix[i, l] < matrix[i, l + 1]) 
            {
                int temp = 0;
                temp = matrix[i, l];
                matrix[i, l] = matrix[i, l + 1];
                matrix[i, l + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Сортированный массив по убыванию");
PrintArray(matrix);

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"\t {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}


