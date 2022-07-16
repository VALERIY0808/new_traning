// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int InputNumbers(string input) 

{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}
int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");
int temp = M;

if (M > N) 
{
  M = N; 
  N = temp;
}

PrintSumm(M, N, temp=0);