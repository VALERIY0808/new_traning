// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[size];
int contr = 0;
for (int i = 0; i<size; i++)
{
    arr [i] = new Random().Next(-99,100);
    Console.Write($"{arr[i]}  ");
    if (i % 2 != 0)
    {
        contr+=arr[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {contr}");