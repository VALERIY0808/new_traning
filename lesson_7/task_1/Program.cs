// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задайте размерность массива m x n:");
Console.Write("Введите  m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[m,n];
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
    {
        matrix[i,j] = new Random().NextDouble() * 20 - 10;
        double number = Math.Round(matrix[i, j], 1);
        Console.Write(number + " ");
    }
    Console.WriteLine();
} 
