// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] matrix = { { 1, 4, 7, 2 }, { 5,9,2,3 }, { 8,4,2,4 }, { 5,2,6,7 }};


int SumLine (int[,] matrix, int i)
{
     // for (int i = 0; i < matrix.GetLength(0); i++)
    // {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = matrix[i, j] + sum;
        }
        // Console.WriteLine(" " + sum);
    // }
return sum;    
}

int minSum = 0;
int sum = SumLine  (matrix,0);
for (int i = 1; i < matrix.GetLength(0); i++)
{
    int buf = SumLine  (matrix, i);
    if (buf < sum)
    {
        sum = buf;
        minSum = i;
    }
}

Console.WriteLine($"\n{minSum+1} - строка с наименьшей суммой элементов равной {sum}");