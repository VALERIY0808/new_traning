// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;
int a = 1;
while (i < N)
{
    if (a % 2 == 0)
    {
        Console.Write("Четное число =");
        Console.WriteLine(a);
    }
    a = a + 1;
    i = i + 1;
}
Console.WriteLine("Задача решена");