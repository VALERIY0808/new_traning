// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число :");
string dig = Console.ReadLine();
int contr = 0;
int result = 0;
int lng = dig.Length;
for (int i = 0; i<lng;i++)
{
contr = Convert.ToInt32(dig[i].ToString());
result = result + contr;
}
Console.WriteLine($"Сумма цифр в числе {dig} = {result}");