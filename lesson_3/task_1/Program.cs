// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.Write("Введите пятизначное число число:  ");
string? num = Console.ReadLine();
int contr = Convert.ToInt32(num);
if (contr<10000)
{
    Console.WriteLine("Число должно быть пятизначным");
}
else
{
    if ((num[0]==num[4]) && (num[1]==num[3]))
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}