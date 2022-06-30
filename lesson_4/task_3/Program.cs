// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] arr = new int[8];
Console.WriteLine("Вывод массива на экран:");
for (int i = 0; i<8; i++)
{
    arr[i] = new Random().Next(0,9);
    Console.Write(arr[i] + " ");
}

