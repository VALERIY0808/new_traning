// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
} 
Console.WriteLine();

for (int i = 0; i<m; i++)
{
    double sum = 0;
    double contr = 0;
    double averagesum = 0;
    for (int j = 0; j<n; j++)
    {
        sum = sum + matrix[j,i];
        contr += 1;
    }
    averagesum = sum/contr;
   
    Console.WriteLine($"Среднее арифметическое столбца {i+1} = {averagesum}");
} 