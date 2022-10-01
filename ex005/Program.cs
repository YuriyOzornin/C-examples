// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 4
 Console.Write("Enter number:");
// convert = конвертирует string в другую переменную
 int number = Convert.ToInt32(Console.ReadLine());

 int value = number * number;

 System.Console.WriteLine("square number:"+value);