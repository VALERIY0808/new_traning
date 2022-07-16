//  Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
if (m==n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            matrix[i,j] = new Random().Next(-10,10);
        }
    } 
    Console.WriteLine("Массив:");
    PrintArray(matrix);
    int minsum = Int32.MaxValue;
    int indexLine = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));


}
else 
{
    Console.WriteLine("Массив не является прямоугольным");
}