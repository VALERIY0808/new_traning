// Задача 1 Напишпте программу которая на вход принимает 2 числа и выдает, какое число большее а какое меньшее
Console.WriteLine("Первые два числа для проверки 5 и 7");
int a = 5, b = 7;
if (a > b)
{
    Console.Write("Максимальное число =");
    Console.WriteLine(a);
}
else
{
    Console.Write("Максимальное число =");
    Console.WriteLine(b);
}
Console.WriteLine("Выбор максимального числа из второго варианта (2 или 10)");

a = 2;
b = 10;

if (a > b)
{
    Console.Write("Максимальное число =");
    Console.WriteLine(a);
}
else
{
    Console.Write("Максимальное число =");
    Console.WriteLine(b);
}

Console.WriteLine("Выбор максимального числа из третьего варианта (9 или 3)");

a = 9;
b = 3;

if (a > b)
{
    Console.Write("Максимальное число =");
    Console.WriteLine(a);
}
else
{
    Console.Write("Максимальное число =");
    Console.WriteLine(b);
}

Console.WriteLine("Задача выполнена");