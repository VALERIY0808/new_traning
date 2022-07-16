// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("Задайте размерность массива m x n:");
Console.Write("Введите  m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
    {
        matrix[i,j] = new Random().Next(-10,10);
    }
} 
Console.WriteLine("Массив до внесения изменений:");
PrintArray(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)
        {
            if (matrix[i, k] < matrix[i, k + 1]) 
            {
                int contr = 0;
                contr = matrix[i, k];
                matrix[i, k] = matrix[i, k + 1];
                matrix[i, k + 1] = contr;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив после внесения изменений:");
PrintArray(matrix);