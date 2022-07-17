// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами, округлёнными до одного знака.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] matrix, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(start, end) + Math.Round((rnd.NextDouble()), 1);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
double[,] matrix = new double[m, n];
FillArray(matrix, -9, 10);
PrintArray(matrix);