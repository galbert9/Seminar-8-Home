// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix = { { 2, 4}, { 3, 2} };
int[,] matrix2 = { { 3, 4}, { 3, 3} };
int[,] matrixMulti = new int [2,2];

Console.WriteLine();
Console.WriteLine("Первый массив");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Второй массив");
PrintArray(matrix2);

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
Console.WriteLine();

// произведение матриц
for (int i = 0; i < matrixMulti.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMulti.GetLength(1); j++)
        {
            int sum = 0;            
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                sum = matrix[i,k] * matrix2[k,j] + sum;
            }
        matrixMulti[i,j] = sum;
        }
        
    }
Console.WriteLine("Произведение матриц");
PrintArray(matrixMulti);
Console.WriteLine();