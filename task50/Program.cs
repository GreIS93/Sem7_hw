// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1, 3] -> 3

void FillArray(int[,] matrix, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(start, end);
        }
    }
}

void PrintArray(int[,] matr)
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
int[,] matrix = new int[m, n];
FillArray(matrix, 0, 10);
PrintArray(matrix);

Console.WriteLine("Введите позицию элемента");
int i = int.Parse(Console.ReadLine());
int j = int.Parse(Console.ReadLine());
if (i > (m - 1) || j > (n - 1)) Console.WriteLine("Такого элемента нет");
else Console.WriteLine(matrix[i, j]);