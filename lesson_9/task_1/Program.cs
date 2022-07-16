// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}
int N = InputNumbers("Введите N: ");
int count = 2;
PrintNumber(N, count);
Console.Write(1);
