//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
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
Console.WriteLine();
Console.WriteLine("введите координаты поиска элемента массива");
Console.Write("Введите  столбец ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите строку ");
int line = Convert.ToInt32(Console.ReadLine());

if (column>0 && line >0 && column <=n && line <=n)
{
Console.WriteLine($"Искомый элемент массива = {matrix[line-1,column-1]}");
Console.WriteLine($"Массив :");
for (int i = 0; i<m; i++)
{
    for (int j = 0; j<n; j++)
    {
       Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
} 
}
else
{
    Console.WriteLine("Такого элемента нет");
}