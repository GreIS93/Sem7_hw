
// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 5 3
// 8 4 6 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 6; 3.

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

void AverageOfColumn(int[,] matr1)
{
    double sum = 0;
    double avg = 0;
    int j=0;
    while (j<matr1.GetLength(1))
    {
        for (int i = 0; i < matr1.GetLength(0); i++) 
        {
            sum=sum+matr1[i,j];
        }
        avg=sum/matr1.GetLength(1);
        Console.WriteLine($"{(avg)}; ");
        j++;
        sum=0;
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
AverageOfColumn(matrix);