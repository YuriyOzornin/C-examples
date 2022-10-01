// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


 System.Console.Write("Enter first number : ");
 int squareNumber = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Enter last number : ");
 int number = Convert.ToInt32(Console.ReadLine());

 if(squareNumber == number * number)
 {
 Console.WriteLine( "Yes");
 }
 else
 {
 Console.WriteLine( "No");
 }