// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
double [] arr = new double[size];
double max = 0;
double min = 0;
for (int i = 0; i<size; i++)
{
    arr [i] = new Random().Next(-99,100);
    Console.Write($"{arr[i]}  ");
    if(arr[i] > max)
    {
        max = arr[i];
    }
    if(arr[i]<min)
    {
        min = arr[i];
    }
}
Console.WriteLine($"Максимальный элемент массива = {max} минимальный = {min} сумма их равна {max+min}");
