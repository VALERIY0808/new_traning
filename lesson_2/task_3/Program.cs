// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
Console.Write("Введите число:  ");
string num = Console.ReadLine();
int contr = Convert.ToInt32(num);
if (contr < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {num[2]}");
}
int a = Convert.ToInt32(num[2]); // Если нам нужно будет эту цифру где - то использовать