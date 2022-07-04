// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void PrintArr(int [] array)
{
    Console.Write("[ ");
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ]");
}
int[] SetArray (int length)
{
    
    int [] array = new int[length];
    for(int i = 0; i<length;i++)
    {
        Console.Write($"Введите {i+1} число:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int ArrayContr(int [] array,int length)
{
    int contr = 0;
    for(int i = 0; i<length;i++)
    {
        if (array[i] > 0)
        {
            contr = contr + 1;
        }
    }
    return contr;
}
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int [] arr = SetArray(M);
PrintArr(arr);
int contrdig = ArrayContr(arr,M);
Console.Write($"Количество чисел больше 0 = {contrdig} ");
