////Напишите программу вычисления функции Аккермана с помощью рекурсии. 
////Даны два неотрицательных числа m и n.
// Работает с числами не больше 4х вариант 1
Console.Clear();

long m = EnterNumbers("Enter m: ");
long  n = EnterNumbers("Enter n: ");

long  functionAkkerman = Ack(m, n);

Console.Write($"Function the Akkerman = {functionAkkerman} ");

long  Ack(long  m, long n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

long EnterNumbers(string input) 
{
  Console.Write(input);
  long  output = Convert.ToInt64(Console.ReadLine());
  return output;
}

//вариант 2 рабочий

//Console.WriteLine("Введите число m: ");
//int m = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число n: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//int Akkerman = A(m, n);

//Console.Write($"A(m,n) = {Akkerman} ");

//int A(int m, int n)
//{
//  if (m == 0) return n + 1;
//  else if ((m > 0) && (n == 0)) return A(m - 1, 1);
//  else return (A(m - 1, A(m, n - 1)));
//}