// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Первый вариант, числа 2 3 7");

int a = 2, b = 3, c = 7;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число =");
Console.WriteLine(max);

Console.WriteLine("Второй вариант, числа 44 5 78");

a = 44;
b = 5;
c = 78;

max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число =");
Console.WriteLine(max);

Console.WriteLine("Второй вариант, числа 22 3 9");

a = 22;
b = 3;
c = 9;

max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число =");
Console.WriteLine(max);

Console.WriteLine("Задача решена");