//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.**
Console.Write("Введите день недели (цифру):  ");
int date = Convert.ToInt32(Console.ReadLine());

if (date >7)
{
    Console.WriteLine("Введите правильную цифру дня недели");
}
else
{
        if ((date == 6) | (date == 7))
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}