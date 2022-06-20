// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
Console.Write("Введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (secondnumber == firstnumber*firstnumber)&&(firstnumber==secondnumber*secondnumber)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}