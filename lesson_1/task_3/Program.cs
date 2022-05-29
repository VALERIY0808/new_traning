// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Первый вариант является ли число 4 четным");

int a = 4;
int b = 0;
b = a % 2;

if (b == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}

Console.WriteLine("Второй вариант является ли число -3 четным");

a = -3;
b = 0;
b = a % 2;

if (b == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}

Console.WriteLine("Третий вариант является ли число 7 четным");

a = 7;
b = 0;
b = a % 2;

if (b == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число является нечетным");
}

Console.WriteLine("Задача решена");