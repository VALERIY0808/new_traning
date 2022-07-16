// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
Console.WriteLine("Задайте размерность массива А = m:");
Console.Write("Введите  m ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = new int[m,m];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<m; j++)
        {
            matrixA[i,j] = new Random().Next(-10,10);
        }
    } 
    Console.WriteLine("Массив A:");
    PrintArray(matrixA);

    Console.WriteLine("Задайте размерность массива B = n:");
Console.Write("Введите  n ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrixB = new int[n,n];
    for (int i = 0; i<m; i++)
    {
        for (int j = 0; j<m; j++)
        {
            matrixB[i,j] = new Random().Next(-10,10);
        }
    } 
    Console.WriteLine("Массив B:");
    PrintArray(matrixB);
if (m==n)
{
    int[,] matrixC = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < m; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Произведение массивов А и В:");
    PrintArray(matrixC);
}
else
{
    Console.WriteLine("Массив не является прямоугольным");
}