// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
int contr = 0;
for (int i = 0; i<size; i++)
{
    arr [i] = new Random().Next(100,1000);
    Console.Write($"{arr[i]}  ");
    if (arr[i]%2==0)
    {
        contr += 1;
    }
}
Console.WriteLine($"Количество четных чисел массива = {contr}");