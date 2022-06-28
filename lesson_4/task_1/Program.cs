// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B\
Console.WriteLine("Введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
int contr = 1;
for (int i = 1; i<=B;i++)
{
    contr = contr*A;   
}
Console.WriteLine($"А в натуральной степени В = {contr}");
