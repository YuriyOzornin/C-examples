//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

 Console.Clear();
 int n = InputNumber("Enter n");
 int m = InputNumber("Enter m");
 if (n < m)
 {
     Console.WriteLine(NaturalNumber(n, m));
 }
 Console.WriteLine("error");

 int NaturalNumber(int n, int m)
 {
     if (n == m)
         return n;
     else
         Console.Write($"{NaturalNumber(n, m - 1)}, ");
     return m;
 }

 int InputNumber(string output)
 {
     Console.Write(output);
     return int.Parse(Console.ReadLine());
 }